using System;
using System.Diagnostics;

namespace Lab_7_1_ADS
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Заполняем хэш-таблицу вручную(1) или случайно(2)");
             int l = Convert.ToInt32(Console.ReadLine());
             switch (l)
             {
                case 1:
                    int m;
                    Console.WriteLine("Введите количество данных для хэш-таблицы");
                    int v = Convert.ToInt32(Console.ReadLine());

                    HashTable HTable = new HashTable();
                    HTable.Create_HashTable(v);
                    bool check = false;
                    do
                    {
                        Console.WriteLine("Выберите операцию над хэш-таблицей:\n" + "1 - добавить элемент в хэш-таблицу\n2 - найти элемент в хэш-таблице\n3 - вывести хэш-таблицу\n4 - закончить работу");
                        string pp = Console.ReadLine();
                        switch (pp)
                        {
                            case "1":
                                Console.WriteLine("Введите элемент");
                                m = Convert.ToInt32(Console.ReadLine());
                                HTable.Add(m);
                                check = false;
                                break;
                            case "2":
                                Console.WriteLine("Какой элемент найти?");
                                int x = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(HTable.Search(x));
                                check = false;
                                break;
                            case "3":
                                for (int i=0;i<v; i++)
                                {
                                    Console.WriteLine(HTable.Table[i]);
                                }
                                
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

                    break;
                case 2:

                    Console.WriteLine("Введите количество данных для хэш-таблицы");
                    int n = Convert.ToInt32(Console.ReadLine());

                    HashTable Table = new HashTable();
                    Table.Create_HashTable(n);

                    Random rand = new Random();

                    Stopwatch stopWatch1 = new Stopwatch();
                    stopWatch1.Start();
                    Table.Add(15);
                    for (int i = 1; i < 100; i++)
                    {
                        int t = rand.Next(0, n);
                        Table.Add(t);
                    }
                    stopWatch1.Stop();
                    TimeSpan ts1 = stopWatch1.Elapsed;
                    Console.WriteLine("RunTime " + ts1);



                    for (int i = 100; i < n - 100; i++)
                    {
                        int t = rand.Next(1, n);
                        Table.Add(t);
                    }

                    Stopwatch stopWatch2 = new Stopwatch();
                    stopWatch2.Start();

                    for (int i = 100; i < n - 100; i++)
                    {
                        int t = rand.Next(1, n);
                        Table.Add(t);
                    }
                    stopWatch2.Stop();
                    TimeSpan ts2 = stopWatch2.Elapsed;
                    Console.WriteLine("RunTime " + ts2);


                    Stopwatch stopWatch3 = new Stopwatch();
                    stopWatch3.Start();

                    for (int i = n - 100; i < n; i++)
                    {
                        int t = rand.Next(1, n);
                        Table.Add(t);
                    }
                    stopWatch3.Stop();
                    TimeSpan ts3 = stopWatch3.Elapsed;
                    Console.WriteLine("RunTime " + ts3);


                    Stopwatch stopWatch4 = new Stopwatch();
                    stopWatch4.Start();
                    Console.WriteLine("Введите искомый элемент");
                    int p = Convert.ToInt32(Console.ReadLine());
                    int y = Table.Search(p);
                    if (y != -1)
                    {
                        Console.WriteLine("Элемент найден");
                    }
                    stopWatch4.Stop();
                    TimeSpan ts4 = stopWatch4.Elapsed;
                    Console.WriteLine("RunTime " + ts4);
                    break;
                default:
                    Console.WriteLine("Неверный ввод.Попробуйте ещё раз.");
                    break;
             }
           
        
        }
    }
}
