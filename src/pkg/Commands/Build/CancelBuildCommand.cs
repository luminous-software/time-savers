using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.Build
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class CancelBuildCommand : BuildCommand
    {
        private CancelBuildCommand(PackageBase package) : base(package, PackageIds.CancelBuildCommand)
        { }

        public static void Instantiate(PackageBase package)
            => Instantiate(new CancelBuildCommand(package));

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