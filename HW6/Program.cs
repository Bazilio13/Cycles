using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int result = 0;
            int tmp;
            for (int i = 0; i < n; i++)
            {
                result = n2;
                tmp = n1;
                n1 = n2;
                n2 = tmp + n2;
            }
            Console.WriteLine(result);

        }
    }
}
