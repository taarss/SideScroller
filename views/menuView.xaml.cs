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

namespace SideScroller.views
{
    /// <summary>
    /// Interaction logic for menuView.xaml
    /// </summary>
    public partial class menuView : UserControl
    {
        public menuView()
        {
            InitializeComponent();
            
        }
        //Starts game
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            menu.Visibility = System.Windows.Visibility.Hidden;
            gameViewModel gameViewModel = (gameViewModel)App.Current.Resources["SharedGame"];
            gameViewModel.StartGame();
        }

        //Complete registration
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            registerCanvas.Visibility = Visibility.Hidden;
        }

        //Open registration menu
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            registerCanvas.Visibility = Visibility.Visible;
        }

        //Back to main menu
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            registerCanvas.Visibility = Visibility.Hidden;
            loginCanvas.Visibility = Visibility.Hidden;
            scoreCanvas.Visibility = Visibility.Hidden;
        }
        //Open login menu
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            loginCanvas.Visibility = Visibility.Visible;
        }
        //Opens Score menu
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            scoreCanvas.Visibility = Visibility.Visible;
            menuViewModel menuViewModel = (menuViewModel)App.Current.Resources["SharedMenu"];
            menuViewModel.loadTopGlobalScores();
            menuViewModel.loadAllPersonalScores();
        }
    }
}
