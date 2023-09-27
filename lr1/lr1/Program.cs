using System;
Console.Write("Введите коэффициент a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение z: ");
double z = Convert.ToDouble(Console.ReadLine());
double x;
if (z < 1)
    x = Math.Pow(z, 3) + 0.2;
else
    x = z + Math.Log(z);
double phi;
Console.Write("Выберите функцию ϕ(x): 1 - 2x, 2 - x^2, 3 - x/3: ");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        phi = 2 * x;
        Console.WriteLine($"Вы выбрали функцию f(x) = 2x");
        break;
    case 2:
        phi = Math.Pow(x, 2);
        Console.WriteLine($"Вы выбрали функцию f(x) = x^2");
        break;
    case 3:
        phi = x / 3;
        Console.WriteLine($"Вы выбрали функцию f(x) = x/3");
        break;
    default:
        Console.WriteLine("Неверный выбор функции f(x). По умолчанию используется ϕ(x) = 2x");
        phi = 2 * x;
        break;
}
double y = 2 * a * Math.Pow(Math.Cos(Math.Pow(x, 2)), 3) + Math.Pow(Math.Sin(Math.Pow(x, 3)), 2) - b * phi;
Console.WriteLine($"Значение y: {y}");