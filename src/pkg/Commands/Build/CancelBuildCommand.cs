using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class CancelBuildCommand : BuildCommand
    {
        private CancelBuildCommand(AsyncPackageBase package) : base(package, PackageIds.CancelBuildCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new CancelBuildCommand(package));

        protected override bool CanExecute
        => base.CanExecute && BuildOptions.CancelBuildCommandEnabled;

        protected override bool IsActive
            => base.IsActive && BuildingOrDebugging;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private static CommandResult ExecuteCommand()
            => Package?.CancelBuild();
    }
}