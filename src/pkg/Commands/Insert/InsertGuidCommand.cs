using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace Luminous.TimeSavers.Commands.Insert
{
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;
    using InsertGuid.ToolWindows;
    using System;

    internal sealed class InsertGuidCommand : DynamicCommand
    {
        //***

        //!!!

        private InsertGuidCommand(PackageBase package) : base(package, PackageIds.InsertGuidCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new InsertGuidCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
        {
            return Package?.ReplaceSelectedText(() => Guid.NewGuid().ToString(),
                problem: "Unable to insert guid");
        }

        //***
    }
}