using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SideScroller.model;

namespace SideScroller.model
{
    public class activeBlockade : blockcades
    {
        private Coordinate position;
        private int height;

        public activeBlockade(Coordinate position)
        {
            this.Position = position;
        }

        public Coordinate Position { get => position; set => position = value; }
        public int Height { get => height; set { 
                if(height != value)
                {
                    height = value;
                    RaisePropertyChanged("Height");
                }
            } 
        }

        public void generateNewHeight()
        {
            Random rnd = new Random();
            this.Height = rnd.Next(100, 400);

        }
        
    }
}
