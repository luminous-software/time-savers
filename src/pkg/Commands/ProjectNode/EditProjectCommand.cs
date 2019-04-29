using Microsoft.VisualStudio.Shell;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.ProjectNode
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class EditProjectCommand : TimeSaversCommand
    {
        private static int CommandId
            => PackageIds.EditProjectCommand;

        private EditProjectCommand(AsyncPackageBase package) : base(package, CommandId)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new EditProjectCommand(package));

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

        private CommandResult ExecuteCommand()
            => Package?.EditSelectedProject();
    }
}