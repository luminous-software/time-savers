using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Options.Pages
{
    using static Core.Constants;
    using static Constants.OptionGuids;
    using static Constants.OptionConstants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(BuildDialogPageString)]
    public class BuildDialogPage : DialogPage
    {
        [Category(H1 + BuildFeatureSet)]
        [DisplayName(Enable + Space + FeatureSet)]
        [Description("Allows the whole set of " + Build + " features to be turned off together")]
        public bool BuildCommandsEnabled { get; set; } = true;

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + RebuildSolution)]
        [Description("Rebuilds the current solution")]
        [DefaultValue(true)]
        public bool RebuildSolutionCommandEnabled { get; set; } = true;

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + RebuildProject)]
        [Description("Rebuilds the current project")]
        [DefaultValue(true)]
        public bool RebuildProjectCommandEnabled { get; set; } = true;

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + CancelBuild)]
        [Description("Cancels the currently running build/rebuild")]
        [DefaultValue(true)]
        public bool CancelBuildCommandEnabled { get; set; } = true;
    }
}