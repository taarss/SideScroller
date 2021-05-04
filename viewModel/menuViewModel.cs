using System;
using System.Collections.Generic;
using System.Text;
using SideScroller.model;
using SideScroller.viewModel;
using SideScroller.commands;
using System.Collections.ObjectModel;

namespace SideScroller.viewModel
{
    public class menuViewModel
    {
        private ObservableCollection<player> globalScores = new ObservableCollection<player>();
        private ObservableCollection<player> personalScores = new ObservableCollection<player>();
        private player unregisteredAccount = new player();
        private RegisterCommand RegisterCommand;
        private LoginCommand LoginCommand;
        private soundPlayer soundPlayer = (soundPlayer)App.Current.Resources["SharedMusicPlayer"];


        public menuViewModel()
        {
            player debugPlayer = new player();
            debugPlayer.PlayerId = 1;
            debugPlayer.Username = "test";
            debugPlayer.Score = 100;
            GlobalScores.Add(debugPlayer);
            this.RegisterCommand = new RegisterCommand(this);
            this.LoginCommand = new LoginCommand(this);
            soundPlayer.mainMenu();
        }

        public player UnregisteredAccount { get => unregisteredAccount; set => unregisteredAccount = value; }
        public RegisterCommand RegisterCommand1 { get => RegisterCommand; set => RegisterCommand = value; }
        public LoginCommand LoginCommand1 { get => LoginCommand; set => LoginCommand = value; }
        public ObservableCollection<player> GlobalScores { get => globalScores; set => globalScores = value; }
        public ObservableCollection<player> PersonalScores { get => personalScores; set => personalScores = value; }

        public void loadTopGlobalScores()
        {

        }
    }
}
