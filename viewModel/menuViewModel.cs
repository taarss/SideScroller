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
        private player player = new player();
        private ObservableCollection<player> globalScores = new ObservableCollection<player>();
        private ObservableCollection<player> personalScores = new ObservableCollection<player>();
        private player unregisteredAccount = new player();
        private RegisterCommand RegisterCommand;
        private LoginCommand LoginCommand;
        private soundPlayer soundPlayer = (soundPlayer)App.Current.Resources["SharedMusicPlayer"];


        public menuViewModel()
        {
            this.RegisterCommand = new RegisterCommand(this);
            this.LoginCommand = new LoginCommand(this);
            soundPlayer.mainMenu();
            
        }

        public player UnregisteredAccount { get => unregisteredAccount; set => unregisteredAccount = value; }
        public RegisterCommand RegisterCommand1 { get => RegisterCommand; set => RegisterCommand = value; }
        public LoginCommand LoginCommand1 { get => LoginCommand; set => LoginCommand = value; }
        public ObservableCollection<player> GlobalScores { get => globalScores; set => globalScores = value; }
        public ObservableCollection<player> PersonalScores { get => personalScores; set => personalScores = value; }
        public player Player { get => player; set => player = value; }

     
        public void loadTopGlobalScores()
        {
            if(GlobalScores.Count == 0)
            {
                var context = new SideScrollerDBContext();
                var topGlobalScores = context.Highscores
                    .FromSqlRaw("SELECT TOP 50 * FROM Highscores ORDER BY Score DESC").ToList();
                foreach (var element in topGlobalScores)
                {   
                    var topGlobalPlayers = context.Players
                     .Where(p => p.Id == element.PlayerId).FirstOrDefault();
                    player scoreEntry = new player();
                    scoreEntry.CurrentScore = element.Score;
                    scoreEntry.Username = topGlobalPlayers.Username;
                    GlobalScores.Add(scoreEntry);

                }
                //.FromSqlRaw("SELECT Id, Score, PlayerId FROM Highscores LEFT JOIN Players ON Highscores.PlayerId = Players.Id ORDER BY Highscores.Score DESC").ToList();
            }

        }
        public void loadAllPersonalScores()
        {
            if(PersonalScores.Count == 0)
            {
                var context = new SideScrollerDBContext();
                gameViewModel gameViewModel = (gameViewModel)App.Current.Resources["SharedGame"];
                var topPersonallScores = context.Highscores
                    .Where(h => h.PlayerId == gameViewModel.Player.Id).OrderByDescending(s => s.Score).ToList();
                foreach (var element in topPersonallScores)
                {
                    player scoreEntry = new player();
                    scoreEntry.CurrentScore = element.Score;
                    scoreEntry.Username = gameViewModel.Player.Username;
                    PersonalScores.Add(scoreEntry);

                }
            }
        }
    }
}
