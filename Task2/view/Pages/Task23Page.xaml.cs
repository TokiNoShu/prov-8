using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task23Page : Page
    {
        public Task23Page()
        {
            InitializeComponent();
        }

        private void BtnTask23_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator23 calculator23 = new Calculator23(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));

                if (calculator23.CalculateA())
                    MessageBox.Show("Скорость в км/ч больше, чем скорость в м/сек", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Скорость в м/сек больше, чем скорость в км/ч", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}
