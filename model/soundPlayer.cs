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
            player = new System.Media.SoundPlayer("C:/Users/chris/Source/Repos/SideScroller/sounds/main.wav");
            player.PlayLooping();
        }
        public void gameplay()
        {
            player = new System.Media.SoundPlayer("C:/Users/chris/Source/Repos/SideScroller/sounds/gameplay.wav");
            player.PlayLooping();
        }
        public void stop()
        {
            player.Stop();
        }
    }
}
