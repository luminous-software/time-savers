using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;
using Luminous.TimeSavers;

namespace Luminous.TimeSavers.Options
{
    using static PackageGuids;
    using static PackageConstants;

    [Guid(VisualStudioDialogPageString)]
    public class VisualStudioDialogPage : DialogPage
    {
        //***
        //!!!
        //!!!

        [Category(H1 + VisualStudioFeatureSet)]
        [DisplayName(Enable + Space + FeatureSet)]
        [Description("Allows the whole set of " + VisualStudio + " features to be turned off together")]
        public bool VisualStudioCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + ReopenStartPage)]
        [Description("Automatically reopens the Start Page when you close the solution")]
        [DefaultValue(true)]
        public bool ReopenStartPageEnabled { get; set; } = true;

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + RestartVisualStudio)]
        [Description("Restarts Visual Studio")]
        [DefaultValue(true)]
        public bool RestartVisualStudioEnabled { get; set; } = true;

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + RestartVisualStudioAsAdmin)]
        [Description("Restarts Visual Studio as administrator")]
        [DefaultValue(true)]
        public bool RestartVisualStudioAsAdminEnabled { get; set; } = true;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{

        //    base.OnApply(e);
        //}

        //***
    }
}