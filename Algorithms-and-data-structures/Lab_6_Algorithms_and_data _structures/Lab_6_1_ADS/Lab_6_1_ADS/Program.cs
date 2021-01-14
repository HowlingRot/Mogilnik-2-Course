using System;

namespace Lab_6_1_ADS
{
    class Program
    {
        //Реализация стека, очереди и двухсторонней очереди используя массивы
        static void Main(string[] args)
        {

            bool check = false;
            string t,p;
            int n;
            do
            {
                Console.WriteLine("Выберите структуру данных:\n" + "1 - Стек\n2 - Очередь\n3 - Двухсторонняя очередь");
                t = Console.ReadLine();
                switch (t)
                {
                    case "1":
                        Console.WriteLine("Вы выбрали стек");
                        check = true;
                        break;
                    case "2":
                        Console.WriteLine("Вы выбрали очередь");
                        check = true;
                        break;
                    case "3":
                        Console.WriteLine("Вы выбрали двухсторонняя очередь");
                        check = true;
                        break;                  
                    default:
                        Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                        break;
                }
            }
            while (check == false);

            if (t == "1")
            {
                check = false;          
                Console.WriteLine("Введите размер стека");
                n = Convert.ToInt32(Console.ReadLine());
                Stack<int>.CreateStack(n);              
                do
                {
                    Console.WriteLine("Выберите операцию над стеком:\n" + "1 - добавить последний элемент стека\n2 - удалить последний элемент стека\n3 - просмотреть последний элемент стека\n4 - закончить работу");
                    p = Console.ReadLine();
                    switch (p)
                    {
                        case "1":
                            Console.WriteLine("Введите элемент");
                            Stack<int>.Push(Convert.ToInt32(Console.ReadLine()));
                            check = false;
                            break;
                        case "2":
                            Console.WriteLine($"Вы удалили элемент {Stack<int>.Pop()}");
                            check = false;
                            break;
                        case "3":
                            Console.WriteLine($"Последний элемент в стеке {Stack<int>.Peek()}");
                            check = false;
                            break;
                        case "4":                           
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                            break;
                    }
                }
                while (check == false);
            }
            else if (t == "2")
            {
                check = false;
                Console.WriteLine("Введите размер очереди");
                n = Convert.ToInt32(Console.ReadLine());
                Queue<int>.CreateQueue(n);
                do
                {
                    Console.WriteLine("Выберите операцию над очередью:\n" + "1 - добавить элемент в конец очереди\n2 - удалить элемент из начала очереди\n3 - просмотреть очередь\n4 - закончить работу");
                    p = Console.ReadLine();
                    switch (p)
                    {
                        case "1":
                            Console.WriteLine("Введите элемент");
                            Queue<int>.Insert(Convert.ToInt32(Console.ReadLine()));
                            check = false;
                            break;
                        case "2":
                            Console.WriteLine($"Вы удалили элемент {Queue<int>.Remove()}");
                            check = false;
                            break;
                        case "3":
                            Queue<int>.Print();
                            check = false;
                            break;
                        case "4":
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                            break;
                    }
                }
                while (check == false);
            }
            else if (t == "3")
            {
                check = false;
                Console.WriteLine("Введите размер двухсторонней очереди ");
                n = Convert.ToInt32(Console.ReadLine());
                Deque<int>.CreateDeque(n);
                do
                {
                    Console.WriteLine("Выберите операцию над  двухсторонней очередью:\n" + "1 - добавить элемент в конец  двухсторонней очереди\n2 - добавить элемент в начало двухсторонней очереди\n3 - удалить элемент из начала двухсторонней очереди\n4 - удалить элемент из конца двухсторонней очереди\n5 - просмотрите двухстороннюю очередь\n6 - закончить работу");
                    p = Console.ReadLine();
                    switch (p)
                    {
                        case "1":
                            Console.WriteLine("Введите элемент");
                            Deque<int>.AddFirst(Convert.ToInt32(Console.ReadLine()));
                            check = false;
                            break;
                        case "2":
                            Console.WriteLine("Введите элемент");
                            Deque<int>.AddLast(Convert.ToInt32(Console.ReadLine()));
                            check = false;
                            break;
                        case "3":
                            Console.WriteLine($"Вы удалили элемент {Deque<int>.RemoveFirst()}");
                            check = false;
                            break;
                        case "4":
                            Console.WriteLine($"Вы удалили элемент {Deque<int>.RemoveLast()}"); 
                            check = false;
                            break;
                        case "5":
                            Deque<int>.Print();
                            check = false;
                            break;
                        case "6":
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                            break;
                    }
                }
                while (check == false);
            }

        }
    }
}
