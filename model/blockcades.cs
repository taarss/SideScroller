using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SideScroller.model
{
    public class blockcades
    {
        private int blockadeId;
        private string texture;

        public blockcades()
        {
            
        }

        [Key]
        public int BlockadeId { get => blockadeId; set => blockadeId = value; }
        public string Texture { get => texture; set => texture = value; }
    }
}
