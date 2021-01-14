using System;

namespace Console_Application_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            string n;
            double x, y, z;
            do 
            {
                Console.WriteLine("Выберите функцию:\n" + "1 - sh(x)\n2 - x^2\n3 - e^x");
                n = Console.ReadLine();
                switch (n)
                {
                    case "1":
                        Console.WriteLine("Вы выбрали sh(x)");
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("Вы выбрали x^2");
                        check = true;
                        break;
                    case "3":
                        Console.WriteLine("Вы выбрали e^x");
                        check = true;
                        break;
                    default :
                        Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                        break;
                }
            }
            while (check==false);
            try
            {
                do
                {
                    Console.WriteLine("Введите x(x!=0):");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите y:");
                    y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите z:");
                    z = Convert.ToDouble(Console.ReadLine());
                    if (x == 0) { Console.WriteLine("Неверный ввод.Попробуйте ещё раз."); };
                } while (x == 0);
                Console.WriteLine($"Ответ:{MyFunction(x, y, z, n)}");
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
            }


        }
        static double MyFunction(double x, double y, double z, string n)
        {
            double Operation1=0;
            switch(n)
            {
                case "1":
                    Operation1 = (Math.Exp(x) - Math.Exp(-x)) / 2;
                    break;
                case "2":
                    Operation1 = Math.Pow(x, 2);
                    break;
                case "3":
                    Operation1 = Math.Pow(Math.E, x);
                    break;
            }

            double Operation2 = (y + z) / x;

            double Operation3 = x * y * z;

            double Operation4 = Math.Max(Operation1- Operation2, Operation3);

            double Operation5 = Math.Min(Operation1 - Operation2, Operation3);

            double u = Operation4 / Operation5;

            return u;
        }
    }
}
