using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SideScroller.model;

namespace SideScroller.viewModel
{
    public class gameViewModel
    {
        private tick tick = new tick();
        private playerEntity playerCoordinates = new playerEntity();
        private ObservableCollection<blockcades> movingBlockades = new ObservableCollection<blockcades>();
        private ObservableCollection<blockcades> blockadesType = new ObservableCollection<blockcades>();
        private ObservableCollection<blockcades> activeBlockades = new ObservableCollection<blockcades>();

        public gameViewModel()
        {
            PlayerCoordinates.CoordinatesY = 200;
            tick.StartGame();
        }

        public playerEntity PlayerCoordinates { get => playerCoordinates; set => playerCoordinates = value; }
        public ObservableCollection<blockcades> MovingBlockades { get => movingBlockades; set => movingBlockades = value; }
        public ObservableCollection<blockcades> BlockadesType { get => blockadesType; set => blockadesType = value; }

        public void Gravity()
        {
            playerCoordinates.CoordinatesY = playerCoordinates.CoordinatesY + 10;
            playerCoordinates.PlayerHitbox = playerCoordinates.PlayerHitbox + 10;
        }

        public void checkHeight()
        {
            if(playerCoordinates.PlayerHitbox < 180)
            {
                tick.GameOver();
            }
        }

        public void loadBlockades()
        {
            using var context = new SideScrollerDBContext();
            foreach (var row in context.Blockcades)
                blockadesType.Add(row);
        }

        public void generateBlockade()
        {
            var random = new Random();
            int index = random.Next(BlockadesType.Count);
            blockcades newBlockade = blockadesType[index];
            

        }
    }
}
