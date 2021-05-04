using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SideScroller.model
{
    public class player : INotifyPropertyChanged
    {
        private int playerId;
        private int username;
        private int password;
        private int score;

        public int PlayerId { get => playerId; set => playerId = value; }
        public int Username { get => username; set => username = value; }
        public int Password { get => password; set => password = value; }
        public int Score { get => score; set { 
                if(score != value)
                {
                    score = value;
                    RaisePropertyChanged("Score");  
                }
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
