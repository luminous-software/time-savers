using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using orientation = Microsoft.VisualStudio.Shell.ToolWindowOrientation;

using static Microsoft.VisualStudio.Shell.Interop.UIContextGuids80;
using static Microsoft.VisualStudio.Shell.VsDockStyle;
using static EnvDTE.Constants;

namespace Luminous.TimeSavers
{
    using Luminous.Code.VisualStudio.Packages;
    using Commands.Insert;
    using Commands.Build;
    using Commands.VisualStudio;
    using Commands.Restart;
    using Commands.Options;
    using Commands.SolutionNode;
    using Commands.ProjectNode;
    using Commands.Developer;
    using Luminous.TimeSavers.Options;
    using Events;

    using static Core.Constants;
    using static PackageGuids;
    using static Vsix;

    [InstalledProductRegistration(Name, Description, Version, IconResourceID = 400)]
    [Guid(PackageString)]

    [ProvideAutoLoad(NoSolution)]
    [ProvideAutoLoad(SolutionExists)]

    //YD ProvideProfile - for persistence?

    [ProvideToolWindow(typeof(UI.PathVariables.ToolWindowPane), Style = Tabbed, Orientation = orientation.none, Window = vsWindowKindMainWindow, MultiInstances = true, DocumentLikeTool = true)]
    [ProvideToolWindow(typeof(UI.BrowserWindow.ToolWindowPane), Style = Tabbed, Orientation = orientation.none, Window = vsWindowKindMainWindow, MultiInstances = true, DocumentLikeTool = true)]

    [ProvideOptionPage(typeof(GeneralDialogPage), Name, General, 0, 0, supportsAutomation: false)]
    [ProvideOptionPage(typeof(BuildDialogPage), Name, Build, 0, 0, supportsAutomation: false)]
    [ProvideOptionPage(typeof(DeveloperDialogPage), Name, Developer, 0, 0, supportsAutomation: false)]
    [ProvideOptionPage(typeof(VisualStudioDialogPage), Name, VisualStudio, 0, 0, supportsAutomation: false)]

    public sealed class PackageClass : PackageBase
    {
        private BuildDialogPage _buildOptions;
        private VisualStudioDialogPage _visualStudioOptions;

        //***

        public BuildDialogPage BuildOptions
            => _buildOptions ?? (_buildOptions = GetDialogPage(typeof(BuildDialogPage)) as BuildDialogPage);

        public VisualStudioDialogPage VisualStudioOptions
            => _visualStudioOptions ?? (_visualStudioOptions = GetDialogPage(typeof(VisualStudioDialogPage)) as VisualStudioDialogPage);

        //!!!

        public PackageClass() : base(PackageCommandSet, Name, Description)
        { }

        //!!!

        protected override void Initialize()
        {
            base.Initialize();

            InstantiateInsertCommands();
            InstantiateGeneralCommands();
            InstantiateBuildCommands();
            InstantiateDeveloperCommands();
            InstantiateVisualStudioCommands();
            InstantiateRestartCommands();
            InstantiateOptionsCommands();
            InstantiateSolutionCommands();
            InstantiateProjectCommands();

            AdviseSolutionEvents(new VsSolutionEvents(this));
        }

        //===

        private void InstantiateProjectCommands()
        {
            EditProjectCommand.Instantiate(this);
        }

        private void InstantiateSolutionCommands()
        {
            EditSolutionCommand.Instantiate(this);
            CloseSolutionCommand.Instantiate(this);
        }

        private void InstantiateOptionsCommands()
        {
            KeyboardOptionsCommand.Instantiate(this);
            TimeSaversOptionsCommand.Instantiate(this);
        }

        private void InstantiateRestartCommands()
        {
            RestartNormalCommand.Instantiate(this);
            RestartElevatedCommand.Instantiate(this);
        }

        private void InstantiateVisualStudioCommands()
        {
            ExtensionsAndUpdatesCommand.Instantiate(this);
        }

        private void InstantiateDeveloperCommands()
        {
            ActivityLogCommand.Instantiate(this);
            DiagnosticLogCommand.Instantiate(this);
            PathVariablesCommand.Instantiate(this);
        }

        private void InstantiateGeneralCommands()
        {
            BrowserWindowCommand.Instantiate(this);
        }

        private void InstantiateBuildCommands()
        {
            RebuildProjectCommand.Instantiate(this);
            RebuildSolutionCommand.Instantiate(this);
            CancelBuildCommand.Instantiate(this);
        }

        private void InstantiateInsertCommands()
        {
            InsertGuidCommand.Instantiate(this);
        }

        //---

        //TODO: move to framework
        private void AdviseSolutionEvents(IVsSolutionEvents vsSolutionEvents)
        {
            var vsSolution = GetGlobalService<SVsSolution, IVsSolution>();

            vsSolution.AdviseSolutionEvents(vsSolutionEvents, out uint solutionEventsCookie);
        }

        //***
    }
}