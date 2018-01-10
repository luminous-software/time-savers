
## Time Savers Toolbar
This extension adds a new toolbar.
Because it's usually far easier to click a toolbar button than to have to go hunting for
the command you want in a menu somewhere,
the most convenient commands have been added to the toolbar.
To make the toolbar visible, right-click in a blank spot on the toolbar area,
and select *Time Savers*.
Like all other Visual Studio toolbars, you can remove any commands that you feel you don't need,
or even add new commands to it.

## Time Savers Menu
For those people who prefer a menu to a toolbar this extension also adds a new menu to
Visual Studio's main menu bar. All commands are available via this menu.

## Context Menus
Most features are also available via another menu that's been added to the
right-click context menu of any code window, and to some nodes in *Solution Explorer*.
This allows you to access nearly all of the *Time Savers* features
without moving your mouse from the code you're working on.

The commands have been grouped into their own *Time Savers* menu because most context menus
are already pretty clogged up. And they're growing all the time,
as Microsoft or 3rd-party extensions add more and more commands to them.
It means that there is one more click than I'd ideally prefer,
but I've found it much easier to find the commands in a dedicated menu
than having to search through one gigantic menu of different commands.

## Keyboard Shortcuts

Some of the features that tend to be used frequently have also been assigned a keyboard shortcut.
And of course you can add your own keyboard shortcut to invoke any of the *Time Savers* commands.

---

## Features

A more in-depth description of the features listed below [can be found here][features-url],
including a comparison of the steps required both with and without the extension installed,
as well as images of the features in action.

- Activity Log
- Cancel Build
- Close Solution
- Diagnostic Log
- Edit Project
- Edit Solution
- Extensions and Updates
- Insert Guid(s)
- Keyboard Options
- Path Variables
- Rebuild Project
- Rebuild Solution
- Reopen Start Page
- Restart Visual Studio
- Restart Visual Studio as Administrator

---

### Activity Log
Open the Visual Studio activity monitor log.
The activity log is a powerful tool for troubleshooting issues with *VS Packages*, *VS Extensions*,
*MEF Components**, and *pkgdef* files, and provides useful insights into what Visual Studio is doing.
When Visual Studio starts writing the log, it also writes a corresponding XSL file in the same folder
as the XML file that makes it easy to read in a browser.
>The file's path is *%APPDATA%\Microsoft\VisualStudio\version\ActivityLog.xml*
>
>- *%APPDATA%* represents the value in the APPDATA environment variable
>- *version* represents the current Visual Studio version (ie 14.0 2015)

### Cancel Build
A convenient way to cancel a running build/rebuild.

### Close Solution
Close the solution.
This command is missing from the solution node in Visual Studio for some unknown reason.

### Diagnostic Log
Open the most recent MSBuild diagnostic log file.
>The file is: *%LOCALAPPDATA%\Temp\MSBuild_guid.failure.txt*
>
>- *%LOCALAPPDATA%* represents the value in the *LOCALAPPDATA* environment variable
>- *guid* represents a random guid value

### Edit Project
Open a project's *csproj* file in an xml editor.

### Edit Solution
Open a solution's *.sln* file in an xml editor.

### Extensions and Updates
A convenient way to open the *Extensions and Updates* dialog.

### Insert Guid(s)
Insert a single guid, or multiple guids directly into your code without the use of any **external** tool.

### Keyboard Options
Open the *Tools* | *Options* dialog at the *Environment* | *Keyboard* node.

### Path Variables
Display the current set of Windows paths variable values.

### Rebuild Project
A convenient way to rebuild the just the current project
(either a selected project, or the project to which the active code document belongs).

### Rebuild Solution
A convenient way to rebuild the whole solution.

### Reopen Start Page
Automatically reopen the *Start Page* when the solution is closed.

### Restart Visual Studio
Unlock Visual Studio's built-in ability to restart itself.

### Restart Visual Studio as Administrator
Restart Visual Studio as administrator (elevated session).

### Time Savers Options
Open the *Tools* | *Options* dialog at the *Time Savers* node.

### Keyboard Options
Open the *Tools* | *Options* dialog at the *Environment* | *Keyboard* node.