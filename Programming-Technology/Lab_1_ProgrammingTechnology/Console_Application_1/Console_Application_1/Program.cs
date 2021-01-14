using System;

namespace Console_Application_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                double y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите z:");
                double z = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Ответ:{MyFunction(x, y, z)}");
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
            }
        }

        static double MyFunction(double x, double y, double z)
        {
            double Operation1 = Math.Sin(x) + Math.Pow(y, 2) + Math.Pow(Math.E, Math.Sin(z));
            double Operation2 = Math.Log(Math.Pow(z, 2), Math.E) - Math.Sin((Math.PI * Math.Pow(x, 2)) / 4);
            double Operation3 = Math.Pow(Operation1, 2) + Math.Pow(Operation2, 3);
            double k = Math.Pow(Operation3, 0.3333333333333);
            return Math.Round(k, 4);
        }

    }
}


