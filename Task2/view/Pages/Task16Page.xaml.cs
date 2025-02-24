using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }

        private void BtnTask16_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbD.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator16 calculator16 = new Calculator16(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbC.Text), Convert.ToDouble(TbD.Text));
                if (calculator16.CalculateA())
                    MessageBox.Show("Данная точка лежит в окружности тора", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Данная точка не лежит в окружности тора", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
                TbC.Text = string.Empty;
                TbD.Text = string.Empty;
            }
        }
    }
}
