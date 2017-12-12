using System;
using Microsoft.VisualStudio.Shell;

using static System.Environment;

//FEATURE: 392 Path Variables Window

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.Exceptions.ExceptionExtensions;
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;
    using Luminous.TimeSavers.UI.PathVariables;

    internal sealed class PathVariablesCommand : TimeSaversCommand
    {
        //***
        //!!!

        private PathVariablesCommand(PackageBase package)
            : base(package, PackageIds.PathVariablesCommand)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new PathVariablesCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        private CommandResult ExecuteCommand()
        {
            return Package.ShowToolWindow<ToolWindowPane>();
        }

        //***
    }
}