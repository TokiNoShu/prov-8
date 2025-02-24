using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task21Page : Page
    {
        public Task21Page()
        {
            InitializeComponent();
        }

        private void BtnTask21_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator21 calculator21 = new Calculator21(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                if (calculator21.CalculateA())
                    MessageBox.Show("Круг уместится в квадрате.", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Квадрат уместится в круге.", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}
