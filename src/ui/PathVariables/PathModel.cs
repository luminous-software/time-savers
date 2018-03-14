namespace Luminous.TimeSavers.UI.PathVariables
{
    using Luminous.Code.Core;

    public class PathModel : NotificationObject
    {
        public string Caption { get; set; }

        //public ObservableCollection<Model> Items { get; set; }

        public PathModel()
        {
        }

        public override string ToString()
        {
            return Caption;
        }
    }
}