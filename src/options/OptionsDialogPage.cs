using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Options
{
    using static Core.Constants;
    using static Constants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(Guids.OptionsDialogPageString)]
    public class OptionsDialogPage : DialogPage
    {
        //***
        //!!!
        //!!!

        [Category(H1 + OptionsFeatureSet)]
        [DisplayName(Enable + Space + FeatureSet)]
        [Description("Allows the whole set of " + Options + " features to be turned on/off together")]
        public bool OptionsCommandsEnabled { get; set; } = true;

        //---

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + TimeSaversOptions)]
        [Description("Displays the Tools | Options | Time Savers options page")]
        [DefaultValue(true)]
        public bool TimeSaversOptionsCommandEnabled { get; set; } = true;

        [Category(H2 + Features)]
        [DisplayName(Enable + Space + KeyboardOptions)]
        [Description("Displays the Tools | Options | Environment | Keyboard options page")]
        [DefaultValue(true)]
        public bool KeyboardOptionsCommandEnabled { get; set; } = true;

        //***
    }
}