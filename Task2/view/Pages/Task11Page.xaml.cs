using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task11Page : Page
    {
        public Task11Page()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator11 calculator11 = new Calculator11(Convert.ToInt32(TbA.Text));
                if (calculator11.CalculateA() == 1) MessageBox.Show("Число является четным", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else if (calculator11.CalculateA() == 2) MessageBox.Show("Число оканчивается на 3", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Число не является натуральным или не является четным, или не оканчивается на три", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
            }
        }
    }
}
