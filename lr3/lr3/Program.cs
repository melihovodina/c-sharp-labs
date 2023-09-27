using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

first();
second();
void first()
{
    double x, y, z, q;
    Console.Write("x = ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("y = ");
    y = Convert.ToDouble(Console.ReadLine());
    Console.Write("z = ");
    z = Convert.ToDouble(Console.ReadLine());
    q = Math.Max(x + y + z, x * y * z) / Math.Min(x + y + z, x * y * z);
    Console.WriteLine(q);
}
void second()
{
    double arg= -0.5;
    double now, past = 0;
    int num = 1;
    double max_res;
    double min_res;
    while(arg <= 2.5)
    { 
        double x = arg;
        double y = (1 - Math.Pow(x, 2)/4) * Math.Cos(x) - x/2 * Math.Sin(x);
        now = y;
        if(num > 1)
        {
            max_res = Math.Max(past, now);
            min_res = Math.Min(past, now);
            if (past > now) 
            {
                Console.WriteLine($"{num}. x = {arg}; y = {y}; Функция убывает");
            }
            else
            {
                Console.WriteLine($"{num}. x = {arg}; y = {y}; Функция возрастает");
            }
        }
        else
        {
            Console.WriteLine($"{num}. x = {arg}; y = {y}");
        }
        past = now;
        num++;
        arg += 0.2;
    }
}