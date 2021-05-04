using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using SideScroller.model;
using SideScroller.viewModel;

namespace SideScroller.commands
{
    public class RegisterCommand : ICommand
    {
        public menuViewModel menuViewModel { get; set; }

        public RegisterCommand(menuViewModel menu)
        {
            this.menuViewModel = menu;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            menuViewModel menuViewModel = (menuViewModel)App.Current.Resources["SharedMenu"];
            loginRegister loginRegister = new loginRegister();
            loginRegister.registerAccount(menuViewModel.UnregisteredAccount.Username, menuViewModel.UnregisteredAccount.Password);
        }
    }
}
