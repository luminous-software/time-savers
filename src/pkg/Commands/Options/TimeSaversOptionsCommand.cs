using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.Options
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;
    using TimeSavers.Options.Pages;

    internal sealed class TimeSaversOptionsCommand : OptionsCommand
    {
        private TimeSaversOptionsCommand(AsyncPackageBase package) : base(package, PackageIds.TimeSaversOptionsCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new TimeSaversOptionsCommand(package));

        protected override bool CanExecute
            => base.CanExecute && Options.TimeSaversOptionsCommandEnabled;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private static CommandResult ExecuteCommand()
            => Package?.ShowOptionsPage<GeneralDialogPage>();
    }
}