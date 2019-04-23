using Microsoft.VisualStudio.Shell;
using System;
using static System.Environment;
using Tasks = System.Threading.Tasks;

//FEATURE: 392 Path Variables Window

namespace Luminous.TimeSavers.Commands.Developer
{
    using Luminous.Code.Exceptions.ExceptionExtensions;
    using Luminous.Code.VisualStudio.Commands;
    using Luminous.Code.VisualStudio.Packages;

    internal sealed class PathVariablesCommand : DeveloperCommand
    {
        private PathVariablesCommand(AsyncPackageBase package)
            : base(package, PackageIds.PathVariablesCommand)
        { }

        public async static Tasks.Task InstantiateAsync(AsyncPackageBase package)
            => await InstantiateAsync(new PathVariablesCommand(package));

        protected override bool CanExecute
            => base.CanExecute && DeveloperOptions.PathVariablesCommandEnabled;

        protected override void OnExecute(OleMenuCommand command)
#pragma warning disable VSTHRD010 // Invoke single-threaded types on Main thread
            => ExecuteCommand()
#pragma warning restore VSTHRD010 // Invoke single-threaded types on Main thread
                .ShowProblem()
                .ShowInformation();

        private static CommandResult ExecuteCommand()
        {
            try
            {
                ThreadHelper.ThrowIfNotOnUIThread();

                //var threadingService = Package?.GetService<IProjectThreadingService>();

                const string semi_colon = ";";
                var colonNewline = semi_colon + NewLine;
                var expanded = ExpandEnvironmentVariables("%path%");
                var text = expanded.Replace(semi_colon, colonNewline);

                text += colonNewline;

                var result = Package?.ActivateOutputWindow();
                if (!result.Succeeded) return result;

                //if (!threadingService.IsOnMainThread)
                //    return new ProblemResult("Cannot execute command (not on main thread)");

                var pane = Package?.PackageOutputPane;

                pane?.Activate();
                pane?.Clear();
                pane?.OutputString("Path Variables" + NewLine);
                pane?.OutputString("==============" + NewLine + NewLine);
                pane?.OutputString(text);

                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ProblemResult(ex.ExtendedMessage());
            }
        }
    }
}