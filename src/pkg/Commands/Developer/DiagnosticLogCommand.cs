using Microsoft.VisualStudio.Shell;
using System;
using System.IO;
using System.Linq;
using static System.IO.Path;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.Extensions.ExceptionExtensions;
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class DiagnosticLogCommand : DeveloperCommand
    {
        private static int CommandId
            => PackageIds.DiagnosticLogCommand;

        private DiagnosticLogCommand(AsyncPackageBase package) : base(package, CommandId)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new DiagnosticLogCommand(package));

        protected override void OnExecute(OleMenuCommand command)
            => ExecuteCommand()
                .ShowProblem()
                .ShowInformation();

        protected override bool CanExecute
            => base.CanExecute && DeveloperOptions.DiagnosticLogCommandEnabled;

        private static CommandResult ExecuteCommand()
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

                return fi != null
                    ? Package?.OpenTextFile(fi.FullName, problem: "Unable to view '{filename}'")
                    : new InformationResult("No diagnostic log found");
            }
            catch (Exception ex)
            {
                return new ProblemResult(ex.ExtendedMessage());
            }
        }
    }
}