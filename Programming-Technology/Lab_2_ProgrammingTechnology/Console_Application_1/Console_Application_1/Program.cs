using System;

namespace Console_Application_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x0:");
                double x0 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите xn:");
                double xn = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите dx:");
                double dx = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите a:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите b:");
                double b = Convert.ToDouble(Console.ReadLine());
                if(CheckInterval(x0, xn, dx) == true)
                {
                    while (x0 <= xn)
                    {

                        double Operation1 = Math.Pow(x0, 3) + Math.Pow(b, 3);
                        double Operation2 = Math.Pow(Operation1, 1.666666);
                        double Operation3 = a * Operation2;
                        Console.WriteLine(Operation3);
                        x0 += dx;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }

            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
            }
        }

        static bool CheckInterval(double x0, double xn, double dx)
        {
            if (x0 <= xn && dx > 0)
                return true;
            if (x0 >= xn && dx < 0)
                return true;
            return false;
        }
    }
}
