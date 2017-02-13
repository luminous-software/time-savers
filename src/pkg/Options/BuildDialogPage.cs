using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(BuildDialogPageString)]
    public class BuildDialogPage : DialogPage
    {
        //***
        //!!!
        //!!!

        [Category(H1 + BuildFeatureSet)]
        [DisplayName(Enable + Space + FeatureSet)]
        [Description("Allows the whole set of " + Build + " features to be turned off together")]
        public bool BuildCommandsEnabled { get; set; } = true;

        //---

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

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}

        //***
    }
}