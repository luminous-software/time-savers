﻿using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.Options
{
    using static PackageConstants;

    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Guid(PackageGuids.GeneralDialogPageString)]
    public class GeneralDialogPage : DialogPage
    {
        //***
        //!!!
        //!!!

        [Category(TimeSavers)]
        [DisplayName(Enable + Space + TimeSavers)]
        [Description("Allows the whole set of " + TimeSavers + " features to be turned off together")]
        public bool TimeSaversEnabled { get; set; } = true;

        [Category("Luminous Browser Windows")]
        [DisplayName("Maximum Windows Open")]
        [Description("Defines how many Luminous Browser windows can be open at any time")]
        public int MaxBrowserWindows { get; set; } = 20;

        //---

        //protected override void OnApply(PageApplyEventArgs e)
        //{
        //    base.OnApply(e);
        //}

        //***
    }
}