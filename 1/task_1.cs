using System;
using static System.Math;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = "); double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = "); double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z = "); double z = Convert.ToDouble(Console.ReadLine());

            double a = 0, b = 0;
            if (((Pow(x, 2) * y) - (Sign(Pow(x, 2) - (y * Pow(z, 3))) * Pow(Abs(Pow(x, 2) - (y * Pow(z, 3))), 1.0 / 3.0))) == 0)
                Console.WriteLine("Ошибка");
            else
                a = (x + y - z) / ((Pow(x, 2) * y) - (Sign(Pow(x, 2) - (y * Pow(z, 3))) * Pow(Abs(Pow(x, 2) - (y * Pow(z, 3))), 1.0 / 3.0)));
            if(a == 0)
                Console.WriteLine("Ошибка");
            else
            {
                b = Cos((x * y + Pow(y, 2)) / Pow(a, 2));
                Console.WriteLine("a = " + a + "; b = " + b);
            }
        }
    }
}
