using System.Collections.ObjectModel;
using System.Linq;

using static System.Environment;

namespace Luminous.TimeSavers.UI.PathVariables
{
    public class ItemData : ObservableCollection<Model>
    {
        public ItemData()
        {
            const char semi_colon = ';';
            var variables = ExpandEnvironmentVariables("%path%");
            var values = variables.Split(semi_colon).ToList();

            values.ForEach((s) => Add(new Model() { Caption = s }));
        }

        public void Load()
        {

        }
    }
}
