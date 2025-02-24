using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task27Page : Page
    {
        public Task27Page()
        {
            InitializeComponent();
        }

        private void BtnTask27_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator27 calculator27 = new Calculator27(Convert.ToDouble(TbA.Text));

                if (calculator27.CalculateA() == 0) MessageBox.Show("Время не может быть больше 24 или меньше 0", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else if (calculator27.CalculateA() == 1) MessageBox.Show("Сейчас время от полуночи до полудня(PM)", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Сейчас время от полудня до полуночи(AM)", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
            }
        }
    }
}
