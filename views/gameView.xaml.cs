using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SideScroller.viewModel;
using SideScroller;
using SideScroller.views;
using System.Windows.Threading;
using System.Linq;

namespace SideScroller.views
{
    /// <summary>
    /// Interaction logic for gameView.xaml
    /// </summary>
    public partial class gameView : UserControl
    {

        public gameView()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += HandleKeyPress;
        }

        private void HandleKeyPress(object sender, KeyEventArgs e)
        {
            gameViewModel gameViewModel = (gameViewModel)App.Current.Resources["SharedGame"];
            if(e.Key == Key.Down)
            {
                gameViewModel.PlayerCoordinates.CoordinatesY = gameViewModel.PlayerCoordinates.CoordinatesY + 20;
                gameViewModel.PlayerCoordinates.PlayerHitbox = gameViewModel.PlayerCoordinates.CoordinatesY + 220;
            }
            if(e.Key == Key.Up)
            {
                gameViewModel.PlayerCoordinates.CoordinatesY = gameViewModel.PlayerCoordinates.CoordinatesY - 20;
                gameViewModel.PlayerCoordinates.PlayerHitbox = gameViewModel.PlayerCoordinates.CoordinatesY + 220;
            }

        }
       
       

    }
}
