using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace SideScroller.commands
{
    public class windowCommand : ICommand
    {
        public MainWindow MainWindow { get; set; }
        public windowCommand()
        {

        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

        }
    }
}
