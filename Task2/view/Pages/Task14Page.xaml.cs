using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }

        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator14 calculator14 = new Calculator14(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                if (calculator14.CalculateA())
                    MessageBox.Show("Разность квадратов больше, чем модуль квадрата разности", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Модуль квадрата разности больше, чем разность квадратов", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}
