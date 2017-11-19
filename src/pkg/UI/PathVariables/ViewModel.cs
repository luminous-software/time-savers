using System.Collections.ObjectModel;

namespace Luminous.TimeSavers.UI.PathVariables.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        public ObservableCollection<Model> Items { get; private set; }

        public ViewModel()
        {
            Items = new ItemData();
        }
    }
}