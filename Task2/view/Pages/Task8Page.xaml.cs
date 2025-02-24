using System;
using System.Windows;
using System.Windows.Controls;
using Classes;


namespace Task2.View.Pages
{

    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbA1.Text) && string.IsNullOrEmpty(TbB1.Text) && string.IsNullOrEmpty(TbC1.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator8 calculator8 = new Calculator8(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbC.Text), Convert.ToDouble(TbA1.Text), Convert.ToDouble(TbB1.Text), Convert.ToDouble(TbC1.Text));
                if (calculator8.CalculateA())
                    MessageBox.Show("Площадь первого треугольника больше площади второго", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Площадь второго треугольника больше площади первого", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
                TbC.Text = string.Empty;
                TbA1.Text = string.Empty;
                TbB1.Text = string.Empty;
                TbC1.Text = string.Empty;
            }
        }
    }
}
