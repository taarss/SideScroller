using System;
using System.Collections.Generic;
using System.Text;

namespace SideScroller.model
{
    public class soundPlayer
    {
        private System.Media.SoundPlayer player;

        public void mainMenu()
        {
            player = new System.Media.SoundPlayer("C:/Users/chri45n5/Source/Repos/SideScrollerGame/sounds/main.wav");
            player.PlayLooping();
        }
        public void gameplay()
        {
            player = new System.Media.SoundPlayer("C:/Users/chri45n5/Source/Repos/SideScrollerGame/sounds/gameplay.wav");
            player.PlayLooping();
        }
        public void stop()
        {
            player.Stop();
        }
    }
}
