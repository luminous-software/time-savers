using Microsoft.VisualStudio.Shell;

//FEATURE:   445 Browser Window
//WORK_ITEM: 446 Create Browser Window ToolWindow

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.Options.Pages;

    //using Luminous.TimeSavers.UI.BrowserWindow;

    internal sealed class BrowserWindowCommand : TimeSaversCommand
    {
        private BrowserWindowCommand(PackageBase package)
            : base(package, PackageIds.BrowserWindowCommand)
        { }

        public static void Instantiate(PackageBase package)
            => Instantiate(new BrowserWindowCommand(package));

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem();

        private CommandResult ExecuteCommand()
        {
            return null;
            //return Package.ShowNewToolWindow<BrowserWindowToolWindowPane>(maxWindows: TimeSaversOptions.MaxBrowserWindows);
        }
    }
}