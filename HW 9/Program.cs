using System;

namespace HW_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (a != 0)
            {
                if (a % 2 == 1)
                {
                    counter += 1;
                }
                a /= 10;
            }
            Console.WriteLine(counter);
        }
    }
}
