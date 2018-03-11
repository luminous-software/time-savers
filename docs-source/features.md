## General Features

### Enable Time Savers

The `Enable Time Savers` setting, found in `Tools | Options | Time Savers | General`,
allows you to temporarily disable all _Time Savers_ features with one simple setting.

This may come in handy if you ever need to suspend _Time Savers_ for whatever reason.

### Insert Guid

The `Insert Guid` feature adds a toolbar button, to provide a **one-click** way to to insert a **single guid**,
or **multiple guids**, directly into your code without the need for any external tool. It also adds a keyboard
shortcut (`CTRL-ALT-I`, `CTRL-ALT-G`).

You can either use the toolbar button, or the keyboard shortcut, to insert your guid(s).

## Solution Features

### Close Solution

The `Close Solution` feature adds a context menu button, to provide an easy way to close the current solution
without having to use `File | Close Solution`.

This can be especially handy if you're already using the mouse in Solution Explorer.

!!!note
    If you're already using the keyboard, you can always use Visual Studio's built-in `ALT-F, L`
    to close it that way too.

### Edit Solution

The `Edit Solution` feature provides a context menu button, to provide a simple way to open the current solution's
`.sln` file, to view or modify its contents.

The file is opened in a Visual Studio xml editor tab.

### Re-open Start Page

When enabled, the `Re-open Start Page` feature automatically re-opens the start page whenever the current
solution is closed.
This comes in handy if you use the pin multiple projects to the start page as your preferred method of
opening projects.

## Project Features

### Edit Project

The `Edit Project` feature provides a context menu button, to provide a simple way to open a project's `.csproj`
file, to view or modify its contents.

The file is opened in a Visual Studio xml editor tab.

## Build Features

### Rebuild Solution

The `Rebuild Solution` feature adds a toolbar button, to provide a convenient **one-click** way to rebuild
the **whole solution**.

### Rebuild Project

The `Rebuild Project` feature adds a toolbar button, to provide a convenient **one-click** way to rebuild
just the **current project**.

!!! note
    The current project is a **selected project** in Solution Explorer, the project that contains a **selected
    file/folder** in Solution Explorer, or the project to which the **active code document** belongs.

### Cancel Build

The `Cancel Build` feature adds a toolbar button, to provide a convenient **one-click** way to cancel
a running **build/rebuild**.

## Developer Features

### Activity Log

The `Activity Log` feature adds a toolbar button, to provide a convenient way to open Visual Studio's
_activity log_.
This is particularly useful if an extension is misbehaving, or if you get a message from Visual Studio
to look at the file for more details.

!!!note
    The activity log file's path is `%APPDATA%\Microsoft\VisualStudio\version\ActivityLog.xml`, where:

      - `%APPDATA%` represents the value in the `APPDATA` environment variable
      - `version` represents the current Visual Studio version (ie 15.0 etc)

### Diagnostic Log

The `Diagnostic Log` feature adds a toolbar button, to provide an easy way to open the **most recent** MSBuild
_diagnostic log_ file.

!!! note

    The diagnostic log file's path is: `%LOCALAPPDATA%\Temp\MSBuild_guid.failure.txt`, where:

    - `%LOCALAPPDATA%` represents the value in the `LOCALAPPDATA` environment variable
    - `guid` represents a random guid value

### Path Variables

The `Path Variables` feature adds a toolbar button, to provide a convenient way to display the current set of
Windows paths variable values without the need to open a commpand prompt.

## Visual Studio Features

### Extensions and Updates

The `Extensions and Updates` feature adds a toolbar button, to provide a convenient way **one-click** way to
open the `Extensions and Updates` dialog.

## Restart Features

From time to time you may have seen a dialog box offering to restart Visual Studio. Yet there's never
been a way to trigger this yourself. The two features explained below, allow you to unlock Visual Studio's
built-in ability to restart itself anytime that **you** want, without manually closing and
re-opening the application.

!!! note
    Visual Studio will attempt to re-open the project that was open at the time of triggering the restart,
    whereas manually closing and re-opening it may not depending on your
    `Tools | Options | Environment | Startup` setting.

### Restart Visual Studio

The `Restart Visual Studio` feature adds a toolbar button, that provides a **one-click** way to restart
Visual Studio.

!!! note
    If Visual Studio was opened _as administrator_, using this 2 restart Visual Studio, it will **still**
    be opened _as administrator_.

    The only way to get a _normal_ session again is to close/re-open Visual Studio manually.

### Restart Visual Studio as Administrator

The `Restart Visual Studio as Administrator` feature adds a toolbar button, that provides a **two-click** way to
restart Visual Studio as administrator (aka an _elevated_ session).

## Options Features

### Time Savers Options

The `Time Savers Options` feature adds a toolbar button, that provides a simple **one-click** way to
open the `Tools | Options` dialog with the `Time Savers` node expanded, and the `General` option selected.

### Keyboard Options

The `Keyboard Options` feature adds a toolbar button, that provides a **two-click** way to
open the `Tools | Options` dialog with the `Environment` node expanded, and the `Keyboard` option selected.

This can save a lot of time when you add/test a number of keyboard shortcuts, or need to look up a keyboard.
shortcut
