using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.VisualStudio
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class ExtensionsAndUpdatesCommand : TimeSaversCommand
    {
        //***
        //!!!

        private ExtensionsAndUpdatesCommand(PackageBase package) : base(package, PackageIds.ExtensionsAndUpdatesCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new ExtensionsAndUpdatesCommand(package));

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