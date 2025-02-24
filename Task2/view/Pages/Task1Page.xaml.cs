using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator1 calculator1 = new Calculator1(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                if (calculator1.CalculateA())
                    MessageBox.Show("Сумма квадратов больше, чем квадрат суммы.", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Либо оба чётные, либо оба нечётные.", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }

        private void BtnTask17_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
