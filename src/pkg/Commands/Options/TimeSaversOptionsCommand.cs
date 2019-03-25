using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.Options
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;
    using TimeSavers.Options.Pages;

    internal sealed class TimeSaversOptionsCommand : OptionsCommand
    {
        private TimeSaversOptionsCommand(PackageBase package) : base(package, PackageIds.TimeSaversOptionsCommand)
        { }

        public static void Instantiate(PackageBase package)
            => Instantiate(new TimeSaversOptionsCommand(package));

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