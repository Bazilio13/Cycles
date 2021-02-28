using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            if (a <= b)
            { 
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        result += i;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
