# MKVStrip
![MKVStrip](https://i.imgur.com/Y900nKV.png)

## Introduction
MKVStrip allows you to get rid of audio/subtitles tracks that you do not need within a video file. 

## Features
1. Easy to use.
2. Batch processing support.
3. Supports single/multiple languages.
4. Supports track numbers/IDs instead of languages.
5. Supports different track IDS/languages for both audio and subtitles.
6. Supports iterating over subfolders.

## Installation
1. Start by downloading the program from [here](https://github.com/samehb/MKVStrip/releases/download/1.0/MKVStrip.zip) and extract it to any folder of choice.
2. Download mkvtoolnix portable v19 from [here](https://www.videohelp.com/software/MKVToolNix/old-versions). Get mkvtoolnix-64-bit-19.0.0.7z if you have an x64 system, or mkvtoolnix-32-bit-19.0.0.7z if you have an x86 system. The latest version of mkvtoolnix is not currently supported.
3. Extract the mkvtoolnix file and copy mkvmerge.exe into the folder from Step 1.

## Usage
1. Start the program by double clicking the MKVStrip.exe file.
2. Select the input folder that contains the mkv videos.
3. Select an output folder if you want a custom location, other than the one selected by the program.
4. Click the "Tracks Info" button to find the available languages/Track ID associated with the videos. Note that the program groups videos with similar audio/subtitles data together to simplify the process for you.
5. Input the language(s) you want to keep for both audio and subtitles in "Audio Filter" and "Subtitles Filter", respectively. The default setup is English for both audio and subtitles. If you want other languages, change "eng" to the language(s) available from Step 4. If you are adding more than one language, separate them by commas. For example, if you want English audio and French subtitles, put eng in Audio Filter and fre in Subtitles Filter. Though, if you want English/French audio tracks and French/Spanish subtitles, put eng,fre in Audio Filter, and fre,spa in Subtitles Filter.
6. There are some cases where you need to specify the tracks you want by IDs. For example, the video file might contain multiple English tracks, but you want just the first one. If that is the case, check the "Use Track Numbers Instead" option. This allows you to select the tracks you want by IDs (that you can get from Step 4). Put the numbers that you want to keep in Audio/Subtitles Filters, separated by commas, if you have multiple tracks you want to keep for audio and/or subtitles tracks.
7. Once you are done, click "Process' and wait for the program to nofity you that it finished. That is it.

## Copyright
License: CC BY-NC-SA 4.0 (Attribution-NonCommercial-ShareAlike 4.0 International)

Read file [LICENSE](LICENSE)

## Links

[Blog](http://sres.tumblr.com)

[Discussion](http://sres.tumblr.com/post/170525332028/mkvstrip-keep-the-audiosubtitles-tracks-you)
