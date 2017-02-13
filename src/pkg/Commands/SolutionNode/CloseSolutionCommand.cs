using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.SolutionNode
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class CloseSolutionCommand : DynamicCommand
    {
        //***
        //!!!

        private CloseSolutionCommand(PackageBase package) : base(package, PackageIds.CloseSolutionCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new CloseSolutionCommand(package));

        //---

        //protected override bool IsActive
        //    => base.IsActive && ;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
            => Package?.CloseSolution(problem: $"Unable to close solution");

        //***
    }
}