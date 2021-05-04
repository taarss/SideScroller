using SideScroller.viewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using SideScroller.model;
using System.Linq;

namespace SideScroller.commands
{
    public class LoginCommand : ICommand
    {
        public menuViewModel menuViewModel { get; set; }
        public LoginCommand(menuViewModel menu)
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
            gameViewModel gameViewModel = (gameViewModel)App.Current.Resources["SharedGame"];
            menuViewModel menuViewModel = (menuViewModel)App.Current.Resources["SharedMenu"];
            loginRegister loginRegister = new loginRegister();
            if(loginRegister.login(menuViewModel.UnregisteredAccount.Username, menuViewModel.UnregisteredAccount.Password))
            {
                var context = new SideScrollerDBContext();
                var account = context.Players
                    .Where(s => s.Username == menuViewModel.UnregisteredAccount.Username);
                gameViewModel.Player = account.First();
                gameViewModel.IsLoggedIn = true;
            }
        }

    }
}
