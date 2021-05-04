using System;
using System.Collections.Generic;
using System.Text;
using SideScroller.model;
using SideScroller.viewModel;
using SideScroller.commands;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            debugPlayer.Id = 1;
            debugPlayer.Username = "test";
            debugPlayer.CurrentScore = 100;
            GlobalScores.Add(debugPlayer);
            this.RegisterCommand = new RegisterCommand(this);
            this.LoginCommand = new LoginCommand(this);
            soundPlayer.mainMenu();
            loadTopGlobalScores();
        }

        public player UnregisteredAccount { get => unregisteredAccount; set => unregisteredAccount = value; }
        public RegisterCommand RegisterCommand1 { get => RegisterCommand; set => RegisterCommand = value; }
        public LoginCommand LoginCommand1 { get => LoginCommand; set => LoginCommand = value; }
        public ObservableCollection<player> GlobalScores { get => globalScores; set => globalScores = value; }
        public ObservableCollection<player> PersonalScores { get => personalScores; set => personalScores = value; }

        public void loadTopGlobalScores()
        {
            
            var context = new SideScrollerDBContext();

            var topGlobalScores = context.Highscores
                .FromSqlRaw("SELECT * FROM Highscores FULL OUTER JOIN Players ON Highscores.SId").FirstOrDefault();
                //.FromSqlRaw("SELECT Id, Score, PlayerId FROM Highscores LEFT JOIN Players ON Highscores.PlayerId = Players.Id ORDER BY Highscores.Score DESC").ToList();
            
        }
    }
}
