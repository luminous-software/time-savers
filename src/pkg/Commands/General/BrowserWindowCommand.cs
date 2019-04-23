using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

//FEATURE:   445 Browser Window
//WORK_ITEM: 446 Create Browser Window ToolWindow

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    //using Luminous.TimeSavers.UI.BrowserWindow;

    internal sealed class BrowserWindowCommand : TimeSaversCommand
    {
        private BrowserWindowCommand(AsyncPackageBase package)
            : base(package, PackageIds.BrowserWindowCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new BrowserWindowCommand(package));

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