using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int i;
            i = 1;
            while (i*i < a)
            {
                i += 1;
            }
            Console.WriteLine(i-1);
        }
    }
}
