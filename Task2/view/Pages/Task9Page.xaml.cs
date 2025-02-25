using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) || string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Введите данные", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    double weekdayMinutes = Convert.ToDouble(TbA.Text);
                    double weekendMinutes = Convert.ToDouble(TbB.Text);

                    double costPerMinute = 50;
                    double discount = 0.1;

                    Calculator9 calculator9 = new Calculator9(costPerMinute, discount, weekdayMinutes, weekendMinutes);
                    double result = calculator9.CalculateA();
                    MessageBox.Show($"Стоимость разговоров: {result}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                    TbA.Text = string.Empty;
                    TbB.Text = string.Empty;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}