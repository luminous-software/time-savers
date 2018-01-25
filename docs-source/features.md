## General Features

### Enable Time Savers

### Insert Guid(s)

Insert a single guid, or multiple guids directly into your code without the use of any **external** tool.

## Solution Features

### Close Solution

Closes the current solution. This command is missing from the solution node in Visual Studio for some unknown reason.

### Edit Solution

Opens a solution's *.sln* file in an xml editor.

### Reopen Start Page

Automatically reopen the *Start Page* when the solution is closed.

## Project Features

### Edit Project

Opens a project's *csproj* file in an xml editor.

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
The activity log is a powerful tool for troubleshooting issues with *VS Packages*, *VS Extensions*,
*MEF Components**, and *pkgdef* files, and provides useful insights into what Visual Studio is doing.
When Visual Studio starts writing the log, it also writes a corresponding XSL file in the same folder
as the XML file that makes it easy to read in a browser.
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