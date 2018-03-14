using System.Collections.ObjectModel;
using System.Linq;

using static System.Environment;

namespace Luminous.TimeSavers.UI.PathVariables
{
    public class PathData : ObservableCollection<PathModel>
    {
        public PathData()
        {
            const char semi_colon = ';';
            var variables = ExpandEnvironmentVariables("%path%");
            var values = variables.Split(semi_colon).ToList();

            values.ForEach((s) => Add(new PathModel() { Caption = s }));
        }

        public void Load()
        {
        }
    }
}