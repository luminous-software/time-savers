using System;
using System.Runtime.InteropServices;
using shell = Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.UI.BrowserWindow
{
    using static Guids;

    [Guid(BrowserWindowGuidString)]
    public class ToolWindowPane : shell.ToolWindowPane
    {
        public ToolWindowPane() : base(null)
        {
            Caption = "Browser";
            Content = new BrowserWindowToolWindow();
        }

        public override void OnToolWindowCreated()
        {
            base.OnToolWindowCreated();

            //https://code.msdn.microsoft.com/VSSDK-IDE-Sample-Tool-WPF-8823e6d1/sourcecode?fileId=115&pathId=1888183831
        }
    }
}