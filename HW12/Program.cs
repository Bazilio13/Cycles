using System;

namespace HW12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int tmp;
            int tmpb;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            string result = "НЕТ";
            while (a != 0)
            {
                tmp = a % 10;
                tmpb = b;
                while (tmpb != 0)
                {
                    if (tmp == tmpb % 10)
                    {
                        result = "ДА";
                        break;
                    }
                    tmpb /= 10;
                }
                if (result == "ДА")
                {
                    break;
                }    
                a /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
