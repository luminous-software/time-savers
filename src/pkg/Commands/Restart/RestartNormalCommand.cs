using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.Restart
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class RestartNormalCommand : TimeSaversCommand
    {
        private RestartNormalCommand(AsyncPackageBase package) : base(package, PackageIds.RestartNormalCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new RestartNormalCommand(package));

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private CommandResult ExecuteCommand()
            => Package?.RestartVisualStudio();
    }
}