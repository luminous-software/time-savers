using Microsoft.VisualStudio.Shell;

//FEATURE: 392 Path Variables Window

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    using UI.PathVariables;

    internal sealed class PathVariablesCommand : DeveloperCommand
    {
        private PathVariablesCommand(PackageBase package)
            : base(package, PackageIds.PathVariablesCommand)
        { }

        public static void Instantiate(PackageBase package)
            => Instantiate(new PathVariablesCommand(package));

        protected override bool CanExecute
            => base.CanExecute && DeveloperOptions.PathVariablesCommandEnabled;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private CommandResult ExecuteCommand()
        {
            return Package.ShowToolWindow<PathVariablesToolWindowPane>();
        }
    }
}