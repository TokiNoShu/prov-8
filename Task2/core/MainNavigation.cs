using System.Windows.Controls;
using Task2.View.Pages;

namespace Task2.Core
{
    public static class MainNavigation
    {
        public static Frame MainFrameNav { get; set; }
    }
    public class SwitchToTask
    {
        readonly private int _sw;


        public SwitchToTask(int sw)
        {
            _sw = sw;
        }
        public void SwitchTask()
        {
            switch (_sw)
            {
                case 1:
                    MainNavigation.MainFrameNav.Navigate(new Task1Page());
                    break;

                case 2:
                    MainNavigation.MainFrameNav.Navigate(new Task2Page());
                    break;

                case 3:
                    MainNavigation.MainFrameNav.Navigate(new Task3Page());
                    break;

                case 4:
                     MainNavigation.MainFrameNav.Navigate(new Task4Page());
                    break;

                case 5:
                    MainNavigation.MainFrameNav.Navigate(new Task5Page());
                    break;

                case 6:
                    MainNavigation.MainFrameNav.Navigate(new Task6Page());
                    break;

                case 7:
                    MainNavigation.MainFrameNav.Navigate(new Task7Page());
                    break;

                case 8:
                    MainNavigation.MainFrameNav.Navigate(new Task8Page());
                    break;

                case 9:
                    MainNavigation.MainFrameNav.Navigate(new Task9Page());
                    break;

                case 10:
                    MainNavigation.MainFrameNav.Navigate(new Task10Page());
                    break;

                case 11:
                    MainNavigation.MainFrameNav.Navigate(new Task11Page());
                    break;

                case 12:
                    MainNavigation.MainFrameNav.Navigate(new Task12Page());
                    break;

                case 13:
                    MainNavigation.MainFrameNav.Navigate(new Task13Page());
                    break;

                case 14:
                    MainNavigation.MainFrameNav.Navigate(new Task14Page());
                    break;

                case 15:
                    MainNavigation.MainFrameNav.Navigate(new Task15Page());
                    break;

                case 16:
                    MainNavigation.MainFrameNav.Navigate(new Task16Page());
                    break;

                case 17:
                    MainNavigation.MainFrameNav.Navigate(new Task5Page());
                    break;

                case 18:
                    MainNavigation.MainFrameNav.Navigate(new Task18Page());
                    break;

                case 19:
                    MainNavigation.MainFrameNav.Navigate(new Task19Page());
                    break;

                case 20:
                    MainNavigation.MainFrameNav.Navigate(new Task20Page());
                    break;

                case 21:
                    MainNavigation.MainFrameNav.Navigate(new Task21Page());
                    break;

                case 22:
                    MainNavigation.MainFrameNav.Navigate(new Task22Page());
                    break;

                case 23:
                    MainNavigation.MainFrameNav.Navigate(new Task23Page());
                    break;

                case 24:
                    MainNavigation.MainFrameNav.Navigate(new Task24Page());
                    break;

                case 25:
                    MainNavigation.MainFrameNav.Navigate(new Task25Page());
                    break;

                case 26:
                    MainNavigation.MainFrameNav.Navigate(new Task26Page());
                    break;

                case 27:
                    MainNavigation.MainFrameNav.Navigate(new Task27Page());
                    break;

                case 28:
                    MainNavigation.MainFrameNav.Navigate(new Task28Page());
                    break;

                case 29:
                    MainNavigation.MainFrameNav.Navigate(new Task29Page());
                    break;

                case 30:
                    MainNavigation.MainFrameNav.Navigate(new Task30Page());
                    break;
            }
        }
    }
}