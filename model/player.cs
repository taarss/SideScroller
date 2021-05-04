using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SideScroller.model
{
    public class player : INotifyPropertyChanged
    {
        private int id;
        private string username;
        private string password;
        private int currentScore;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int CurrentScore { get => currentScore; set { 
                if(currentScore != value)
                {
                    currentScore = value;
                    RaisePropertyChanged("CurrentScore");  
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
