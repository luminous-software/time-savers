using Microsoft.VisualStudio.Shell;
using System;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.Insert
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class InsertGuidCommand : InsertCommand
    {
        private InsertGuidCommand(AsyncPackageBase package) : base(package, PackageIds.InsertGuidCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new InsertGuidCommand(package));

        protected override bool CanExecute
            => base.CanExecute; //&& ContextIsActive(CodeWindow); //&& InsertOptions.InsertCommandEnabled;

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        private CommandResult ExecuteCommand()
            => Package?.ReplaceSelectedText(() => Guid.NewGuid().ToString(), problem: "Unable to insert guid");
    }
}