using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Commands.ProjectNode
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class EditProjectCommand : TimeSaversCommand
    {
        //***

        private static int CommandId
            => PackageIds.EditProjectCommand;

        //---M

        private EditProjectCommand(PackageBase package) : base(package, CommandId)
        { }

        //---M

        public static void Instantiate(PackageBase package)
            => Instantiate(new EditProjectCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        protected override bool IsActive
        {
            get
            {
                return (base.IsActive && SolutionIsNotBuilding);
            }
        }

        //---

        private CommandResult ExecuteCommand()
            => Package?.EditSelectedProject();

        //***
    }
}