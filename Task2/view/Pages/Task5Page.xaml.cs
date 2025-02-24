using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator5 calculator5 = new Calculator5(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbC.Text));
                MessageBox.Show($"Ваши числа после изменения: {calculator5.CalculateA()[0]}, {calculator5.CalculateA()[1]}, {calculator5.CalculateA()[2]}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
                TbC.Text = string.Empty;
            }
        }
    }
}
