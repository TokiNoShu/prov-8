using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task30Page : Page
    {
        public Task30Page()
        {
            InitializeComponent();
        }

        private void BtnTask30_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator30 calculator30 = new Calculator30(Convert.ToInt32(TbA.Text));

                if (calculator30.CalculateA() == 1) MessageBox.Show("Время не может быть больше 24 или меньше 0", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else if (calculator30.CalculateA() == 2) MessageBox.Show("Сейчас время от полуночи до полудня(PM)", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Сейчас время от полудня до полуночи(AM)", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
            }
        }
    }
}
