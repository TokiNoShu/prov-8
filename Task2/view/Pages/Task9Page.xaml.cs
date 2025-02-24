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
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator9 calculator9 = new Calculator9(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                if (calculator9.CalculateA())
                    MessageBox.Show("Площадь квадрата больше, чем площадь круга", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Площадь круга больше, чем площадь квадрата", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}
