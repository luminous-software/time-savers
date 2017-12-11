using System;

using Luminous.Code.Core;

namespace Luminous.TimeSavers.BrowserControl.ToolWindow
{
    public class ViewModel : ViewModelBase
    {
        public String Url { get; private set; }

        public ViewModel(string url)
        {
            Url = url;
        }
    }
}