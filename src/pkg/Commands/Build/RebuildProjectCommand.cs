using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class RebuildProjectCommand : BuildCommand
    {
        //***
        //!!!

        private RebuildProjectCommand(PackageBase package)
            : base(package, PackageIds.RebuildProjectCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new RebuildProjectCommand(package));

        //---

        protected override bool CanExecute
        => (base.CanExecute && BuildOptions.RebuildProjectCommandEnabled);

        protected override bool IsActive
            => base.IsActive && SolutionHasProjects && SolutionIsNotBuilding;// && ProjectSelected();

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.BuildProject(rebuild: true);

        //***
    }
}