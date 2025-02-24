using Classes;
using System;
using System.Security.Cryptography;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №8");
            Console.WriteLine("Введите номер задания от 1 до 30:");
            int sm = Convert.ToInt32(Console.ReadLine());

            double x1, x2, x3, y1, y2, y3, a1, a2, a3, b1, b2, b3, c1, c2, c3;

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
                    Console.WriteLine("Введите значение А:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение B:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator14 calculator14 = new Calculator14(a, b);
                    if (calculator14.CalculateA())
                        Console.WriteLine("Разность квадратов больше, чем модуль квадрата разности");
                    else Console.WriteLine("Модуль квадрата разности больше, чем разность квадратов");
                    break;

                case 15:
                    x1 = -2.2;
                    x2 = 5.3;
                    x3 = -0.8;
                    y1 = -6;
                    y2 = 3;
                    y3 = -4;
                    Calculator15[] calculator15s =
                    {
                        new Calculator15(x1, y1),
                        new Calculator15(x2, y2),
                        new Calculator15(x3, y3)
                    };
                    foreach (var a in calculator15s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в четвертой четверти.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в четвертой четверти.");
                    }
                    break;

                case 16:
                    a1 = 3;
                    a2 = 3;
                    a3 = 9;
                    b1 = 5;
                    b2 = 8;
                    b3 = 9;
                    c1 = 4;
                    c2 = 11;
                    c3 = 9;
                    Calculator16[] calculator16s =
                    {
                        new Calculator16(a1, b1, c1),
                        new Calculator16(a2, b2, c2),
                        new Calculator16(a3, b3, c3)
                    };
                    foreach (var a in calculator16s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 17:
                    a1 = 9;
                    a2 = 7;
                    a3 = 0.1;
                    b1 = 2;
                    b2 = -3;
                    b3 = 4;
                    Calculator17[] calculator17s =
                    {
                        new Calculator17(a1, b1),
                        new Calculator17(a2, b2),
                        new Calculator17(a3, b3)
                    };
                    foreach (var a in calculator17s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 18: //хз как делать
                    x1 = 3.5;
                    x2 = -0.5;
                    x3 = 0.72;
                    y1 = 7.2;
                    y2 = 1.2;
                    y3 = -3.12;
                    Calculator18[] calculator18s =
                    {
                        new Calculator18(x1, y1),
                        new Calculator18(x2, y2),
                        new Calculator18(x3, y3)
                    };
                    foreach (var a in calculator18s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 19:
                    fi1 = 30;
                    fi2 = -15;
                    fi3 = 87;
                    lambda1 = 121;
                    lambda2 = 50;
                    lambda3 = 223;
                    Calculator19[] calculator19s =
                    {
                        new Calculator19(fi1, lambda1),
                        new Calculator19(fi2, lambda2),
                        new Calculator19(fi3, lambda3)
                    };
                    foreach (var a in calculator19s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 20:
                    a1 = 3;
                    a2 = 3;
                    a3 = 0.9;
                    b1 = 3.5;
                    b2 = 6.55;
                    b3 = 0.9;
                    c1 = 1.5;
                    c2 = 6.55;
                    c3 = 0.9;

                    Calculator20[] calculator20s =
                    {
                        new Calculator20(a1, b1, c1),
                        new Calculator20(a2, b2, c2),
                        new Calculator20(a3, b3, c3)
                    };
                    foreach (var a in calculator20s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 21:
                    a1 = -13;
                    a2 = -5.8;
                    a3 = 8;
                    b1 = -3.5;
                    b2 = 37;
                    b3 = 0.9;
                    Calculator21[] calculator21s =
                    {
                        new Calculator21(a1, b1),
                        new Calculator21(a2, b2),
                        new Calculator21(a3, b3)
                    };
                    foreach (var a in calculator21s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 22:
                    a1 = 15;
                    a2 = -38;
                    a3 = 22;
                    b1 = 13;
                    b2 = 25;
                    b3 = -1;
                    c1 = -33;
                    c2 = 12;
                    c3 = -15;
                    Calculator22[] calculator22s =
                    {
                        new Calculator22(a1, b1, c1),
                        new Calculator22(a2, b2, c2),
                        new Calculator22(a3, b3, c3)
                    };
                    foreach (var a in calculator22s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 23:
                    a1 = 10;
                    a2 = 76;
                    a3 = 11;
                    b1 = 34;
                    b2 = 5;
                    b3 = 75;
                    c1 = 65;
                    c2 = 55;
                    c3 = 20;
                    Calculator23[] calculator23s =
                    {
                        new Calculator23(a1, b1, c1),
                        new Calculator23(a2, b2, c2),
                        new Calculator23(a3, b3, c3)
                    };
                    foreach (var a in calculator23s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 24:
                    a1 = 10;
                    a2 = 76;
                    a3 = 11;
                    b1 = 34;
                    b2 = 5;
                    b3 = 75;
                    c1 = 65;
                    c2 = 55;
                    c3 = 20;
                    Calculator24[] calculator24s =
                    {
                        new Calculator24(a1, b1, c1),
                        new Calculator24(a2, b2, c2),
                        new Calculator24(a3, b3, c3)
                    };
                    foreach (var a in calculator24s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 25:
                    a1 = 10;
                    a2 = 76;
                    a3 = 11;
                    b1 = 34;
                    b2 = 5;
                    b3 = 75;
                    c1 = 65;
                    c2 = 55;
                    c3 = 20;
                    Calculator25[] calculator25s =
                    {
                        new Calculator25(a1, b1, c1),
                        new Calculator25(a2, b2, c2),
                        new Calculator25(a3, b3, c3)
                    };
                    foreach (var a in calculator25s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 26:
                    a1 = 56;
                    a2 = 47;
                    a3 = 29;
                    a4 = 19;
                    b1 = 38;
                    b2 = 91;
                    b3 = 76;
                    b4 = 53;
                    Calculator26[] calculator26s =
                    {
                        new Calculator26(a1, b1),
                        new Calculator26(a2, b2),
                        new Calculator26(a3, b3),
                        new Calculator26(a4, b4)
                    };
                    foreach (var a in calculator26s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 27:
                    a1 = 36;
                    a2 = 41;
                    a3 = 39;
                    a4 = 29;
                    b1 = 78;
                    b2 = 81;
                    b3 = 76;
                    b4 = 53;
                    Calculator27[] calculator27s =
                    {
                        new Calculator27(a1, b1),
                        new Calculator27(a2, b2),
                        new Calculator27(a3, b3),
                        new Calculator27(a4, b4)
                    };
                    foreach (var a in calculator27s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 28:
                    r11 = 5;
                    r12 = 3;
                    r13 = 4;
                    r21 = 10;
                    r22 = 5;
                    r23 = 6;
                    r31 = 2;
                    r32 = 7;
                    r33 = 8;
                    Calculator28[] calculator28s =
                    {
                        new Calculator28(r11, r12, r13),
                        new Calculator28(r21, r22, r23),
                        new Calculator28(r31, r32, r33)
                    };
                    foreach (var a in calculator28s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 29:
                    om1 = 5;
                    om2 = 30;
                    om3 = 800;
                    a1 = 2;
                    a2 = 4;
                    a3 = 6;

                    Calculator29[] calculator29s =
                    {
                        new Calculator29(om1, a1),
                        new Calculator29(om2, a2),
                        new Calculator29(om3, a3)
                    };
                    foreach (var a in calculator29s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 30:
                    x1 = 3.5;
                    x2 = -0.5;
                    x3 = 0.72;
                    y1 = 7.2;
                    y2 = 1.2;
                    y3 = -3.12;
                    Calculator30[] calculator30s =
                    {
                        new Calculator30(x1, y1),
                        new Calculator30(x2, y2),
                        new Calculator30(x3, y3)
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