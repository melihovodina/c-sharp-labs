using System;
first();
second();
third();
void first()
{
    double x1, x2, x3, y1, y2, y3, a, b, c, P, S;
    Console.Write("x1 = ");
    x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("x2 = ");
    x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("x3 = ");
    x3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("y1 = ");
    y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("y2 = ");
    y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("y3 = ");
    y3 = Convert.ToDouble(Console.ReadLine());
    a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
    c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
    P = (a + b + c) / 2;
    S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
    Console.WriteLine($"Периметр: {P}");
    Console.WriteLine($"Площадь: {S}");
}
void second()
{
    Console.Write("Введите длину окружности L: ");
    double L = Convert.ToDouble(Console.ReadLine());
    double R = L / (2 * Math.PI);
    double S = Math.PI * Math.Pow(R, 2);
    Console.WriteLine($"Радиус R: {R}");
    Console.WriteLine($"Площадь S: {S}");
}

void third()
{
    Console.Write("Введите радиус основания R: ");
    double R = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите образующую L: ");
    double L = Convert.ToDouble(Console.ReadLine());
    double S = Math.PI * R * L;
    Console.WriteLine($"Площадь осевого сечения: {S}");
}

