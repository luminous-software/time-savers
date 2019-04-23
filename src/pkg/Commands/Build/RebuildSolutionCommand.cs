using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class RebuildSolutionCommand : BuildCommand
    {
        private RebuildSolutionCommand(AsyncPackageBase package)
            : base(package, PackageIds.RebuildSolutionCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new RebuildSolutionCommand(package));

        protected override bool CanExecute
        => base.CanExecute && BuildOptions.RebuildSolutionCommandEnabled;

        protected override bool IsActive
            => base.IsActive && SolutionIsNotBuilding;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private static CommandResult ExecuteCommand()
            => Package?.BuildSolution(rebuild: true);
    }
}