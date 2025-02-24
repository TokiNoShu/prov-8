using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task18Page : Page
    {
        public Task18Page()
        {
            InitializeComponent();
        }

        private void BtnTask18_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator18 calculator18 = new Calculator18(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbC.Text));

                if (calculator18.CalculateA())
                    MessageBox.Show("Треугольник ABC является равнобедренным", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Треугольник ABC не является равнобедренным", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
                TbC.Text = string.Empty;
            }
        }
    }
}
