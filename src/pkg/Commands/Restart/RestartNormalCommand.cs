using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.Restart
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class RestartNormalCommand : TimeSaversCommand
    {
        //***
        //!!!

        private RestartNormalCommand(PackageBase package) : base(package, PackageIds.RestartNormalCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new RestartNormalCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.RestartVisualStudio();

        //***
    }
}