namespace Luminous.TimeSavers.BrowserControl.ToolWindow
{
    using System;
    using System.Runtime.InteropServices;

    using static Guids;

    [Guid(ToolWindowGuidString)]
    internal class ToolWindowPane : Microsoft.VisualStudio.Shell.ToolWindowPane
    {
        public ToolWindowPane() : base(null)
        {
            Caption = "Browser";
            Content = new ToolWindowControl();
        }

        public override void OnToolWindowCreated()
        {
            base.OnToolWindowCreated();

            //https://code.msdn.microsoft.com/VSSDK-IDE-Sample-Tool-WPF-8823e6d1/sourcecode?fileId=115&pathId=1888183831
        }
    }
}