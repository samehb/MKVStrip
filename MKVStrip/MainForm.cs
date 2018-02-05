using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace MKVStrip
{
    public partial class MainForm : Form
    {
        string AudioLanguages;
        string SubLanguages;
        string KeepAudioTracks;
        string KeepSubTracks;
        string InputDirectory;
        string OutputDirectory;

        bool IsSelectedTrackNums = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void ProcessBtn_Click(object sender, EventArgs e)
        {
            AudioLanguages = "";
            SubLanguages = "";
            KeepAudioTracks = "";
            KeepSubTracks = "";

            LoggingTextBox.Text = "Processing ...\r\n\r\n";

            IsSelectedTrackNums = TrackNumbersCheckBox.Checked;

            if (IsSelectedTrackNums) // If the user picked the track numbers option, handle it.
            {
                string tempaudiotracks = AudioFilterTextBox.Text.Replace(" ", ""); // Get rid of extra spaces
                string tempsubtracks = SubtitlesFilterTextBox.Text.Replace(" ", "");
                KeepAudioTracks = IsInteger(tempaudiotracks.Replace(",", "")) ? tempaudiotracks : ""; // Check if tempaudiotracks /  tempsubtracks are numbers after removing the commas and use them if they are.
                KeepSubTracks = IsInteger(tempsubtracks.Replace(",", "")) ? tempsubtracks : "";
            }
            else
            {
                AudioLanguages = AudioFilterTextBox.Text.Replace(",","|").Replace(" ",""); // Replace commas with pipeline to utilize it in the regex later without further work.
                SubLanguages = SubtitlesFilterTextBox.Text.Replace(",", "|").Replace(" ", "");
            }

            try
            {
                InputDirectory = SourceDirectoryTextBox.Text.TrimEnd('\\');
                OutputDirectory = DestinationDirectoryTextBox.Text.TrimEnd('\\');

                if (IsInputDataValid()) // Do not start unless all required data is available.
                {
                    if (IsSubFolder(InputDirectory, OutputDirectory)) // Simplify the process to users. 
                    {
                        LoggingTextBox.Text = "Output folder cannot be within the input folder.";
                        return;
                    }

                    if (!MKVMergeExists())
                    {
                        LoggingTextBox.Text = "mkvmerge.exe could not be found. Please place it at the same folder as this program, or the program won't function.";
                        return;
                    }

                    ProcessBtn.Enabled = false;
                    FileInfo[] files = new DirectoryInfo(InputDirectory).GetFiles("*.mkv", SearchOption.AllDirectories); // Iterate over subfolders.

                    Progress<string> progress = new Progress<string>(s => LoggingTextBox.Text += s + "\r\n");
                    foreach (FileInfo file in files) // Process the files
                    {
                        await Task.Run(() => ProcessFileAsync(file, progress));
                    }

                    LoggingTextBox.Text += "\r\nFinished.";
                    ProcessBtn.Enabled = true;
                }
                else
                    LoggingTextBox.Text = "Please, make sure you have inputted valid data.";
            }
            catch
            {

            }
        }

        private bool IsSubFolder(string input, string output)
        {
            input += @"\";
            output += @"\";
            if (output.Contains(input))
                return true;
            return false;
        }

        private bool IsInputDataValid()
        {
            return SourceDirectoryTextBox.Text != "" && DestinationDirectoryTextBox.Text != "" && Directory.Exists(SourceDirectoryTextBox.Text) && ((AudioLanguages != "" && SubLanguages != "") || (KeepAudioTracks != "" && KeepSubTracks != ""));
        }

        private bool IsInteger(string str) // Check if number is an integer
        {
            if (String.IsNullOrEmpty(str))
                return false;

            int i;
            return Int32.TryParse(str, out i);
        }

        private string StartProcess(string processname, string args)
        {
            Process proc = new Process { StartInfo = new ProcessStartInfo { FileName = processname, Arguments = args, UseShellExecute = false, RedirectStandardOutput = true, CreateNoWindow = true } };
            proc.Start();
            return proc.StandardOutput.ReadToEnd();
        }

        private void ProcessFileAsync(FileInfo file, IProgress<string> progress)
        {
            string outputfile = OutputDirectory + file.FullName.Replace(InputDirectory, "");

            if (!IsSelectedTrackNums) // If the "Use Track Numbers" option is not enabled, it means the application will deal with languages instead of numbers, and will need further processing to acquire KeepAudioTracks and KeepSubTracks. 
                GetNeededTracks(file.FullName);
            if (KeepAudioTracks != "" || KeepSubTracks != "")
            {
                string args = "-o \"" + outputfile + "\""; // Arguments builder.
                if (KeepAudioTracks != "")
                    args += " -a " + KeepAudioTracks.Trim(',') + " ";
                if (KeepSubTracks != "")
                    args += " -s " + KeepSubTracks.Trim(',') + " ";
                args += " --compression -1:none \"" + file.FullName + "\"";

                string multiout = StartProcess(@"mkvmerge.exe", args);

                //if (tempfile.Exists) //{ //    file.Delete(); //    File.Move(tempfile.FullName, file.FullName); //}

                if (multiout.Contains("Multiplexing took ")) // If the process succeeds 
                    progress.Report("Removed unneeded tracks from \"" + file.Name + "\"");
                else
                    progress.Report("Multiplexing failed for \"" + file.Name + "\"");
            }
            else
            {
                progress.Report("Did not find anything to remove in \"" + file.Name + "\"");
            }
        }

        private void GetNeededTracks(string file) // Find the tracks needed based on the filters.
        {
            int trackscount = 0;
            int selectedtrackscount = 0;

            KeepAudioTracks = "";
            KeepSubTracks = "";

            List<string> tracks = StartProcess(@"mkvmerge.exe", "--identify-verbose \"" + file + "\"").Split('\n').ToList(); // Get the mkv file data.
            foreach (string track in tracks)
            {
                if (track.Contains("Track ID")) // The application only need the Track records.
                {
                    if (!track.Contains("video")) // Count only the non-video tracks.
                        trackscount++;

                    if (track.Contains("audio"))
                    {
                        Match match = Regex.Match(track, @"Track ID (\d+): audio.+language:(" + AudioLanguages + ")"); // Match the audio tracks based on the languages that the user selected.
                        if (match.Success)
                        {
                            selectedtrackscount++;
                            KeepAudioTracks += match.Groups[1].Value + ",";
                        }
                    }
                    else if (track.Contains("subtitles"))
                    {
                        Match match = Regex.Match(track, @"Track ID (\d+): subtitles.+language:(" + SubLanguages + ")"); // Match the subs tracks based on the languages that the user selected.
                        if (match.Success)
                        {
                            selectedtrackscount++;
                            KeepSubTracks += match.Groups[1].Value + ",";
                        }
                    }
                }
            }

            if(selectedtrackscount == trackscount) // That means that the number of tracks selected based on languages equal to the number of available tracks. So, that means no processing is needed.
            {
                KeepAudioTracks = ""; // Reset them = no processing.
                KeepSubTracks = "";
            }
        }

        private string GetTracksData(string file) // Get data for tracks per file.
        {
            string tracksinfo = "";
            List<string> tracks = StartProcess(@"mkvmerge.exe", "--identify-verbose \"" + file + "\"").Split('\n').ToList(); // Get the mkv file data.
            foreach (string track in tracks)
            {
                if (track.Contains("Track ID")) // The application only need the Track records.
                {
                    if (track.Contains("audio"))
                    {
                        Match match = Regex.Match(track, @"Track ID (\d+): audio.+language:([a-z]+)"); // Match the audio tracks based on the languages that the user selected.
                        if (match.Success)
                            tracksinfo += "Audio Track: " + match.Groups[1].Value + " (" + match.Groups[2].Value + ")" + "\r\n"; 
                    }
                    else if (track.Contains("subtitles"))
                    {
                        Match match = Regex.Match(track, @"Track ID (\d+): subtitles.+language:([a-z]+)"); // Match the subs tracks based on the languages that the user selected.
                        if (match.Success)
                            tracksinfo += "Subtitles Track: " + match.Groups[1].Value + " (" + match.Groups[2].Value + ")" + "\r\n";
                    }
                }
            }
            return tracksinfo;
        }

        private void BrowseFolderBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string directory = FolderBrowserDialog.SelectedPath;
                SourceDirectoryTextBox.Text = directory;
                DestinationDirectoryTextBox.Text = directory + "MSOutput";
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm AboutWindow = new AboutForm();
            AboutWindow.StartPosition = FormStartPosition.CenterParent;
            AboutWindow.ShowDialog();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TrackNumbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AudioFilterTextBox.Text = "";
            SubtitlesFilterTextBox.Text = "";
        }

        private void OutBrowseFolderBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = FolderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                DestinationDirectoryTextBox.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private async void TracksInfoBtn_Click(object sender, EventArgs e)
        {
            string tracksinfo;

            Dictionary<string, string> filesinfo = new Dictionary<string, string>();

            if (!MKVMergeExists())
            {
                LoggingTextBox.Text = "mkvmerge.exe could not be found. Please place it at the same folder as this program, or the program won't function.";
                return;
            }

            if (SourceDirectoryTextBox.Text != "" && Directory.Exists(SourceDirectoryTextBox.Text))
            {
                LoggingTextBox.Text = "Processing ...\r\n\r\n";

                FileInfo[] files = new DirectoryInfo(SourceDirectoryTextBox.Text).GetFiles("*.mkv", SearchOption.AllDirectories);

                foreach (FileInfo file in files) // Process the files, then group the tracks data based on audio/subtitles languages available. This is useful to show the users the tracks data especially when some of the files are different.
                {
                    tracksinfo = await Task.Run(() => GetTracksData(file.FullName));
                    if (filesinfo.ContainsKey(tracksinfo))
                        filesinfo[tracksinfo] = filesinfo[tracksinfo] + file.FullName + "\r\n";
                    else
                        filesinfo.Add(tracksinfo, file.FullName + "\r\n");
                }

                foreach (KeyValuePair<string, string> fileinfo in filesinfo) // Display grouped tracks data.
                {
                    LoggingTextBox.Text += fileinfo.Value + fileinfo.Key + "\r\n";
                }

                LoggingTextBox.Text += "Finished.";
            }
            else
                LoggingTextBox.Text = "Please select an input folder first.";
        }

        private bool MKVMergeExists()
        {
            if (File.Exists(Application.StartupPath + "\\mkvmerge.exe"))
                return true;
            return false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!MKVMergeExists())
                LoggingTextBox.Text = "mkvmerge.exe could not be found. Please place it at the same folder as this program, or the program won't function.";
        }
    }
}
