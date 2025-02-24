using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbD.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator3 calculator3 = new Calculator3(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbC.Text), Convert.ToDouble(TbD.Text));
                if (calculator3.CalculateA())
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