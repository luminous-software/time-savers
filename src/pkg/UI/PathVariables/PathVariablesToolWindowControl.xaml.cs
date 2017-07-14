namespace Luminous.TimeSavers.UI.PathVariables
{
    using System.Windows;
    using System.Windows.Controls;

    public partial class PathVariablesToolWindowControl : UserControl
    {
        public PathVariablesToolWindowControl()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                string.Format(System.Globalization.CultureInfo.CurrentUICulture, "Invoked '{0}'", this.ToString()),
                "Path Variables");
        }
    }
}