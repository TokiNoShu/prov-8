using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task19Page : Page
    {
        public Task19Page()
        {
            InitializeComponent();
        }

        private void BtnTask19_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator19 calculator19 = new Calculator19(Convert.ToInt32(TbA.Text), Convert.ToInt32(TbB.Text), Convert.ToInt32(TbC.Text));

                MessageBox.Show($"Ваша надбавка за стаж составляет: {calculator19.CalculateA()}%", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
            }
        }
    }
}
