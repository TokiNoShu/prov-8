using System;
using System.Windows;
using System.Windows.Controls;
using Classes;

namespace Task2.View.Pages
{
    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }

        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbA.Text) || string.IsNullOrEmpty(TbB.Text))
            {
                MessageBox.Show("Введите данные!", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                try
                {
                    int theme = Convert.ToInt32(TbA.Text);
                    string variant = TbB.Text.ToLower();

                    if (theme < 1 || theme > 3 || (variant != "a" && variant != "b" && variant != "c"))
                    {
                        MessageBox.Show("Некорректный ввод! Тема должна быть от 1 до 3, а вариант - a, b или c.", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        Calculator10 calculator10 = new Calculator10(theme, variant);
                        string card = calculator10.CalculateA();
                        MessageBox.Show($"Открытка: {card}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

                        TbA.Text = string.Empty;
                        TbB.Text = string.Empty;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Некорректный ввод! Введите число для темы и букву для варианта.", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}