using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task17Page : Page
    {
        public Task17Page()
        {
            InitializeComponent();
        }

        private void BtnTask17_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator17 calculator17 = new Calculator17(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                if (calculator17.CalculateA())
                    MessageBox.Show("Данная точка лежит в 4 четверти", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Данная точка не лежит в 4 четверти", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}
