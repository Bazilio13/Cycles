using System;

namespace HW11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int i2 = 0;
            int even;
            int odd;
            for (int i = 1; i <= a; i++)
            {
                even = 0;
                odd = 0;
                i2 = i;
                while (i2 !=0)
                {
                    if (i2 % 2 == 1)
                    {
                        odd += i2 % 10;
                    }
                    else
                    {
                        even += i2 % 10;
                    }
                    i2 /= 10;
                }
                if (even > odd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
