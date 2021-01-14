using System;
using System.Diagnostics;


namespace Lab_4_1_ADS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            string n, t, p;
            int nt = 0;
            while (true) {
                Sorter.Compare_Times = 0;
                Sorter.Swap_Times=0;
                do
                {
                    Console.WriteLine("Выберите вид сортировки:\n1 - сортировка выбором\n2 - сортировка вставками\n3 - сортировка обменом\n4 - быстрая сортировка\n5 - гибридная сортировка(TimSort)");
                    t = Console.ReadLine();
                    switch (t)
                    {
                        case "1":
                            Console.WriteLine("Вы выбрали сортировкy выбором");
                            check = true;
                            break;
                        case "2":
                            Console.WriteLine("Вы выбрали сортировку вставками");
                            check = true;
                            break;
                        case "3":
                            Console.WriteLine("Вы выбрали сортировку обменом");
                            check = true;
                            break;
                        case "4":
                            Console.WriteLine("Вы выбрали быструю сортировку");
                            check = true;
                            break;
                        case "5":
                            Console.WriteLine("Вы выбрали гибридную сортировку");
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                            break;
                    }
                }
                while (check == false);

                check = false;

                do
                {
                    Console.WriteLine("Выберите количество элементов:\n1 - 10\n2 - 100\n3 - 1000\n4 - 10 000");
                    n = Console.ReadLine();
                    switch (n)
                    {
                        case "1":
                            Console.WriteLine("Вы выбрали 10 элементов");
                            nt = 10;
                            check = true;
                            break;
                        case "2":
                            Console.WriteLine("Вы выбрали 100 элементов");
                            nt = 100;
                            check = true;
                            break;
                        case "3":
                            Console.WriteLine("Вы выбрали 1000 элементов");
                            nt = 1000;
                            check = true;
                            break;
                        case "4":
                            Console.WriteLine("Вы выбрали 10 000 элементов");
                            nt = 10000;
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                            break;
                    }
                }
                while (check == false);

                check = false;


                do
                {
                    Console.WriteLine("Выберите в каком порядке находятся элементы:\n1 - упорядоченны\n2 - упорядоченны в обратном порядке\n3 - расположены случайно");
                    p = Console.ReadLine();
                    switch (p)
                    {
                        case "1":
                            Console.WriteLine("Элементы упорядочены");
                            check = true;
                            break;
                        case "2":
                            Console.WriteLine("Элементы упорядочены в обратном порядке");
                            check = true;
                            break;
                        case "3":
                            Console.WriteLine("Расстановка элементов случайна");
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                            break;
                    }
                }
                while (check == false);

                int[] Array = CreateArray(nt, p);
                Stopwatch stopWatch1 = new Stopwatch();
                if (t == "1")
                {
                    stopWatch1.Start();
                    Sorter.Sort_Selection(Array);
                    stopWatch1.Stop();
                    TimeSpan ts1 = stopWatch1.Elapsed;
                    Console.WriteLine($"Время сортировки - {ts1}");
                }
                else if (t == "2")
                {
                    stopWatch1.Start();
                    Sorter.Sort_Insertion(Array);
                    stopWatch1.Stop();
                    TimeSpan ts1 = stopWatch1.Elapsed;
                    Console.WriteLine($"Время сортировки - {ts1}");
                }
                else if (t == "3")
                {
                    stopWatch1.Start();
                    Sorter.Sort_Swap(Array);
                    stopWatch1.Stop();
                    TimeSpan ts1 = stopWatch1.Elapsed;
                    Console.WriteLine($"Время сортировки - {ts1}");
                }
                else if (t == "4")
                {
                    stopWatch1.Start();
                    Sorter.Quick_Sort(Array, 0, nt - 1);
                    stopWatch1.Stop();
                    TimeSpan ts1 = stopWatch1.Elapsed;
                    Console.WriteLine($"Время сортировки - {ts1}");
                }
                else if (t == "5")
                {
                    stopWatch1.Start();
                    Sorter.TimSort(Array);
                    stopWatch1.Stop();
                    TimeSpan ts1 = stopWatch1.Elapsed;
                    Console.WriteLine($"Время сортировки - {ts1}");
                }
                Console.WriteLine($"Число операций сравнения - {Sorter.Compare_Times}");
                Console.WriteLine($"Число операций обмена - {Sorter.Swap_Times}");
            }
        }

        static int[] CreateArray(int n,string p)
        {           
            int[] Array = new int[n];
            if (p == "1")
            {
                for (int i = 0; i < n; i++)
                {
                    Array[i] = i;
                }
                return Array;
            }
            else if(p=="2"){
                int j = 0;
                for (int i = n; i > 0; i--, j++)
                {
                    Array[j] = i;
                }
                return Array;
            }
            else if (p == "3")
            {
                Random rand = new Random();
                int element;
                for (int i = 0; i < n; i++)
                {
                    element = rand.Next(0, n);
                    Array[i] = element;
                }
                return Array;
            }
            return Array;
        }

    }
}
