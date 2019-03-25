using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Options.Pages
{
    using static Core.Constants;
    using static Constants.OptionConstants;
    using static Constants.OptionGuids;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(GeneralDialogPageString)]
    public class GeneralDialogPage : DialogPage
    {
        [Category(H1 + TimeSavers)]
        [DisplayName(Enable + Space + TimeSavers)]
        [Description("Allows the whole set of " + TimeSavers + " features to be turned off together")]
        public bool TimeSaversEnabled { get; set; } = true;

        [Category(H1 + TimeSavers)]
        [DisplayName(TimeSaversVersionNumber)]
        [Description("Installed " + TimeSavers + " version")]
        public string TimeSaversVersion { get; } = Vsix.Version;
    }
}