using System;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int x = 0;
            int border1 = 1;
            int border2 = a;
            double check = Math.Round(Math.Pow((double)a, 1d / 3d));

            if (Math.Pow(check, 3) == a)
            {
                while (x * x * x != a)
                {
                    x = (border1 + border2) / 2;
                    if (x * x * x == a)
                    {
                        break;
                    }
                    else
                    {
                        if (x * x * x < a)
                        {
                            border1 = x;
                        }
                        else
                        {
                            border2 = x;
                        }
                    }
                }
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Введенное число не является кубом целого числа");
            }
            


        }
    }
}
