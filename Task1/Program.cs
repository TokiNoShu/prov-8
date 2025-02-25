using Classes;
using System;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №8");
            Console.WriteLine("Введите номер задания от 1 до 30:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 1:
                    Calculator1[] calculator1s =
                    {
                        new Calculator1(3.5, 7.2),
                        new Calculator1(-0.5, 1.2),
                        new Calculator1(0.72, -3.12)
                    };
                    foreach (var calc in calculator1s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Точка ({calc.X}, {calc.Y}) лежит в области: {result}");
                    }
                    break;

                case 2:
                    Calculator2[] calculator2s =
                    {
                        new Calculator2(3, 3.5, -2.1),
                        new Calculator2(2.1, -6.55, 0.1),
                        new Calculator2(-9, -3.7, -0.1)
                    };
                    foreach (var calc in calculator2s)
                    {
                        double result = calc.CalculateA();
                        Console.WriteLine($"Среднее значение: {result}");
                    }
                    break;

                case 3:
                    Calculator3[] calculator3s =
                    {
                        new Calculator3(2, 1.5, Convert.ToDouble(Console.ReadLine())),
                        new Calculator3(-0.5, 2.3, Convert.ToDouble(Console.ReadLine())),
                        new Calculator3(1.5, -0.8, Convert.ToDouble(Console.ReadLine()))
                    };
                    foreach (var calc in calculator3s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Точка ({calc.X}, {calc.Y}) лежит внутри окружности: {result}");
                    }
                    break;

                case 4:
                    Calculator4[] calculator4s =
                    {
                        new Calculator4(3, 3.5, -2.1),
                        new Calculator4(21, -6.55, 0.1),
                        new Calculator4(-9, -3.7, -0.1)
                    };
                    foreach (var calc in calculator4s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Треугольник является прямоугольным: {result}");
                    }
                    break;

                case 5:
                    Console.WriteLine("Введите номер месяца:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Calculator5 calculator5 = new Calculator5(month);
                    string season = calculator5.CalculateA();
                    Console.WriteLine($"Сезон: {season}");
                    break;

                case 6:
                    Calculator6[] calculator6s =
                    {
                        new Calculator6(-3, 3.5, 0.1),
                        new Calculator6(58, 27, -87),
                        new Calculator6(-8, -3.7, -0.1)
                    };
                    foreach (var calc in calculator6s)
                    {
                        double[] result = calc.CalculateA();
                        Console.WriteLine($"Результат: A = {result[0]}, B = {result[1]}, C = {result[2]}");
                    }
                    break;

                case 7:
                    Calculator7[] calculator7s =
                    {
                        new Calculator7(2, 2, -4, 0),
                        new Calculator7(8, 9, 12, 1),
                        new Calculator7(-3.5, 0.9, 2, 3)
                    };
                    foreach (var calc in calculator7s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Точка A дальше от начала координат: {result}");
                    }
                    break;

                case 8:
                    Calculator8[] calculator8s =
                    {
                        new Calculator8(3, 3.5, 1.1),
                        new Calculator8(3, 6.55, 6.55),
                        new Calculator8(0.9, 0.9, 0.9)
                    };
                    foreach (var calc in calculator8s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Треугольник равнобедренный: {result}");
                    }
                    break;

                case 9:
                    Calculator9[] calculator9s =
                    {
                        new Calculator9(50, 0.1, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())),
                        new Calculator9(2.45, 0.08, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())),
                        new Calculator9(3.55, 0.12, Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()))
                    };

                    foreach (var a in calculator9s)
                        Console.WriteLine($"Цена разговора за написанные дни: {a.CalculateA()}");
                    break;

                case 10:
                    Console.WriteLine("Введите номер темы (1-3):");
                    int theme = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите вариант (a, b, c):");
                    string variant = Console.ReadLine();
                    Calculator10 calculator10 = new Calculator10(theme, variant);
                    string card = calculator10.CalculateA();
                    Console.WriteLine($"Открытка: {card}");
                    break;

                case 11:
                    Calculator11[] calculator11s =
                    {
                        new Calculator11(-3, 3.5),
                        new Calculator11(5.8, 2.7),
                        new Calculator11(-8, -3.5)
                    };
                    foreach (var calc in calculator11s)
                    {
                        double[] result = calc.CalculateA();
                        Console.WriteLine($"Результат: A = {result[0]}, B = {result[1]}");
                    }
                    break;

                case 12:
                    Calculator12[] calculator12s =
                    {
                        new Calculator12(45, 13, -23),
                        new Calculator12(-31, 65, 12),
                        new Calculator12(52, -1, -33)
                    };
                    foreach (var calc in calculator12s)
                    {
                        double result = calc.CalculateA();
                        Console.WriteLine($"Наименьшее число: {result}");
                    }
                    break;

                case 13:
                    Calculator13[] calculator13s =
                    {
                        new Calculator13(3.2, -7, 0.5),
                        new Calculator13(2.3, 3, 2.5),
                        new Calculator13(23, -34, 89.5)
                    };
                    foreach (var calc in calculator13s)
                    {
                        double[] result = calc.CalculateA();
                        Console.WriteLine($"Числа, большие среднего арифметического по модулю: {string.Join(", ", result)}");
                    }
                    break;

                case 14:
                    Calculator14[] calculator14s =
                    {
                        new Calculator14(2.2, -6),
                        new Calculator14(0.3, 3)
                    };
                    foreach (var calc in calculator14s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Точка ({calc.X}, {calc.Y}) лежит на кривой: {result}");
                    }
                    break;

                case 15:
                    Calculator15[] calculator15s =
                    {
                        new Calculator15(-2.2, -6),
                        new Calculator15(5.3, 3),
                        new Calculator15(-0.8, -4)
                    };
                    foreach (var calc in calculator15s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Точка ({calc.X}, {calc.Y}) лежит в четвертой четверти: {result}");
                    }
                    break;

                case 16:
                    Calculator16[] calculator16s =
                    {
                        new Calculator16(3, 5, 4),
                        new Calculator16(3, 8, 11),
                        new Calculator16(9, 9, 9)
                    };
                    foreach (var calc in calculator16s)
                    {
                        string result = calc.CalculateA();
                        Console.WriteLine($"Результат: {result}");
                    }
                    break;

                case 17:
                    Calculator17[] calculator17s =
                    {
                        new Calculator17(9, 2),
                        new Calculator17(7, -3),
                        new Calculator17(0.1, 4)
                    };
                    foreach (var calc in calculator17s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Точка ({calc.X}, {calc.Y}) лежит в первой четверти: {result}");
                    }
                    break;

                case 18:
                    Calculator18[] calculator18s =
                    {
                        new Calculator18(3.5, 7.2),
                        new Calculator18(-0.5, 1.2),
                        new Calculator18(0.72, -3.12)
                    };
                    foreach (var calc in calculator18s)
                    {
                        bool result = calc.CalculateA();
                        Console.WriteLine($"Точка ({calc.X}, {calc.Y}) лежит на кривой: {result}");
                    }
                    break;

                case 19:
                    Calculator19[] calculator19s =
                    {
                        new Calculator19(30, 121),
                        new Calculator19(-15, 50),
                        new Calculator19(87, 223)
                    };
                    foreach (var calc in calculator19s)
                    {
                        string result = calc.CalculateA();
                        Console.WriteLine($"Полушарие: {result}");
                    }
                    break;

                case 20:
                    Calculator20[] calculator20s =
                    {
                        new Calculator20(3, 3.5, 1.5),
                        new Calculator20(3, 6.55, 6.55),
                        new Calculator20(0.9, 0.9, 0.9)
                    };
                    foreach (var calc in calculator20s)
                    {
                        string result = calc.CalculateA();
                        Console.WriteLine($"Тип треугольника: {result}");
                    }
                    break;

                case 21:
                    Calculator21[] calculator21s =
                    {
                        new Calculator21(-13, -3.5),
                        new Calculator21(5.8, 37),
                        new Calculator21(8, -15)
                    };
                    foreach (var calc in calculator21s)
                    {
                        double[] result = calc.CalculateA();
                        Console.WriteLine($"Результат: A = {result[0]}, B = {result[1]}");
                    }
                    break;

                case 22:
                    Calculator22[] calculator22s =
                    {
                        new Calculator22(15, 13, -33),
                        new Calculator22(-38, 25, 12),
                        new Calculator22(22, -1, -33)
                    };
                    foreach (var calc in calculator22s)
                    {
                        double result = calc.CalculateA();
                        Console.WriteLine($"Наименьшее число: {result}");
                    }
                    break;

                case 23:
                    Calculator23[] calculator23s =
                    {
                        new Calculator23(10, 34, 65),
                        new Calculator23(76, 18, 55),
                        new Calculator23(81, 75, 20)
                    };
                    foreach (var calc in calculator23s)
                    {
                        int[] result = calc.CalculateA();
                        Console.WriteLine($"Числа, большие 1101011: {string.Join(", ", result)}");
                    }
                    break;

                case 24:
                    Calculator24[] calculator24s =
                    {
                        new Calculator24(10, 34, 65),
                        new Calculator24(76, 5, 55),
                        new Calculator24(11, 75, 20)
                    };
                    foreach (var calc in calculator24s)
                    {
                        int result = calc.CalculateA();
                        Console.WriteLine($"Наибольшее число: {result}");
                    }
                    break;

                case 25:
                    Calculator25[] calculator25s =
                    {
                        new Calculator25(0xA, 0x22, 0x41),
                        new Calculator25(0x4C, 0x5, 0x37),
                        new Calculator25(0xB, 0x4B, 0x14)
                    };
                    foreach (var calc in calculator25s)
                    {
                        int result = calc.CalculateA();
                        Console.WriteLine($"Наименьшее число: {result}");
                    }
                    break;

                case 26:
                    Calculator26[] calculator26s =
                    {
                        new Calculator26(56, 38),
                        new Calculator26(47, 91),
                        new Calculator26(29, 76),
                        new Calculator26(19, 53)
                    };
                    foreach (var calc in calculator26s)
                    {
                        int result = calc.CalculateA();
                        Console.WriteLine($"Сумма цифр: {result}");
                    }
                    break;

                case 27:
                    Calculator27[] calculator27s =
                    {
                        new Calculator27(46, 78),
                        new Calculator27(41, 81),
                        new Calculator27(39, 76),
                        new Calculator27(29, 53)
                    };
                    foreach (var calc in calculator27s)
                    {
                        int result = calc.CalculateA();
                        Console.WriteLine($"Произведение цифр: {result}");
                    }
                    break;

                case 28:
                    Calculator28[] calculator28s =
                    {
                        new Calculator28(5, 10, 2),
                        new Calculator28(3, 5, 7),
                        new Calculator28(4, 6, 8)
                    };
                    foreach (var calc in calculator28s)
                    {
                        double[] result = calc.CalculateA();
                        Console.WriteLine($"Сопротивление (последовательно): {result[0]}, (параллельно): {result[1]}");
                    }
                    break;

                case 29:
                    Calculator29[] calculator29s =
                    {
                        new Calculator29(6, 2),
                        new Calculator29(30, 4),
                        new Calculator29(800, 0.6)
                    };
                    foreach (var calc in calculator29s)
                    {
                        string result = calc.CalculateA();
                        Console.WriteLine($"Результат: {result}");
                    }
                    break;

                case 30:
                    Calculator30[] calculator30s =
                    {
                        new Calculator30(6, 10, 2),
                        new Calculator30(3, 5, 7),
                        new Calculator30(4, 12, 8)
                    };
                    foreach (var calc in calculator30s)
                    {
                        string result = calc.CalculateA();
                        Console.WriteLine($"Результат: {result}");
                    }
                    break;

                default:
                    Console.WriteLine("Неверный номер задания.");
                    break;
            }
        }
    }
}