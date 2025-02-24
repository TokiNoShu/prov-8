using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator6 calculator6 = new Calculator6(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                MessageBox.Show($"Точка А находится в {calculator6.CalculateA()} четверти", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                
                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}
