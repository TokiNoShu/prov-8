using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }

        private void BtnTask13_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator13 calculator13 = new Calculator13(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                MessageBox.Show($"Сумма ежемесячных выплат по депозиту: {calculator13.CalculateA()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}
