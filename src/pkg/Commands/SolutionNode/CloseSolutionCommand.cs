using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.SolutionNode
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class CloseSolutionCommand : TimeSaversCommand
    {
        private CloseSolutionCommand(AsyncPackageBase package) : base(package, PackageIds.CloseSolutionCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new CloseSolutionCommand(package));

        //protected override bool IsActive
        //    => base.IsActive && ;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private CommandResult ExecuteCommand()
            => Package?.CloseSolution(problem: $"Unable to close solution");
    }
}