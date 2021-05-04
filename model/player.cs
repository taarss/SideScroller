using System;
using System.Collections.Generic;
using System.Text;

namespace SideScroller.model
{
    public class player
    {
        private int playerId;
        private int username;
        private int password;

        public int PlayerId { get => playerId; set => playerId = value; }
        public int Username { get => username; set => username = value; }
        public int Password { get => password; set => password = value; }
    }
}
