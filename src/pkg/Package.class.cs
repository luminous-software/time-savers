using Luminous.Code.VisualStudio.Packages;
using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using static Microsoft.VisualStudio.VSConstants.UICONTEXT;
using Tasks = System.Threading.Tasks;

namespace Luminous.TimeSavers
{
    using Commands.Build;
    using Commands.Developer;
    using Commands.Insert;
    using Commands.Options;
    using Commands.ProjectNode;
    using Commands.Restart;
    using Commands.SolutionNode;
    using Commands.VisualStudio;
    using Options.Pages;

    using static Core.Constants;
    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration(Name, Description, Version, IconResourceID = 400)]
    [Guid(PackageString)]

    [ProvideOptionPage(typeof(GeneralDialogPage), Name, General, 0, 0, supportsAutomation: true)]
    [ProvideOptionPage(typeof(BuildDialogPage), Name, Build, 0, 0, supportsAutomation: true)]
    [ProvideOptionPage(typeof(DeveloperDialogPage), Name, Developer, 0, 0, supportsAutomation: true)]
    [ProvideOptionPage(typeof(VisualStudioDialogPage), Name, VisualStudio, 0, 0, supportsAutomation: true)]

    [ProvideAutoLoad(SingleProjectOrMultipleProjectsString, PackageAutoLoadFlags.BackgroundLoad)]
    [ProvideUIContextRule(SingleProjectOrMultipleProjectsString,
        name: "Solution Has One or More Projects",
        expression: "SingleProject | MultipleProjects",
        termNames: new[] { "SingleProject", "MultipleProjects" },
        termValues: new[] { SolutionHasSingleProject_string, SolutionHasMultipleProjects_string })]

    [ProvideAutoLoad(SingleProjectOrMultipleProjectsString, PackageAutoLoadFlags.BackgroundLoad)]

    public sealed class PackageClass : AsyncPackageBase
    {
        private BuildDialogPage _buildOptions;
        private VisualStudioDialogPage _visualStudioOptions;

        public BuildDialogPage BuildOptions
            => _buildOptions ?? (_buildOptions = GetDialogPage<BuildDialogPage>());

        public VisualStudioDialogPage VisualStudioOptions
            => _visualStudioOptions ?? (_visualStudioOptions = GetDialogPage<VisualStudioDialogPage>());

        public PackageClass() : base(PackageCommandSet, Name, Description)
        { }

        protected override async Tasks.Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
        {
            await base.InitializeAsync(cancellationToken, progress);

            await InstantiateInsertCommandsAsync();
            await InstantiateGeneralCommandsAsync();
            await InstantiateBuildCommandsAsync();
            await InstantiateDeveloperCommandsAsync();
            await InstantiateVisualStudioCommandsAsync();
            await InstantiateRestartCommandsAsync();
            await InstantiateOptionsCommandsAsync();
            await InstantiateSolutionCommandsAsync();
            await InstantiateProjectCommandsAsync();

            ActivityLog.LogInformation("Time Savers", "Commands have been instantiated");
        }

        private async Tasks.Task InstantiateProjectCommandsAsync()
        {
            await EditProjectCommand.InstantiateAsync(this);
        }

        private async Tasks.Task InstantiateSolutionCommandsAsync()
        {
            await EditSolutionCommand.InstantiateAsync(this);
            await CloseSolutionCommand.InstantiateAsync(this);
        }

        private async Tasks.Task InstantiateOptionsCommandsAsync()
        {
            await KeyboardOptionsCommand.InstantiateAsync(this);
            await TimeSaversOptionsCommand.InstantiateAsync(this);
        }

        private async Tasks.Task InstantiateRestartCommandsAsync()
        {
            await RestartNormalCommand.InstantiateAsync(this);
            await RestartElevatedCommand.InstantiateAsync(this);
        }

        private async Tasks.Task InstantiateVisualStudioCommandsAsync()
        {
            await ManageExtensionsCommand.InstantiateAsync(this);
        }

        private async Tasks.Task InstantiateDeveloperCommandsAsync()
        {
            await ActivityLogCommand.InstantiateAsync(this);
            await DiagnosticLogCommand.InstantiateAsync(this);
            await PathVariablesCommand.InstantiateAsync(this);
        }

        private async Tasks.Task InstantiateGeneralCommandsAsync()
        {
            await BrowserWindowCommand.InstantiateAsync(this);
        }

        private async Tasks.Task InstantiateBuildCommandsAsync()
        {
            await RebuildProjectCommand.InstantiateAsync(this);
            await RebuildSolutionCommand.InstantiateAsync(this);
            await CancelBuildCommand.InstantiateAsync(this);
        }

        private async Tasks.Task InstantiateInsertCommandsAsync()
        {
            await InsertGuidCommand.InstantiateAsync(this);
        }
    }
}