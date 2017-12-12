using System;
using System.Runtime.InteropServices;
using shell = Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.BrowserControl
{
    using static Guids;

    [Guid(ToolWindowGuidString)]
    public class ToolWindowPane : shell.ToolWindowPane
    {
        public ToolWindowPane() : base(null)
        {
            Caption = "Browser";
            Content = new ToolWindow();
        }

        public override void OnToolWindowCreated()
        {
            base.OnToolWindowCreated();

            //https://code.msdn.microsoft.com/VSSDK-IDE-Sample-Tool-WPF-8823e6d1/sourcecode?fileId=115&pathId=1888183831
        }
    }
}