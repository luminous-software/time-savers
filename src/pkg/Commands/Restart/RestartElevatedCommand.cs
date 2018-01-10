using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.Restart
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class RestartElevatedCommand : TimeSaversCommand
    {
        //***
        //!!!

        private RestartElevatedCommand(PackageBase package) : base(package, PackageIds.RestartElevatedCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new RestartElevatedCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.RestartVisualStudio(elevated: true);

        //***
    }
}