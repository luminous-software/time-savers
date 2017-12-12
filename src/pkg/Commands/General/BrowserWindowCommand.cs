using Microsoft.VisualStudio.Shell;

//FEATURE: 445 Browser Window

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.UI.BrowserWindow;

    internal sealed class BrowserWindowCommand : DynamicCommand
    {
        //***
        //!!!

        private BrowserWindowCommand(PackageBase package)
            : base(package, 666666)//PackageIds.BrowserWindowCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new BrowserWindowCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
        {
            return Package.ShowToolWindow<ToolWindowPane>();
        }

        //***
    }
}