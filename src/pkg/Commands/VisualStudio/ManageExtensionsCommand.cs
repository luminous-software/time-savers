using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.VisualStudio
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;
    using static Luminous.Code.VisualStudio.Constants.VsVersions;

    internal sealed class ManageExtensionsCommand : VisualStudioCommand
    {
        private ManageExtensionsCommand(AsyncPackageBase package) : base(package, PackageIds.ManageExtensionsCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new ManageExtensionsCommand(package));

        protected override bool CanExecute
            => base.CanExecute && VisualStudioOptions.ManageExtensionsEnabled;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private CommandResult ExecuteCommand()
        {
            var currentVersion = Package?.VisualStudioVersion;

            switch (currentVersion)
            {
                case null:
                    return new ProblemResult("Unable to obtain Visual Studio version");

                case Vs2017:
                    return Package?.OpenExtensionsAndUpdates();

                case Vs2019:
                default:
                    return Package?.OpenManageExtensions();
            }
        }
    }
}