using System.Windows.Controls;

namespace Luminous.TimeSavers.InsertGuid.Controls
{
    using ToolWindows;
    using ViewModels;

    public partial class InsertGuidControl : UserControl
    {
        //***

        //!!!

        public InsertGuidControl(InsertGuidToolWindow parent)
        {
            InitializeComponent();

            DataContext = new InsertGuidViewModel();
        }

        //!!!

        //***
    }
}