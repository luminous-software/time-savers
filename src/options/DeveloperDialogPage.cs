using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Options
{
    using static Core.Constants;
    using static Guids;
    using static Constants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(DeveloperDialogPageString)]
    public class DeveloperDialogPage : DialogPage
    {
        //***
        //!!!
        //!!!

        [Category(H1 + DeveloperFeatureSet)]
        [DisplayName(Enable + Space + FeatureSet)]
        [Description("Allows the whole set of " + Developer + " features to be turned off together")]
        public bool DeveloperCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + ActivityLog)]
        [Description("Displays Visual Studio's '" + ActivityLog + "'")]
        [DefaultValue(true)]
        public bool ActivityLogCommandEnabled { get; set; } = true;

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + DiagnosticsLog)]
        [Description("Displays Visual Studio's '" + DiagnosticsLog + "'")]
        [DefaultValue(true)]
        public bool DiagnosticLogCommandEnabled { get; set; } = true;

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + PathVariables)]
        [Description("Displays the current system '" + PathVariables + "'")]
        [DefaultValue(true)]
        public bool PathVariablsCommandEnabled { get; set; } = true;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{
        //    base.OnApply(e);
        //}

        //***
    }
}