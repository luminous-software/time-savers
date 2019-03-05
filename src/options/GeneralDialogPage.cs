using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Options
{
    using static Core.Constants;
    using static Constants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(Guids.GeneralDialogPageString)]
    public class GeneralDialogPage : DialogPage
    {
        [Category(H1 + TimeSavers)]
        [DisplayName(Enable + Space + TimeSavers)]
        [Description("Allows the whole set of " + TimeSavers + " features to be turned off together")]
        public bool TimeSaversEnabled { get; set; } = true;

        [Category(H1 + TimeSavers)]
        [DisplayName(Constants.TimeSaversVersion)]
        [Description("Installed " + TimeSavers + " version")]
        public string TimeSaversVersion { get; } = Vsix.Version;

        //[Category(H2 + "Luminous Browser")]
        //[DisplayName("Maximum Windows Open")]
        //[Description("Defines how many Luminous Browser windows can be open at any time")]
        //public int MaxBrowserWindows { get; set; } = 100;
    }
}