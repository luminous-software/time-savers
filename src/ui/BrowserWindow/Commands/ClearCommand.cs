using System;
using System.Windows.Input;

namespace Luminous.TimeSavers.UI.BrowserWindow.Commands
{
    internal class ClearCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => throw new NotImplementedException();

        public void Execute(object parameter) => throw new NotImplementedException();
    }
}