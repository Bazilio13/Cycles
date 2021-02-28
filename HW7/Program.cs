using System;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            if (a == 0 || b == 0)
            {
                if (a == b)
                {
                    Console.WriteLine("оба числа равны 0, любое число является для них общим делителем");
                }
                else
                {
                    if (b > a)
                    {
                        a = b;
                    }
                }    
            }
            else
            {
                while (a != b)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
            }
            Console.WriteLine(a);
        }
    }
}
