using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class RebuildProjectCommand : BuildCommand
    {
        private RebuildProjectCommand(AsyncPackageBase package)
            : base(package, PackageIds.RebuildProjectCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new RebuildProjectCommand(package));

        protected override bool CanExecute
        => base.CanExecute && BuildOptions.RebuildProjectCommandEnabled;

        protected override bool IsActive
            => base.IsActive && SolutionIsNotBuilding;// && ProjectSelected();

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private static CommandResult ExecuteCommand()
            => Package?.BuildProject(rebuild: true);
    }
}