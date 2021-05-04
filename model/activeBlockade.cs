using System;
using System.Collections.Generic;
using System.Text;
using SideScroller.model;

namespace SideScroller.model
{
    public class activeBlockade : blockcades
    {
        private playerEntity position;
        private int height;

        public activeBlockade(playerEntity position)
        {
            this.Position = position;
        }

        public playerEntity Position { get => position; set => position = value; }
        public int Height { get => height; set => height = value; }
    }
}
