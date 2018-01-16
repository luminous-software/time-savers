# Luminous Time Savers

![Visual Studio Marketplace][version-badge-url]
![Installs][installs-badge-url]
![Rating][rating-badge-url]

You can download this extension from the [Visual Studio Marketplace][marketplace-url],
or get the soure code from [GitHub][github-url].

See the [change log][changelog-url] for changes and the [roadmap][roadmap-url] for upcoming features.

!!! Note "Share Your Time Savers Experience"

    If you find this extension useful, please show your support:

    - by [***rating it***][rating-url] (only takes a couple of seconds)
    - or [***reviewing it***][rating-url] (help others by )

## Enhance Your Productivity
Every feature of *Time Savers* was created specifically to enhance development productivity by
**saving you time**.

### Time Savers Toolbar
This extension adds a new toolbar that adds command buttons for most *Time Savers* features giving you a
**one-click experience**, saving you from having to go hunting for the command you want in a menu somewhere.

To enable the toolbar, right-click in a blank spot on the toolbar area, and select *Time Savers*.
Like all other Visual Studio toolbars, you can remove any commands that you feel you don't need,
or even add exisitng Visual Studio commands to it.

### Time Savers Menu

For people who prefer a menu to a toolbar this extension also adds a new menu to Visual Studio's main menu bar.
All *Time Savers* features are available via this menu giving you a simple
**two-click experience**.

### Context Menus (right-click)
For people who hate having to move their mouse from the code they're working on,
another menu has been added to the context menu of any code window, as well as to some nodes in *Solution Explorer*.
Most *Time Savers* features are available via this context menu for a simple
**right-click experience**, without having to your mouse from the code you're working on.

The commands have been grouped into their own *Time Savers* menu because most context menus
are already pretty clogged up. And they're growing all the time,
as Microsoft or 3rd-party extensions add more and more commands to them.

Unfortunately it means that there's one more click than I'd ideally prefer,
but I've found it much easier to find commands in a dedicated menu
than having to search through one gigantic menu of different commands.

### Keyboard Shortcuts

Some of the *Time Savers* features that tend to be used frequently have also been assigned a keyboard shortcut for a 
**one or two-click experience**.
And of course you can add your own keyboard shortcut to any of the *Time Savers* features.

## Features

### Activity Log

Opens the Visual Studio activity monitor log.
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

[version-badge-url]: http://vsmarketplacebadge.apphb.com/version-short/YannDuran.VisualStudioTimeSavers.svg?label=version&colorB=7E57C2
[installs-badge-url]: http://vsmarketplacebadge.apphb.com/installs-short/YannDuran.VisualStudioTimeSavers.svg?colorB=7E57C2
[rating-badge-url]: http://vsmarketplacebadge.apphb.com/rating-short/YannDuran.VisualStudioTimeSavers.svg?colorB=7E57C2

[github-url]: http://www.github.com/luminous-software/time-savers

[marketplace-url]: https://marketplace.visualstudio.com/vsgallery/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd
[gallery-url]: https://visualstudiogallery.msdn.microsoft.com/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd
[rating-url]: https://marketplace.visualstudio.com/vsgallery/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd#review-details
[qna-url]: https://marketplace.visualstudio.com/vsgallery/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd#qna
[suggestions-url]: https://marketplace.visualstudio.com/vsgallery/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd#qna

[changelog-url]: https://github.com/luminous-software/time-savers/blob/master/CHANGELOG.md
[roadmap-url]: https://github.com/luminous-software/time-savers/blob/master/roadmap.md
[features-url]: https://luminous-software.solutions/extensions-vs/#time-savers
[icon-url]: /assets/images/favicon.ico

[contributing-url]: https://github.com/luminous-software/time-savers/blob/master/.github/CONTRIBUTING.md
[extensibility-tools-url]: https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6

[license-url]: https://github.com/luminous-software/time-savers/blob/master/LICENSE

