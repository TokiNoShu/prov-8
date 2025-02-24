using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator2 calculator2 = new Calculator2(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text));
                
                MessageBox.Show($"Надбавка к зарплате: {calculator2.CalculateA()}\nСумма к выплате: {calculator2.CalculateB()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
            }
        }
    }
}

