using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{

    public partial class Task25Page : Page
    {
        public Task25Page()
        {
            InitializeComponent();
        }

        private void BtnTask25_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) && string.IsNullOrEmpty(TbB.Text) && string.IsNullOrEmpty(TbC.Text) && string.IsNullOrEmpty(TbD.Text))
            {
                MessageBox.Show("Нет данных!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Calculator25 calculator25 = new Calculator25(Convert.ToDouble(TbA.Text), Convert.ToDouble(TbB.Text), Convert.ToDouble(TbC.Text), Convert.ToDouble(TbD.Text));

                if (calculator25.CalculateA())
                    MessageBox.Show("Меньший ток течёт по первому участку", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                else MessageBox.Show("Меньший ток течёт по второму участку", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                TbA.Text = string.Empty;
                TbB.Text = string.Empty;
                TbC.Text = string.Empty;
                TbD.Text = string.Empty;
            }
        }
    }
}
