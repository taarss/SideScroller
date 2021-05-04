using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SideScroller.model
{
    public class Coordinate : INotifyPropertyChanged
    {
        private int y;
        private int x;

        public Coordinate(int x, int y)
        {
            this.Y = y;
            this.X = x;
        }

        public int Y
        {
            get => y; set
            {
                if (y != value)
                {
                    y = value;
                    RaisePropertyChanged("Y");
                }
            }
        }
        public int X
        {
            get => x; set
            {
                if (x != value)
                {
                    x = value;
                    RaisePropertyChanged("X");
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
