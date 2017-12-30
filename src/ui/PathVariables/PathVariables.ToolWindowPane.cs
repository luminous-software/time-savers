using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace Luminous.TimeSavers.UI.PathVariables
{
    using static Guids;

    [Guid(PathVariablesGuidString)]
    public class PathVariablesToolWindowPane : ToolWindowPane
    {
        public PathVariablesToolWindowPane() : base(null)
        {
            Caption = "Path Variables";
            Content = new ToolWindowControl();
        }

        public override void OnToolWindowCreated()
        {
            base.OnToolWindowCreated();

            //https://code.msdn.microsoft.com/VSSDK-IDE-Sample-Tool-WPF-8823e6d1/sourcecode?fileId=115&pathId=1888183831
        }
    }
}