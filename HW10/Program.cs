using System;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            string result = "";
            while (a != 0)
            {
                result =  result + (a % 10);
                a /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
