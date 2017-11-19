namespace Luminous.TimeSavers.UI.PathVariables
{
    public class Model : NotificationObject
    {
        public string Caption { get; set; }

        //public ObservableCollection<Model> Items { get; set; }

        public Model()
        {
        }

        public override string ToString()
        {
            return this.Caption;
        }
    }
}