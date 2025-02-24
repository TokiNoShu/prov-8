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
                    Console.WriteLine("Введите координату Ax:");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay:");
                    ay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Bx:");
                    bx = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату By:");
                    by = Convert.ToDouble(Console.ReadLine());


                    Calculator15 calculator15 = new Calculator15(ax, ay, bx, by);
                    if (calculator15.CalculateA()) Console.WriteLine("Точка A раполагается на более удалённом расстоянии");
                    else Console.WriteLine("Точка B раполагается на более удалённом расстоянии");
                    break;

                case 16:
                    Console.WriteLine("Введите координату Ax:");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay:");
                    ay = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус окружности:");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус окружности:");
                    r1 = Convert.ToDouble(Console.ReadLine());

                    Calculator16 calculator16 = new Calculator16(ax, ay, r, r1);
                    if (calculator16.CalculateA()) Console.WriteLine("Данная точка лежит в окружности тора");
                    else Console.WriteLine("Данная точка не лежит в окружности тора");
                    break;

                case 17:
                    Console.WriteLine("Введите координату Ax:");
                    ax = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите координату Ay:");
                    ay = Convert.ToDouble(Console.ReadLine());

                    Calculator17 calculator17 = new Calculator17(ax, ay);
                    if (calculator17.CalculateA()) Console.WriteLine("Данная точка лежит в 4 четверти");
                    else Console.WriteLine("Данная точка не лежит в 4 четверти");
                    break;

                case 18:
                    Console.WriteLine("Введите значение стороны треугольника А:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны треугольника B:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите значение стороны треугольника C:");
                    c = Convert.ToDouble(Console.ReadLine());

                    Calculator18 calculator18 = new Calculator18(a, b, c);
                    if (calculator18.CalculateA()) Console.WriteLine("Треугольник ABC является равнобедренным");
                    else Console.WriteLine("Треугольник ABC не является равнобедренным");
                    break;

                case 19:
                    Console.WriteLine("Введите первое число:");
                    ai = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int bi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите третье число:");
                    int ci = Convert.ToInt32(Console.ReadLine());
                    Calculator19 calculator19 = new Calculator19(ai, bi, ci);
                    if (calculator19.CalculateA()) Console.WriteLine("Данные числа являются тройкой пифагора");
                    else Console.WriteLine("Данные числа не являются тройкой пифагора");
                    break;

                case 20:
                    a = 1;
                    b = 10;

                    Calculator20 calculator20 = new Calculator20(a, b);
                    Console.WriteLine($"Объёмная скорость 1: {a} л/с = {calculator20.LiterSpeed():F6} м³/с");
                    Console.WriteLine($"Объёмная скорость 2: {b} м³/мин = {calculator20.MeterSpeed():F6} м³/с");
                    if (calculator20.CalculateA()) Console.WriteLine("Первая объёмная скорость больше");
                    else Console.WriteLine("Вторая объёмная скорость больше");
                    break;

                case 21:
                    Console.WriteLine("Введите сторону квадрата:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус круга:");
                    r = Convert.ToDouble(Console.ReadLine());

                    Calculator21 calculator21 = new Calculator21(a, r);
                    if (calculator21.CalculateA()) Console.WriteLine("Круг уместится в квадрате");
                    else Console.WriteLine("Квадрат уместится в круге");
                    break;

                case 22:
                    Console.WriteLine("Введите массу первого объекта:");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите объём первого объекта:");
                    v = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите массу второго объекта:");
                    m1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите объём второго объекта:");
                    v1 = Convert.ToDouble(Console.ReadLine());

                    Calculator22 calculator22 = new Calculator22(m, v, m1, v1);
                    if (calculator22.CalculateA()) Console.WriteLine("Плотность первого тела больше, чем плотность второго тела");
                    else Console.WriteLine("Плотность второго тела больше, чем плотность первого");
                    break;

                case 23:
                    Console.WriteLine("Введите скорость в км/ч:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите скорость в м/сек:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator23 calculator23 = new Calculator23(a, b);
                    if (calculator23.CalculateA()) Console.WriteLine("Скорость в км/ч больше, чем скорость в м/сек");
                    else Console.WriteLine("Скорость в м/сек больше, чем скорость в км/ч");
                    break;

                case 24:
                    Console.WriteLine("Введите сторону равностороннего треугольника:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите радиус круга:");
                    r = Convert.ToDouble(Console.ReadLine());

                    Calculator24 calculator24 = new Calculator24(a, r);
                    if (calculator24.CalculateA()) Console.WriteLine("Круг уместится в треугольнике");
                    else Console.WriteLine("Треугольник уместится в круге");
                    break;

                case 25:
                    Console.WriteLine("Введите сопротивление 1 участка:");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите напряжение 1 участка:");
                    u = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите сопротивление 2 участка:");
                    r1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите напряжение 2 участка:");
                    u1 = Convert.ToDouble(Console.ReadLine());

                    Calculator25 calculator25 = new Calculator25(r, u, r1, u1);
                    if (calculator25.CalculateA()) Console.WriteLine("Меньший ток течёт по первому участку");
                    else Console.WriteLine("Меньший ток течёт по второму участку");
                    break;

                case 26:
                    mv = 4.86 * Math.Pow(10, 27);
                    rv = 6175;
                    ms = 5.68 * Math.Pow(10, 29);
                    rs = 57750;
                    Calculator26 calculator26 = new Calculator26(mv, rv, ms, rs);
                    if (calculator26.CalculateA()) Console.WriteLine("у Венеры наибольшее ускорение силы тяжести");
                    else Console.WriteLine("у Сатурна наибольшее ускорение силы тяжести");
                    break;

                case 27:
                    Console.WriteLine("Введите текущий час в двадцатичетрехчасовом формате");
                    a = Convert.ToDouble(Console.ReadLine());

                    Calculator27 calculator27 = new Calculator27(a);
                    if (calculator27.CalculateA() == 0) Console.WriteLine("Время не может быть больше 24 или меньше 0");
                    else if (calculator27.CalculateA() == 1) Console.WriteLine("Сейчас время от полуночи до полудня(PM)");
                    else Console.WriteLine("Сейчас время от полудня до полуночи(AM)");
                    break;

                case 28:
                    Console.WriteLine("Введите долготу:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите широту:");
                    b = Convert.ToDouble(Console.ReadLine());

                    Calculator28 calculator28 = new Calculator28(a);
                    if (calculator28.CalculateA()) Console.WriteLine("Данная координата находится в восточном полушарии");
                    else Console.WriteLine("Данная координата находится в западном полушарии");
                    break;

                case 29:
                    a = 8.14 * Math.Pow(10, 12);
                    b = 103;

                    Calculator29 calculator29 = new Calculator29(a, b);
                    if (calculator29.CalculateA()) Console.WriteLine("Сириус ближе чем Арктур");
                    else Console.WriteLine("Арктур ближе чем Сириус");
                    break;

                case 30:
                    Console.WriteLine("Введите натуральное число:");
                    ai = Convert.ToInt32(Console.ReadLine());

                    Calculator30 calculator30 = new Calculator30(ai);
                    if (calculator30.CalculateA() == 1) Console.WriteLine("Число является четным");
                    else if (calculator30.CalculateA() == 2) Console.WriteLine("Число оканчивается на 7");
                    else Console.WriteLine("Число не является натуральным или не является четным, или не оканчивается на 7");
                    break;
            }
        }
    }
}