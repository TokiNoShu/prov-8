using System.Windows;
using Task2.Core;
using Task2.View.Pages;

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MainNavigation.MainFrameNav = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
