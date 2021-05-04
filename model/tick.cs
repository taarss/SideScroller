using SideScroller.viewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace SideScroller.model
{
    public class tick
    {
        private readonly DispatcherTimer timer = new DispatcherTimer();
        public tick()
        {

        }

        public void StartGame()
        {
            timer.Interval = TimeSpan.FromMilliseconds(75);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        public void GameOver()
        {
            timer.Stop();
        }
        public void Timer_Tick(object sender, EventArgs args)
        {
            gameViewModel gameViewModel = (gameViewModel)App.Current.Resources["SharedGame"];
            gameViewModel.Gravity();
            gameViewModel.moveBlockade();
        }
    }
}
