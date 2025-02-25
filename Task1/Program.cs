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
            int sm = Convert.ToInt32(Console.ReadLine());

            switch (sm)
            {
                case 1:
                    Calculator1[] calculator1s =
                    {
                        new Calculator1(3.5, 7.2),
                        new Calculator1(-0.5, 1.2),
                        new Calculator1(0.72, -3.12)
                    };
                    foreach (var a in calculator1s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 2:
                    Calculator2[] calculator2s =
                    {
                        new Calculator2(3, 3.5, -2.1),
                        new Calculator2(2.1, -6.55, 0.1),
                        new Calculator2(-9, -3.7, -0.1)
                    };
                    foreach (var a in calculator2s)
                            Console.WriteLine($"Число {a.CalculateA()} среднее.");
                    break;

/*                case 3:
                    Calculator3[] calculator3s =
{
                        new Calculator3(2, 1.5),
                        new Calculator3(-0.5, 2.3),
                        new Calculator3(1.5, -0.8)
                    };
                    foreach (var a in calculator3s)
                        if (a.CalculateA()) Console.WriteLine("Точка A раполагается на более удалённом расстоянии");
                    else Console.WriteLine("Точка B раполагается на более удалённом расстоянии");
                    break;*/

                case 4:
                    Calculator4[] calculator4s =
{
                        new Calculator4(3, 3.5, -2.1),
                        new Calculator4(21, -6.55, 0.1),
                        new Calculator4(-9, -3.7, -0.1)
                    };
                    foreach (var a in calculator4s)
                        if (a.CalculateA())
                            Console.WriteLine("Треугольник ABC является треугольником");
                        else Console.WriteLine("Треугольник ABC не является треугольником");
                    break;

                case 5:
                    Console.WriteLine("Введите номер месяца");
                    int months = Convert.ToInt16(Console.ReadLine());
                    Calculator5 calculator5 = new Calculator5(months);
                    Console.WriteLine(calculator5.CalculateA());
                    break;

                case 6:
                    Calculator6[] calculator6s =
{
                        new Calculator6(-3, 3.5, 0.1),
                        new Calculator6(58, 27, -87),
                        new Calculator6(-8, -3.7, -0.1)
                    };
                    double[] nums = { 1, 2, 3 };
                    foreach (var a in calculator6s)
                        nums = a.CalculateA();
                        for (int i = 0; i < nums.Length; i++)
                        {
                            Console.WriteLine(nums[i]);
                        }
                        
                    break;

                case 7:
                    Calculator7[] calculator7s =
                    {
                        new Calculator7(2, 2, -4, 0),
                        new Calculator7(8, 9, 12, 1),
                        new Calculator7(-3.5, 0.9, 2, 3)
                    };
                    foreach (var a in calculator7s)
                        if (a.CalculateA()) Console.WriteLine("Точка А больше удалена");
                        else Console.WriteLine("Точка B больше удалена");
                    break;

                case 8:
                    Calculator8[] calculator8s =
                    {
                        new Calculator8(3, 3.5, 1.1),
                        new Calculator8(3, 6.55, 6.55),
                        new Calculator8(0.9, 0.9, 0.9)
                    };

                    foreach (var a in calculator8s)
                        if (a.CalculateA()) Console.WriteLine("Равнобедренный");
                        else Console.WriteLine("Неравнобедренный");
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
                    Console.WriteLine("Введите номер:");
                    int otkritka = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Введите вариант (a, b, c):");
                    string variant = Console.ReadLine();
                    Calculator10 calculator10 = new Calculator10(otkritka, variant);
                    Console.WriteLine(calculator10.CalculateA());
                    break;

                case 11:
                    Calculator11[] calculator11s =
                    {
                        new Calculator11(-3, 3.5),
                        new Calculator11(5.8, 2.7),
                        new Calculator11(-8, -3.5)
                    };
                    foreach (var a in calculator11s)
                        Console.WriteLine(a.CalculateA());
                        break;

                case 12:
                    Calculator12[] calculator12s =
                    {
                        new Calculator12(45, 13, -23),
                        new Calculator12(-31, 65, 12),
                        new Calculator12(52, -1, -33)
                    };
                    foreach (var a in calculator12s)
                        Console.WriteLine(a.CalculateA());
                    break;

                case 13:
                    Calculator13[] calculator13s =
                    {
                        new Calculator13(3.2, -7, 0.5),
                        new Calculator13(2.3, 3, 2.5),
                        new Calculator13(23, -34, 89.5)
                    };
                    double[] middleNums = { };
                    foreach (var a in calculator13s)
                        middleNums = a.CalculateA();
                        for (int i = 0; i < middleNums.Length; i++)
                            Console.WriteLine(middleNums[i]);
                    break;

                case 14:

                    break;

                case 15:
                    Calculator15[] calculator15s =
                    {
                        new Calculator15(-2.2, -6),
                        new Calculator15(5.3, 3),
                        new Calculator15(-0.8, -4)
                    };
                    foreach (var a in calculator15s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в четвертой четверти.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в четвертой четверти.");
                    }
                    break;

                case 16:
                    Calculator16[] calculator16s =
                    {
                        new Calculator16(3, 5, 4),
                        new Calculator16(3, 8, 11),
                        new Calculator16(9, 9, 9)
                    };
                    foreach (var a in calculator16s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Площадь треугольника больше");
                        else Console.WriteLine($"Площадь квадрата больше");
                    }
                    break;

                case 17:
                    Calculator17[] calculator17s =
                    {
                        new Calculator17(9, 2),
                        new Calculator17(7, -3),
                        new Calculator17(0.1, 4)
                    };
                    foreach (var a in calculator17s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в первой четверти.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в первой четверти.");
                    }
                    break;

                case 18: //хз как делать
                    Calculator18[] calculator18s =
                    {
                        new Calculator18(3.5, 7.2),
                        new Calculator18(-0.5, 1.2),
                        new Calculator18(0.72, -3.12)
                    };
                    foreach (var a in calculator18s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 19:
                    Calculator19[] calculator19s =
                    {
                        new Calculator19(30, 121),
                        new Calculator19(-15, 50),
                        new Calculator19(87, 223)
                    };
                    foreach (var a in calculator19s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 20:
                    Calculator20[] calculator20s =
                    {
                        new Calculator20(3, 3.5, 1.5),
                        new Calculator20(3, 6.55, 6.55),
                        new Calculator20(0.9, 0.9, 0.9)
                    };
                    foreach (var a in calculator20s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 21:
                    Calculator21[] calculator21s =
                    {
                        new Calculator21(-13, -3.5),
                        new Calculator21(-5.8, 37),
                        new Calculator21(8, 0.9)
                    };
                    foreach (var a in calculator21s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 22:
                    Calculator22[] calculator22s =
                    {
                        new Calculator22(15, 13, -33),
                        new Calculator22(-38, 25, 12),
                        new Calculator22(22, -1, -15)
                    };
                    foreach (var a in calculator22s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 23:
                    Calculator23[] calculator23s =
                    {
                        new Calculator23(10, 34, 65),
                        new Calculator23(76, 5, 55),
                        new Calculator23(11, 75, 20)
                    };
                    foreach (var a in calculator23s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 24:
                    Calculator24[] calculator24s =
                    {
                        new Calculator24(10, 34, 65),
                        new Calculator24(76, 5, 55),
                        new Calculator24(11, 75, 20)
                    };
                    foreach (var a in calculator24s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 25:
                    Calculator25[] calculator25s =
                    {
                        new Calculator25(10, 34, 65),
                        new Calculator25(76, 5, 55),
                        new Calculator25(11, 75, 20)
                    };
                    foreach (var a in calculator25s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
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
                    foreach (var a in calculator26s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 27:
                    Calculator27[] calculator27s =
                    {
                        new Calculator27(36, 78),
                        new Calculator27(41, 81),
                        new Calculator27(39, 76),
                        new Calculator27(29, 53)
                    };
                    foreach (var a in calculator27s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 28:
                    Calculator28[] calculator28s =
                    {
                        new Calculator28(5, 3, 4),
                        new Calculator28(10, 5, 6),
                        new Calculator28(2, 7, 8)
                    };
                    foreach (var a in calculator28s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 29:
                    Calculator29[] calculator29s =
                    {
                        new Calculator29(5, 2),
                        new Calculator29(30, 4),
                        new Calculator29(800, 6)
                    };
                    foreach (var a in calculator29s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 30:
                    Calculator30[] calculator30s =
                    {
                        new Calculator30(3.5, 7.2),
                        new Calculator30(-0.5, 1.2),
                        new Calculator30(-0.72, -3.12)
                    };
                    foreach (var a in calculator30s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;
            }
        }
    }
}