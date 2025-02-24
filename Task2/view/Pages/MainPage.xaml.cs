using System;
using System.Windows;
using System.Windows.Controls;
using Task2.Core;

namespace Task2.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void BtnTask_Click(object sender, RoutedEventArgs e)
        {
            int sw = Convert.ToInt32(NumTask.Text);

            SwitchToTask switchtask = new SwitchToTask(sw);
            switchtask.SwitchTask();
            NumTask.Clear();
        }
    }
}