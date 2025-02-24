using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task22Page : Page
    {
        public Task22Page()
        {
            InitializeComponent();
        }

        private void BtnTask22_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbD.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator22 calculator22 = new Calculator22(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbC.Text), Convert.ToDouble(TbD.Text));
                if (calculator22.CalculateA())
                    MessageBox.Show("Плотность первого тела больше, чем плотность второго тела", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Плотность второго тела больше, чем плотность первого", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
                TbC.Text = string.Empty;
                TbD.Text = string.Empty;
            }
        }
    }
}
