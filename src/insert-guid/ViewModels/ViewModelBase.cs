using System.ComponentModel;

namespace Luminous.TimeSavers.InsertGuid.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetValue()
        {
        }
    }
}