using System;

namespace Lab_6_2_ADS
{
    class Program
    {
        //Программа, моделирующая жизнь на кухне
        static void Main(string[] args)
        {



            //Создаём элементы кухни
            int n = 100;

            Stack<int> Dinner_Table = new Stack<int>();
            Dinner_Table.CreateStack(n);

            Queue<int> Dishwasher_1 = new Queue<int>();
            Dishwasher_1.CreateQueue(n);
            Queue<int> Dishwasher_2 = new Queue<int>();
            Dishwasher_2.CreateQueue(n);

            Deque<int> Rack = new Deque<int>();
            Rack.CreateDeque(n);


            //
            for(int i = 0; i < 5; i++)
            {
                Dinner_Table.Push(1);
            }

            for (int i = 0; i < 7; i++)
            {
                Dishwasher_1.Insert(1);
            }

            for (int i = 0; i < 8; i++)
            {
                Dishwasher_2.Insert(1);
            }

            for (int i = 0; i < 5; i++)
            {
                Rack.AddLast(1);
            }

            //

            while (true)
            {
                Random rand = new Random();
                int t = rand.Next(1, 6);
                int p,y;
                switch (t)
                {
                    case 1:
                        Console.WriteLine("Из пустоты в горе грязной посуды появляется ещё одна тарелка.");
                        Dinner_Table.Push(1);
                        System.Threading.Thread.Sleep(3000);
                        break;
                    case 2:
                        y = Dishwasher_1.rear;
                        for (int i = 0; i < y; i++)
                        {
                            Dishwasher_1.Remove();
                        }

                        p = rand.Next(1, Dinner_Table.count);
                        Console.WriteLine($"Хозяйка загружает {p} грязных тарелок в первую секцию посудомойки и достаёт всю чистую");
                        for (int i = 0; i < p; i++)
                        {
                            Dishwasher_1.Insert(1);
                        }

                        for (int i = 0; i < y; i++)
                        {
                            Rack.AddFirst(1);
                        }
                        System.Threading.Thread.Sleep(3000);

                        break;
                    case 3:
                        y = Dishwasher_2.rear;
                        for (int i = 0; i < y; i++)
                        {
                            Dishwasher_2.Remove();
                        }

                        p = rand.Next(1, Dinner_Table.count);
                        Console.WriteLine($"Хозяйка загружает {p} грязных тарелок во вторую секцию посудомойки и достаёт всю чистую");
                        for (int i = 0; i < p; i++)
                        {
                            Dishwasher_2.Insert(1);
                        }

                        for (int i = 0; i < y; i++)
                        {
                            Rack.AddLast(1);
                        }
                        System.Threading.Thread.Sleep(3000);

                        break;
                    case 4:
                        p = rand.Next(1, Rack.rear);
                        Console.WriteLine($"Друзья загрязнили {p} тарелок с полки");
                        for (int i = 0; i < p; i++)
                        {
                            Rack.RemoveLast();
                        }

                        for (int i = 0; i < p; i++)
                        {
                            Dinner_Table.Push(1);
                        }
                        System.Threading.Thread.Sleep(3000);

                        break;
                }

                Console.WriteLine($"В первой секции посудомойки {Dishwasher_1.rear} экземпляров посуды");
                Console.WriteLine($"В второй секции посудомойки {Dishwasher_2.rear} экземпляров посуды");
                Console.WriteLine($"На полке блестит {Rack.rear} экземпляров посуды");
                if (Dinner_Table.count != 0)
                {
                    Console.WriteLine("В горе грязной посуды ещё что-то есть.");
                }
                System.Threading.Thread.Sleep(3000);

            }
        }
    }
}
