using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.Shell;

using static System.IO.Path;

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.Exceptions.ExceptionExtensions;
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    using static Luminous.Code.VisualStudio.Commands.CommandKeys;

    internal sealed class DiagnosticLogCommand : DynamicCommand
    {
        //***

        private static int CommandId
            => PackageIds.DiagnosticLogCommand;

        //!!!

        private DiagnosticLogCommand(PackageBase package) : base(package, CommandId)
        { }

        //!!!

        public static void Instantiate(PackageBase package)
            => Instantiate(new DiagnosticLogCommand(package));

        //---

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        //---

        //UserLocalDataPath = C:/Users/Yann/AppData/Local/Microsoft/VisualStudio/14.0Exp/

        private CommandResult ExecuteCommand()
        {
            try
            {
                var path = $"{GetTempPath()}";
                var di = new DirectoryInfo(path);
                var files = di?.EnumerateFiles("*.failure.txt");

                var fi = (
                    from file in files
                    orderby
                        file.CreationTime descending
                    select file
                    ).FirstOrDefault();

                if (fi == null)
                {
                    return new InformationResult("No diagnostic log found");
                }

                var filename = fi.FullName;

                return Package?.ExecuteCommand(ViewWebBrowser, filename, problem: "Unable to view '{filename}'");
            }
            catch (Exception ex)
            {
                return new ProblemResult(ex.ExtendedMessage());
            }
        }

        //***
    }
}