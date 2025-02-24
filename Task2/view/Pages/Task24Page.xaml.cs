using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task24Page : Page
    {
        public Task24Page()
        {
            InitializeComponent();
        }

        private void BtnTask24_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator24 calculator24 = new Calculator24(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));

                if (calculator24.CalculateA())
                    MessageBox.Show("Круг уместится в треугольнике", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Треугольник уместится в круге", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
            }
        }
    }
}
