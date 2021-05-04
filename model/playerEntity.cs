using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SideScroller.model
{
    public class playerEntity : INotifyPropertyChanged
    {
        private int coordinatesY = 200;
        private int playerHitbox = 100;

       

        public int PlayerHitbox { get => playerHitbox; set { 
            if(playerHitbox != value)
                {
                    playerHitbox = value;
                    RaisePropertyChanged("PlayerHitBox");
                }
            } 
        }

        public int CoordinatesY { get => coordinatesY; set { 
            if(coordinatesY != value)
                {
                    coordinatesY = value;
                    RaisePropertyChanged("CoordinatesY");
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
