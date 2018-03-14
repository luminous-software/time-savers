using Microsoft.VisualStudio.Shell;
using Luminous.Code.VisualStudio.Commands;
using Luminous.Code.VisualStudio.Packages;

namespace Luminous.TimeSavers.Commands.SolutionNode
{
    internal sealed class EditSolutionCommand : TimeSaversCommand
    {
        //***
        //!!!

        private EditSolutionCommand(PackageBase package) : base(package, PackageIds.EditSolutionCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new EditSolutionCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        protected override bool IsActive
            => base.IsActive
                && SolutionIsNotBuilding;

        //---

        private CommandResult ExecuteCommand()
            => Package?.EditSolution();

        //***
    }
}