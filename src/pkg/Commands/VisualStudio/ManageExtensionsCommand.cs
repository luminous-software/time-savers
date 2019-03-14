using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.VisualStudio
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class ManageExtensionsCommand : TimeSaversCommand
    {
        //***
        //!!!

        private ManageExtensionsCommand(PackageBase package) : base(package, PackageIds.ManageExtensionsCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new ManageExtensionsCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.OpenExtensionsAndUpdates();

        //***
    }
}