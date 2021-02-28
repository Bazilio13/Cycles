using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double result = 1;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            
            if (b>=0)
            {
                for (int i = 0; i < b; i++)
                {
                    result *= a;
                }
            }
            else
            {
                for (int i = 0; i > b; i--)
                {
                    result *= (double)a;
                }
                result = 1d / result;
            }
            Console.WriteLine(result);
        }
    }
}
