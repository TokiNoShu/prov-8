using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text))
            {
                MessageBox.Show("Введите номер месяца", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    int month = Convert.ToInt32(TbA.Text);
                    Calculator5 calculator5 = new Calculator5(month);
                    string season = calculator5.CalculateA();
                    MessageBox.Show($"Сезон: {season}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    TbA.Text = string.Empty;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}