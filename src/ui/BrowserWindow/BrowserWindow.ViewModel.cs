using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Luminous.TimeSavers.UI.BrowserWindow
{
    using Luminous.Code.MVVM;
    using Commands;

    public class BrowserWindowViewModel : ViewModelBase
    {
        private string url = "";

        public string Url { get => Get<string>(url); set => Set(url); }

        public string UrlHeader { get => "URL:"; }

        public string UrlWatermark { get => "Enter url"; }

        public ObservableCollection<string> Urls { get; }

        public ICommand ClearCommand { get => new ClearCommand(); }

        public ObservableCollection<string> GetUrls()
        {
            return new ObservableCollection<string>();
        }

        public void SaveUrls()
        {
        }
    }
}