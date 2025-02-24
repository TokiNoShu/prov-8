using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task12Page : Page
    {
        public Task12Page()
        {
            InitializeComponent();
        }

        private void BtnTask12_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator12 calculator12 = new Calculator12(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                if (calculator12.CalculateA())
                    MessageBox.Show("Данная точка лежит в первой четверти", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Данная точка не лежит в первой четверти", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}
