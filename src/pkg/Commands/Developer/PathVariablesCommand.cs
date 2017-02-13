using System;
using Microsoft.VisualStudio.Shell;

using static System.Environment;

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.Exceptions.ExceptionExtensions;
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class PathVariablesCommand : DynamicCommand
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
            try
            {
                const string semi_colon = ";";
                var pane = Package?.PackageOutputPane;
                var colonNewline = semi_colon + NewLine;
                var expanded = ExpandEnvironmentVariables("%path%");
                var text = expanded.Replace(semi_colon, colonNewline);

                text += colonNewline;

                var result = Package?.ActivateOutputWindow();
                if (!result.Succeeded)
                    return result;

                pane.Activate();
                pane.Clear();
                pane.OutputString("Path Variables" + NewLine);
                pane.OutputString("==============" + NewLine + NewLine);
                pane.OutputString(text);

                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ProblemResult(ex.ExtendedMessage());
            }
        }

        //***
    }
}