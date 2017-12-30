using System.Collections.ObjectModel;

namespace Luminous.TimeSavers.UI.PathVariables
{
    using Luminous.Code.MVVM;

    public class PathVariablesViewModel : ViewModelBase
    {
        public ObservableCollection<PathModel> Paths { get; }

        public PathVariablesViewModel()
        {
            Paths = new PathData();
        }
    }
}