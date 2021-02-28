using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= 1000; i += a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
