using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class RebuildSolutionCommand : BuildCommand
    {
        //***
        //!!!

        private RebuildSolutionCommand(PackageBase package) : base(package, PackageIds.RebuildSolutionCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new RebuildSolutionCommand(package));

        //---

        protected override bool CanExecute
        => base.CanExecute && BuildOptions.RebuildSolutionCommandEnabled;

        protected override bool IsActive
            => base.IsActive && SolutionHasProjects && SolutionIsNotBuilding;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.BuildSolution(rebuild: true);

        //***
    }
}