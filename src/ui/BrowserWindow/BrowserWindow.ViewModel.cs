using System.Collections.ObjectModel;

namespace Luminous.TimeSavers.UI.BrowserWindow
{
    using Luminous.Code.MVVM;

    public class BrowserWindowViewModel : ViewModelBase
    {
        public string Url { get; }
        public ObservableCollection<string> Urls { get; }

        public ObservableCollection<string> GetUrls()
        {
            return new ObservableCollection<string>();
        }

        public void SaveUrls()
        {
        }
    }
}