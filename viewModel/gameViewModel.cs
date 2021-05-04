using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SideScroller.model;

namespace SideScroller.viewModel
{
    public class gameViewModel
    {
        private player player = new player();
        private tick tick = new tick();
        private playerEntity playerCoordinates = new playerEntity();
        private ObservableCollection<blockcades> movingBlockades = new ObservableCollection<blockcades>();
        private ObservableCollection<blockcades> blockadesType = new ObservableCollection<blockcades>();
        private ObservableCollection<activeBlockade> activeBlockades = new ObservableCollection<activeBlockade>();

        public gameViewModel()
        {      
            PlayerCoordinates.CoordinatesY = 200;
            //tick.StartGame();
            loadBlockades();
        }

        public playerEntity PlayerCoordinates { get => playerCoordinates; set => playerCoordinates = value; }
        public ObservableCollection<blockcades> MovingBlockades { get => movingBlockades; set => movingBlockades = value; }
        public ObservableCollection<blockcades> BlockadesType { get => blockadesType; set => blockadesType = value; }
        public ObservableCollection<activeBlockade> ActiveBlockades { get => activeBlockades; set => activeBlockades = value; }
        public player Player { get => player; set => player = value; }

        public void StartGame()
        {
            tick.StartGame();
        }

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
            generateBlockade();
        }

        public void generateBlockade()
        {
            var random = new Random();
            int index = random.Next(BlockadesType.Count);
            blockcades newBlockade = blockadesType[index];
            Coordinate entity = new Coordinate(900, 0);
            activeBlockade activeBlockade = new activeBlockade(entity);
            activeBlockade.BlockadeId = newBlockade.BlockadeId;
            activeBlockade.Texture = newBlockade.Texture;
            activeBlockade.Height = random.Next(200, 430);
            spawnBlockade(activeBlockade);
        }

        public void spawnBlockade(activeBlockade blockade)
        {
            ActiveBlockades.Add(blockade);
        }
        public void moveBlockade()
        {
            int index = 0;
            Player.Score++;
            foreach (activeBlockade element in new List<activeBlockade>(activeBlockades))
            {
                element.Position.X = element.Position.X - 20;
                if(element.Position.X < -40)
                {
                    activeBlockades.RemoveAt(0);
                    generateBlockade();
                }
                index++;
            }
            checkIfIntersects();
        }
        public void checkIfIntersects()
        {
            foreach (activeBlockade element in activeBlockades)
            {
                if(element.Position.X <= 252 && element.Position.X >= 152 && element.Height <= +playerCoordinates.PlayerHitbox)
                {
                    tick.GameOver();
                }
            }
        }
    }
}
