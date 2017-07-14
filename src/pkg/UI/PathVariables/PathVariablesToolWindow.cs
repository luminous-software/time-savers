namespace Luminous.TimeSavers.UI.PathVariables
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;
    using static PackageGuids;

    [Guid(PathVariablesToolWindowString)]
    public class PathVariablesToolWindow : ToolWindowPane
    {
        public PathVariablesToolWindow() : base(null)
        {
            this.Caption="Path Variables";

            this.Content=new PathVariablesToolWindowControl();
        }
    }
}
