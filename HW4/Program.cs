using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i ==0)
                {
                    result = i;
                }
            }
            Console.WriteLine(result);
        }
    }
}
