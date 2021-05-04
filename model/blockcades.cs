using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SideScroller.model
{
    public class blockcades : INotifyPropertyChanged
    {
        private int blockadeId;
        private string texture;

        public blockcades()
        {

        }

        [Key]
        public int BlockadeId { get => blockadeId; set => blockadeId = value; }
        public string Texture { get => texture; set => texture = value; }
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
