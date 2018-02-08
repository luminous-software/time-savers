## General Features

### Enable Time Savers

The _Enable Time Savers_ setting, found in Tools | Options | Time Savers | General,
allows you to completely disable all _Time Savers_ features.

### Insert Guid

The _Insert Guid_ feature allows you to insert a single guid, or multiple guids,
directly into your code without the need for any **external** tool.
You can use the button provided on the toolbar, or the CTRL+ALT+I, CTRL+ALT+G shortcut keys. 

## Solution Features

### Close Solution

If you prefer to use a mouse over using the keyboard, the _Close Solution_ feature provides
a convenient way to close the current solution without having to use File | Close Solution.
There's no shortcut key for this command because it's not something that people tend to need to do.

### Edit Solution

Opens a solution's `.sln` file in an xml editor.

### Reopen Start Page

Automatically reopen the *Start Page* when the solution is closed.

## Project Features

### Edit Project

Opens a project's `.csproj` file in an xml editor.

## Build Features

### Rebuild Solution

A convenient one-click way to rebuild the whole solution.

### Rebuild Project

A convenient one-click way to rebuild the just the current project
(either a selected project, or the project to which the active code document belongs).

### Cancel Build

A convenient one-click way to cancel a running build/rebuild.

## Logs Features

### Activity Log

Opens the Visual Studio activity monitor log.
The activity log is particularly useful if an extension is misbehaving,
or if you get a message from Visual Studio to look at the file for more details.

!!!note "The file's path is *%APPDATA%\Microsoft\VisualStudio\version\ActivityLog.xml*"
    - *%APPDATA%* represents the value in the APPDATA environment variable
    - *version* represents the current Visual Studio version (ie 14.0 2015)

### Diagnostic Log

Open the most recent MSBuild diagnostic log file.
!!! note "The file is: *%LOCALAPPDATA%\Temp\MSBuild_guid.failure.txt*"
    - *%LOCALAPPDATA%* represents the value in the *LOCALAPPDATA* environment variable
    - *guid* represents a random guid value

### Path Variables

Display the current set of Windows paths variable values.s.

## Visual Studio Features

### Extensions and Updates

A convenient way to open the *Extensions and Updates* dialog.

## Restart Options

### Restart Visual Studio

Unlock Visual Studio's built-in ability to restart itself.

### Restart Visual Studio as Administrator

Restart Visual Studio as administrator (elevated session).

## Options Features

### Time Savers Options

Open the *Tools* | *Options* dialog at the *Time Savers* node.

### Keyboard Options

Open the *Tools* | *Options* dialog at the *Environment* | *Keyboard* node.