using Luminous.Code.VisualStudio.Commands;
using Luminous.Code.VisualStudio.Packages;
using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.SolutionNode
{
    internal sealed class EditSolutionCommand : TimeSaversCommand
    {
        private EditSolutionCommand(AsyncPackageBase package) : base(package, PackageIds.EditSolutionCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new EditSolutionCommand(package));

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        protected override bool IsActive
            => base.IsActive
                && SolutionIsNotBuilding;

        private CommandResult ExecuteCommand()
            => Package?.EditSolution();
    }
}