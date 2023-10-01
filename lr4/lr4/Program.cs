using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
    internal class Program
    {
        public static double Fact(double n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
        static double Y(double x)
        {
            return Math.Cos(x);
        }
        static double S(double x, int n)
        {
            double S = 0;
            for (double k = 0; k < n; k++)
            {
                S += Math.Pow((-1), k) * (Math.Pow(x, 2 * k) / Fact(2 * k));
            }
            return S;
        }
        static int GCD(int M, int N)
        {
            if (M % N == 0)
                return N;
            else
                return GCD(N, M % N);
        }
        static void Main()
        {
            double a, b, h, x;
            int n;
            Console.Write("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение h: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение n: ");
            n = Convert.ToInt32(Console.ReadLine());
            x = a;
            while (x < b)
            {
                Console.WriteLine($"x:{x:0.0} Y:{Y(x):0.0000} S:{S(x, n):0.0000}");
                x += h;
            }
            Console.Write("Введите число M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("НОД чисел " + M + " и " + N + " равен " + GCD(M, N));
        }
    }
}
