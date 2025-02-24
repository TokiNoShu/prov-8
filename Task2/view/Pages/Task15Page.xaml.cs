using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task15Page : Page
    {
        public Task15Page()
        {
            InitializeComponent();
        }

        private void BtnTask15_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbD.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator15 calculator15 = new Calculator15(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbC.Text), Convert.ToDouble(TbD.Text));
                if (calculator15.CalculateA())
                    MessageBox.Show("Точка A раполагается на более удалённом расстоянии", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else
                    MessageBox.Show("Точка B раполагается на более удалённом расстоянии", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
                TbC.Text = string.Empty;
                TbD.Text = string.Empty;
            }
        }
    }
}