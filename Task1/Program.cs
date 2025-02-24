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

            double x1, x2, x3, y1, y2, y3, a1, a2, a3, a4, b1, b2, b3, b4, c1, c2, c3, fi1, fi2, fi3, lambda1, lambda2, lambda3, r11, r12, r13, r21, r22, r23, r31, r32, r33, om1, om2, om3;

            switch (sm)
            {
                case 1:
                    x1 = 3.5;
                    x2 = -0.5;
                    x3 = 0.72;
                    y1 = 7.2;
                    y2 = 1.2;
                    y3 = -3.12;
                    Calculator1[] calculator1s =
                    {
                        new Calculator1(x1, y1),
                        new Calculator1(x2, y2),
                        new Calculator1(x3, y3)
                    };
                    foreach (var a in calculator1s)
                    {
                        if (a.CalculateA())
                            Console.WriteLine($"Точка А({a.X}, {a.Y}) лежит в области.");
                        else Console.WriteLine($"Точка А({a.X},{a.Y}) не лежит в области.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Введите ваш стаж:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите вашу зарплату:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator2 calculator2 = new Calculator2(a, b);
                    Console.WriteLine($"Надбавка к зарплате: {calculator2.CalculateA()}");
                    Console.WriteLine($"Сумма к выплате: {calculator2.CalculateB()}");
                    break;

                case 3:
                    Console.WriteLine("Введите координату Ax:");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay:");
                    ay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Bx:");
                    bx = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату By:");
                    by = Convert.ToDouble(Console.ReadLine());


                    Calculator3 calculator3 = new Calculator3(ax, ay, bx, by);
                    if (calculator3.CalculateA()) Console.WriteLine("Точка A раполагается на более удалённом расстоянии");
                    else Console.WriteLine("Точка B раполагается на более удалённом расстоянии");
                    break;

                case 4:
                    Console.WriteLine("Введите значение стороны треугольника А:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны треугольника B:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны треугольника C:");
                    c = Convert.ToDouble(Console.ReadLine());

                    Calculator4 calculator4 = new Calculator4(a, b, c);
                    if (calculator4.CalculateA()) Console.WriteLine("Треугольник ABC является треугольником");
                    else Console.WriteLine("Треугольник ABC не является треугольником");
                    break;

                case 5:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    c = Convert.ToDouble(Console.ReadLine());
                    Calculator5 calculator5 = new Calculator5(a, b, c);
                    double[] arr = calculator5.CalculateA();
                    Console.WriteLine("Ваши числа после изменения:");
                    foreach (int i in arr) Console.Write(i + ", ");
                    break;

                case 6:
                    Console.WriteLine("Введите координату Ax:");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay:");
                    ay = Convert.ToDouble(Console.ReadLine());

                    Calculator6 calculator6 = new Calculator6(ax, ay);
                    Console.WriteLine($"Точка А находится в {calculator6.CalculateA()} четверти");
                    break;

                case 7:
                    Console.WriteLine("Введите координату Ax:");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay:");
                    ay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус окружности:");
                    r = Convert.ToDouble(Console.ReadLine());

                    Calculator7 calculator7 = new Calculator7(ax, ay, r);
                    if (calculator7.CalculateA()) Console.WriteLine("Точка А лежит внутри окружности");
                    else Console.WriteLine("Точка А не лежит внутри окружности");
                    break;

                case 8:
                    Console.WriteLine("Введите сторону A первого треугольника:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону B первого треугольника:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону C первого треугольника:");
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону A второго треугольника:");
                    a1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону B второго треугольника:");
                    b1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сторону C второго треугольника:");
                    c1 = Convert.ToDouble(Console.ReadLine());


                    Calculator8 calculator8 = new Calculator8(a, b, c, a1, b1, c1);
                    if (calculator8.CalculateA()) Console.WriteLine("Площадь первого треугольника больше площади второго");
                    else Console.WriteLine("Площадь второго треугольника больше площади первого");
                    break;

                case 9:
                    Console.WriteLine("Введите сторону квадрата:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус круга:");
                    r = Convert.ToDouble(Console.ReadLine());

                    Calculator9 calculator9 = new Calculator9(a, r);
                    if (calculator9.CalculateA()) Console.WriteLine("Площадь квадрата больше, чем площадь круга");
                    else Console.WriteLine("Площадь круга больше, чем площадь квадрата");
                    break;

                case 10:
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    c = Convert.ToDouble(Console.ReadLine());
                    Calculator10 calculator10 = new Calculator10(a, b, c);
                    arr = calculator10.CalculateA();
                    Console.WriteLine("Ваши числа после изменения:");
                    foreach (int i in arr) Console.Write(i + ", ");
                    break;

                case 11:
                    Console.WriteLine("Введите натуральное число");
                    int ai = Convert.ToInt32(Console.ReadLine());

                    Calculator11 calculator11 = new Calculator11(ai);
                    if (calculator11.CalculateA() == 1) Console.WriteLine("Число является четным");
                    else if (calculator11.CalculateA() == 2) Console.WriteLine("Число оканчивается на 3");
                    else Console.WriteLine("Число не является натуральным или не является четным, или не оканчивается на три");
                    break;

                case 12:
                    Console.WriteLine("Введите координату Ax:");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay:");
                    ay = Convert.ToDouble(Console.ReadLine());

                    Calculator12 calculator12 = new Calculator12(ax, ay);
                    if (calculator12.CalculateA()) Console.WriteLine("Данная точка лежит в первой четверти");
                    else Console.WriteLine("Данная точка не лежит в первой четверти");
                    break;

                case 13:
                    Console.WriteLine("Введите срок договора:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сумму вклада:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator13 calculator13 = new Calculator13(a, b);
                    Console.WriteLine($"Сумма ежемесячных выплат по депозиту: {calculator13.CalculateA()}");
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