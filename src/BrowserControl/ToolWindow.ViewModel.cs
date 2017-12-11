using System;

using Luminous.Code.MVVM;

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