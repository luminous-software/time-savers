# Luminous Time Savers

![Visual Studio Marketplace][version-badge-url]
![Installs][installs-badge-url]
![Rating][rating-badge-url]

Download this extension from the [Visual Studio Marketplace][marketplace-url]
or get the [CI build][ci-build-url].

![VSTS Badge][vsts-badge-url]
[![Build status][appveyor-status]][appveyor-url]

See the [change log][changelog-url] for changes and the roadmap for upcoming features.

---

- If you **like** this extension, please show your support by [***rating it***][rating-url]
(only takes a couple of seconds),
or [***reviewing it***][rating-url].

- If you **didn't like** it for some reason, just let me know via the [***Q&A section***][qna-url]
(please don't ask questions in the review section).

- If you have any **suggestions** for improving it,
just let me know via the [***Q&A section***][suggestions-url].

---
## Enhance Your Productivity

### Time Savers Toolbar
This extension adds a new toolbar.
Because it's usually far easier to click a toolbar button than to have to go hunting for
the command you want in a menu somewhere,
the most convenient commands have been added to the toolbar.

To make the toolbar visible, right-click in a blank spot on the toolbar area,
and select *Time Savers*.

Like all other Visual Studio toolbars, you can remove any commands that you feel you don't need,
or even add new commands to it.

### Time Savers Menu
For those people who prefer a menu to a toolbar this extension also adds a new menu to
Visual Studio's main menu bar. All commands are available via this menu.

### Context Menus
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

### Keyboard Shortcuts
Some of the features that tend to be used frequently have also been assigned a keyboard shortcut.
And of course you can add your own keyboard shortcut to any of the *Time Savers* commands.

---

## Features

A more in-depth description of the features listed below [can be found here][features-url],
including a comparison of the steps required both with and without the extension installed,
as well as images of the features in action.

<table style="width: 800px;" border="1">
<tbody>
    <tr>
        <td style="text-align: left;"><strong>Feature</strong></td>
        <td style="text-align: left;"><strong>Description</strong></td>
    </tr>
    <tr>
        <td>Activity Log</td>
        <td>Open the Visual Studio activity monitor log</td>
    </tr>
    <tr>
        <td>Cancel Build</td>
        <td>A convenient way to cancel a running build/rebuild</td>
    </tr>
    <tr>
        <td>Close Solution</td>
        <td>Adds the missing command to the solution node in Solution Explorer</td>
    </tr>
    <tr>
        <td>Diagnostic Log</td>
        <td>Opens the most recent MSBuild diagnostic log file</td>
    </tr>
    <tr>
        <td>Edit Project</td>
        <td>Opens a project's <i>csproj</i> file in an xml editor</td>
    </tr>
    <tr>
        <td>Edit Solution</td>
        <td>Open a solution's <i>.sln</i> file in an xml editor</td>
    </tr>
    <tr>
        <td>Extensions and Updates</td>
        <td>A convenient way to open the <i>Extensions and Updates</i> dialog</td>
    </tr>
    <tr>
        <td>Insert Guid(s)</td>
        <td>Inserts a single guid, or multiple guids directly into your code without the use of any external tool</td>
    </tr>
    <tr>
        <td>Keyboard Options</td>
        <td>Opens the <i>Tools</i> | <i>Options</i> dialog at the <i>Environment</i> | <i>Keyboard</i> node</td>
    </tr>
    <tr>
        <td>Path Variables</td>
        <td>Displays the current set of Windows paths variable values</td>
    </tr>
    <tr>
        <td>Rebuild Project</td>
        <td>A convenient way to rebuild the just the current project</td>
    </tr>
    <tr>
        <td>Rebuild Solution</td>
        <td>A convenient way to rebuild the whole solution</td>
    </tr>
    <tr>
        <td>Reopen Start Page</td>
        <td>Automatically reopen the <i>Start Page</i> when the solution is closed</td>
    <tr>
        <td>Restart Visual Studio</td>
        <td>Unlock Visual Studio's built-in ability to restart itself</td>
    </tr>
    <tr>
        <td>Restart Visual Studio <br /> as Administrator</td>
        <td>Restarts Visual Studio as administrator (aka an <i>elevated</i> session)</td>
    </tr>
    <tr>
        <td>Time Savers Options</td>
        <td>Opens the <i>Tools</i> | <i>Options</i> dialog at the <i>Time Savers</i> node</td>
    </tr>
</table>

## Contribute
Check out the [contribution guidelines][contributing-url]
if you'd like to contribute to this project.

For cloning and building this project yourself, make sure to install the
[Extensibility Tools 2015][extensibility-tools-url]
extension for Visual Studio which enables some features used by this project.

## License
[MIT][license-url]

<div style="text-align:center">
    <img src="https://i1.visualstudiogallery.msdn.s-msft.com/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd/image/file/262824/1/lss-vsip.png"/>
</div>

[version-badge-url]: http://vsmarketplacebadge.apphb.com/version-short/YannDuran.VisualStudioTimeSavers.svg?label=version&colorB=7E57C2
[installs-badge-url]: http://vsmarketplacebadge.apphb.com/installs-short/YannDuran.VisualStudioTimeSavers.svg?colorB=7E57C2
[rating-badge-url]: http://vsmarketplacebadge.apphb.com/rating-short/YannDuran.VisualStudioTimeSavers.svg?colorB=7E57C2

[vsts-badge-url]: https://lumiinus.visualstudio.com/_apis/public/build/definitions/c31b2195-e4da-4ad9-a64c-e1712d313703/15/badge
[appveyor-status]: https://ci.appveyor.com/api/projects/status/tsf4rxwtgtcub741?svg=true
[appveyor-url]: https://ci.appveyor.com/project/luminous-software/time-savers

[ci-build]: http://vsixgallery.com/extension/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd/
[ci-build-url]: http://vsixgallery.com/extension/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd/

[marketplace-url]: https://marketplace.visualstudio.com/vsgallery/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd
[gallery-url]: https://visualstudiogallery.msdn.microsoft.com/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd
[rating-url]: https://marketplace.visualstudio.com/vsgallery/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd#review-details
[qna-url]: https://marketplace.visualstudio.com/vsgallery/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd#qna
[suggestions-url]: https://marketplace.visualstudio.com/vsgallery/049c7ac5-ba44-4a72-b4ee-7be7fb1b0edd#qna

[changelog-url]: https://github.com/luminous-software/time-savers/blob/master/CHANGELOG.md
[features-url]: https://luminous-software.solutions/extensions-vs/#time-savers

[contributing-url]: https://github.com/luminous-software/time-savers/blob/master/.github/CONTRIBUTING.md
[extensibility-tools-url]: https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6

[license-url]: https://github.com/luminous-software/time-savers/blob/master/LICENSE

