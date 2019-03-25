using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.Options
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class KeyboardOptionsCommand : OptionsCommand
    {
        private KeyboardOptionsCommand(PackageBase package) : base(package, PackageIds.KeyboardOptionsCommand)
        { }

        public static void Instantiate(PackageBase package)
            => Instantiate(new KeyboardOptionsCommand(package));

        protected override bool CanExecute
            => base.CanExecute && Options.KeyboardOptionsCommandEnabled;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private static CommandResult ExecuteCommand()
            => Package?.ShowOptions(CommandKeys.KeyboardOptions);
    }
}