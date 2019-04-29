using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.Options
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class KeyboardOptionsCommand : OptionsCommand
    {
        private KeyboardOptionsCommand(AsyncPackageBase package) : base(package, PackageIds.KeyboardOptionsCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new KeyboardOptionsCommand(package));

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