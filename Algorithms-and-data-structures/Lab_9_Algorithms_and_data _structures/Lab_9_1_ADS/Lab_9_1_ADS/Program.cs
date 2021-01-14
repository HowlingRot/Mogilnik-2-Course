using System;

namespace Lab_9_1_ADS
{
    class Program
    {
        static void Main(string[] args)
        {
            BinomialHeap heap = new BinomialHeap();
            bool check = false;
            do
            {
                Console.WriteLine("Выберите действие с биноминальной кучей:\n1 - добавить элемент\n2 - удалить минимальный элемент\n3 - вывод кучи\n4 - выход ");
                string p = Console.ReadLine();
                switch (p)
                {
                    case "1":
                        Console.WriteLine("Какой элемент добавить?");
                        heap.Add(Convert.ToInt32(Console.ReadLine()));
                        check = false;
                        break;
                    case "2":
                        heap.DeleteMin();
                        heap.Print();
                        check = false;
                        break;
                    case "3":
                        heap.Print();
                        check = false;
                        break;
                    case "4":
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                        break;
                }
            } while (check == false);

        }
    }
}
    

