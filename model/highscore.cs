using System;
using System.Collections.Generic;
using System.Text;

namespace SideScroller.model
{
    public class highscore
    {
        private int id;
        private int score;
        private int playerId;

        public int Id { get => id; set => id = value; }
        public int Score { get => score; set => score = value; }
        public int PlayerId { get => playerId; set => playerId = value; }
    }
}
