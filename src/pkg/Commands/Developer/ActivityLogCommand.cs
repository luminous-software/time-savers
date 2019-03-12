using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    using static Luminous.Code.VisualStudio.Commands.CommandKeys;

    internal sealed class ActivityLogCommand : DeveloperCommand
    {
        private static string Path
            => $"{Package.UserDataPath}\\ActivityLog.xml";

        private ActivityLogCommand(PackageBase package)
            : base(package, PackageIds.ActivityLogCommand)
        { }

        public static void Instantiate(PackageBase package)
            => Instantiate(new ActivityLogCommand(package));

        protected override bool CanExecute
            => base.CanExecute && DeveloperOptions.ActivityLogCommandEnabled;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private static CommandResult ExecuteCommand()
            => Package?.ExecuteCommand(ViewWebBrowser, Path, problem: "Unable to view activity log");
    }
}