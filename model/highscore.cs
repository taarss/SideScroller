using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SideScroller.model
{
    public class highscore
    {
        private int sId;
        private int score;
        private int playerId;

        [Key]
        public int SId { get => sId; set => sId = value; }
        public int Score { get => score; set => score = value; }
        public int PlayerId { get => playerId; set => playerId = value; }
    }
}
