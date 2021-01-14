using System;
using System.IO;
using System.Diagnostics;

namespace Lab_5_1_ADS
{
    class Program
    {
        static int compare;
        static int toFileInfo;

        static void Main(string[] args)
        {
            Stopwatch stopWatch1 = new Stopwatch();
            Stopwatch stopWatch2 = new Stopwatch();
            Stopwatch stopWatch3 = new Stopwatch();
            TimeSpan T1 = TimeSpan.Parse("0");
            TimeSpan T2 = TimeSpan.Parse("0");
            TimeSpan T3 = TimeSpan.Parse("0");
            int n = 4;
            try
            {
                FileInfo data = new FileInfo("A:\\Works\\Laboratory\\Algorithms_and_data _structures\\Lab_5_Algorithms_and_data _structures\\Data.txt");
                StreamWriter Writer = new StreamWriter(data.OpenWrite());
                Random random = new Random();
                Console.WriteLine("Введите количество элементов: ");
                int k = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < k; i++)
                {
                    Writer.Write(Convert.ToString(Math.Round(Convert.ToDouble(random.Next(1,999) * 20) - 10)) + "\n");
                }
                Writer.Close();

                for (int i = 0; i < 100; i++)
                {
                   
                    stopWatch1.Start();                   
                    Merger(data, n);
                    stopWatch1.Stop();
                    TimeSpan ts1 = stopWatch1.Elapsed;
                    T1 += ts1;
                }
                Console.WriteLine("Случайно");
                Console.WriteLine("Время: " + T1 / 100 / 1000000);
                Console.WriteLine("Сравнения: " + compare / 100);
                Console.WriteLine("Обращений к файлам: " + toFileInfo / 100);

   
                compare = 0;
                toFileInfo = 0;
                for (int i = 0; i < 100; i++)
                {
                  
                    stopWatch2.Start();
                    Merger(data, n);
                    stopWatch1.Stop();
                    TimeSpan ts2 = stopWatch2.Elapsed;
                    T2 += ts2;
                }
                Console.WriteLine("По возрастанию");
                Console.WriteLine("Время: " + T2 / 100 / 1000000);
                Console.WriteLine("Сравнения: " + compare / 100);
                Console.WriteLine("Обращений к файлам: " + toFileInfo / 100);

                MergerBot(data, n);
                compare = 0;
                toFileInfo = 0;
                for (int i = 0; i < 100; i++)
                {
                    stopWatch3.Start();
                    Merger(data, n);
                    stopWatch3.Stop();
                    TimeSpan ts3 = stopWatch3.Elapsed;
                    T3 += ts3;
                }
                Console.WriteLine("По убыванию");
                Console.WriteLine("Время: " + T3 / 100 / 1000000);
                Console.WriteLine("Сравнения: " + compare / 100);
                Console.WriteLine("Обращений к файлам: " + toFileInfo / 100);

            }
            catch (IOException e)
            {
                e.GetBaseException();
            }
        }

        public static void MergerBot(FileInfo data, int n)
        {
            try
            {
                String str;
                int t = 1;
                //первый проход
                StreamReader reader0 = new StreamReader(data.OpenRead());
                StreamWriter Writer0;
                String numb0;
                while ((numb0 = reader0.ReadLine()) != null)
                {
                    toFileInfo++;
                    str = "FileInfo" + t + ".txt";
                    Writer0 = new StreamWriter(str, true);
                    Writer0.Write(numb0 + "\n");
                    toFileInfo++;
                    t++;
                    if (t == n + 1) t = 1;
                    Writer0.Close();
                }
                reader0.Close();

                //слияние
                int seriesMain = 1;
                int[] seriesNumbs = new int[n];
                String[] numbs = new String[n];
                String FileInfo;
                int fReader = 1;
                int fWriter = n + 1;
                StreamReader[] readers;
                StreamWriter[] Writers;
                FileInfo[] FileInfos;
                for (; ; )
                {
                    readers = new StreamReader[n];
                    Writers = new StreamWriter[n];
                    FileInfos = new FileInfo[n];
                    for (int i = 0, fR = fReader, fW = fWriter; i < n; i++, fR++, fW++)
                    {
                        FileInfo = "FileInfo" + fR + ".txt";
                        FileInfos[i] = new FileInfo(FileInfo);
                        readers[i] = new StreamReader(FileInfos[i].OpenRead());
                        FileInfo = "FileInfo" + fW + ".txt";
                        Writers[i] = new StreamWriter(FileInfo, true);
                    }

                    for (int i = 0; ;)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            numbs[j] = readers[j].ReadLine();
                            toFileInfo++;
                            compare++;
                            if (numbs[j] == null)
                            {
                                seriesNumbs[j] = seriesMain + 1;
                            }
                            else
                            {
                                seriesNumbs[j] = 1;
                            }
                        }

                        int count = 0;
                        for (int j = 0; j < n; j++)
                        {
                            compare++;
                            if (numbs[j] == null)
                            {
                                count++;
                            }
                        }
                        if (count == n)
                        {
                            break;
                        }

                        for (; ; )
                        {
                            String minNumb = null;
                            int minIndex = -1;
                            for (int j = 0; j < n; j++)
                            {
                                compare++;
                                if (numbs[j] != null)
                                {
                                    minNumb = numbs[j];
                                    minIndex = j;
                                    break;
                                }
                            }
                            for (int j = minIndex + 1; j < n; j++)
                            {
                                compare++;
                                if (numbs[j] == null)
                                {
                                    continue;
                                }
                                else
                                {
                                    compare++;
                                    if (Double.Parse(numbs[j]) > Double.Parse(minNumb))
                                    {
                                        minNumb = numbs[j];
                                        minIndex = j;
                                    }
                                }
                            }

                            toFileInfo++;
                            Writers[i].Write(minNumb + "\n");
                            compare++;
                            if (seriesNumbs[minIndex] < seriesMain)
                            {
                                toFileInfo++;
                                numbs[minIndex] = readers[minIndex].ReadLine();
                                compare++;
                                if (numbs[minIndex] == null)
                                {
                                    seriesNumbs[minIndex] = seriesMain + 1;
                                }
                                else
                                {
                                    seriesNumbs[minIndex]++;
                                }
                            }
                            else
                            {
                                numbs[minIndex] = null;
                                seriesNumbs[minIndex] = seriesMain + 1;
                            }

                            count = 0;
                            for (int j = 0; j < n; j++)
                            {
                                if (seriesNumbs[j] > seriesMain)
                                {
                                    count++;
                                }
                            }
                            if (count == n)
                            {
                                break;
                            }
                        }

                        i++;
                        if (i == n)
                        {
                            i = 0;
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Writers[i].Close();
                        readers[i].Close();
                    }

                    FileInfo = "FileInfo" + (fWriter + 1) + ".txt";
                    StreamReader readerBuff = new StreamReader(FileInfo);
                    toFileInfo++;
                    String numbBuff = readerBuff.ReadLine();
                    readerBuff.Close();
                    if (numbBuff == null)
                    {
                        break;
                    }


                    seriesMain = seriesMain * n;
                    if (fWriter == n + 1)
                    {
                        fWriter = 1;
                    }
                    else
                    {
                        fWriter = n + 1;
                    }
                    if (fReader == n + 1)
                    {
                        fReader = 1;
                    }
                    else
                    {
                        fReader = n + 1;
                    }
                    for (int i = 0, k = fWriter; i < n; i++, k++)
                    {
                        FileInfos[i].Delete();
                    }
                }

                //перезапись
                data.Delete();
                FileInfo = "FileInfo" + fWriter + ".txt";
                StreamReader readerLast = new StreamReader(FileInfo);
                StreamWriter WriterLast = new StreamWriter(data.OpenWrite());
                String numbLast;
                while ((numbLast = readerLast.ReadLine()) != null)
                {
                    WriterLast.Write(numbLast + "\n");
                }
                readerLast.Close();
                WriterLast.Close();

                for (int i = 1; i <= 2 * n; i++)
                {
                    FileInfo = "FileInfo" + i + ".txt";
                    FileInfo FileInfoDel = new FileInfo(FileInfo);
                    FileInfoDel.Delete();
                }

            }
            catch (IOException e)
            {
               Console.WriteLine(System.Environment.StackTrace);
            }
        }

        public static void Merger(FileInfo data, int n)
        {
            try
            {
                String str;
                int t = 1;
                StreamReader reader0 = new StreamReader(data.OpenRead());
                StreamWriter Writer0;
                String numb0;
                while ((numb0 = reader0.ReadLine()) != null)
                {
                    toFileInfo++;
                    str = "FileInfo" + t + ".txt";
                    Writer0 = new StreamWriter(str, true);
                    Writer0.Write(numb0 + "\n");
                    toFileInfo++;
                    t++;
                    if (t == n + 1) t = 1;
                    Writer0.Close();
                }
                reader0.Close();


                int seriesMain = 1;
                int[] seriesNumbs = new int[n];
                String[] numbs = new String[n];
                String FileInfo;
                int fReader = 1;
                int fWriter = n + 1;
                StreamReader[] readers;
                StreamWriter[] Writers;
                FileInfo[] FileInfos;
                for (; ; )
                {
                    readers = new StreamReader[n];
                    Writers = new StreamWriter[n];
                    FileInfos = new FileInfo[n];
                    for (int i = 0, fR = fReader, fW = fWriter; i < n; i++, fR++, fW++)
                    {
                        FileInfo = "FileInfo" + fR + ".txt";
                        FileInfos[i] = new FileInfo(FileInfo);
                        readers[i] = new StreamReader(FileInfos[i].OpenRead());
                        FileInfo = "FileInfo" + fW + ".txt";
                        Writers[i] = new StreamWriter(FileInfo, true);
                    }

                    for (int i = 0; ;)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            numbs[j] = readers[j].ReadLine();
                            toFileInfo++;
                            compare++;
                            if (numbs[j] == null)
                            {
                                seriesNumbs[j] = seriesMain + 1;
                            }
                            else
                            {
                                seriesNumbs[j] = 1;
                            }
                        }

                        int count = 0;
                        for (int j = 0; j < n; j++)
                        {
                            compare++;
                            if (numbs[j] == null)
                            {
                                count++;
                            }
                        }
                        if (count == n)
                        {
                            break;
                        }

                        for (; ; )
                        {
                            String minNumb = null;
                            int minIndex = -1;
                            for (int j = 0; j < n; j++)
                            {
                                compare++;
                                if (numbs[j] != null)
                                {
                                    minNumb = numbs[j];
                                    minIndex = j;
                                    break;
                                }
                            }
                            for (int j = minIndex + 1; j < n; j++)
                            {
                                compare++;
                                if (numbs[j] == null)
                                {
                                    continue;
                                }
                                else
                                {
                                    compare++;
                                    if (Double.Parse(numbs[j]) < Double.Parse(minNumb))
                                    {
                                        minNumb = numbs[j];
                                        minIndex = j;
                                    }
                                }
                            }

                            toFileInfo++;
                            Writers[i].Write(minNumb + "\n");
                            compare++;
                            if (seriesNumbs[minIndex] < seriesMain)
                            {
                                toFileInfo++;
                                numbs[minIndex] = readers[minIndex].ReadLine();
                                compare++;
                                if (numbs[minIndex] == null)
                                {
                                    seriesNumbs[minIndex] = seriesMain + 1;
                                }
                                else
                                {
                                    seriesNumbs[minIndex]++;
                                }
                            }
                            else
                            {
                                numbs[minIndex] = null;
                                seriesNumbs[minIndex] = seriesMain + 1;
                            }

                            count = 0;
                            for (int j = 0; j < n; j++)
                            {
                                if (seriesNumbs[j] > seriesMain)
                                {
                                    count++;
                                }
                            }
                            if (count == n)
                            {
                                break;
                            }
                        }

                        i++;
                        if (i == n)
                        {
                            i = 0;
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        Writers[i].Close();
                        readers[i].Close();
                    }

                    FileInfo = "FileInfo" + (fWriter + 1) + ".txt";
                    StreamReader readerBuff = new StreamReader(FileInfo);
                    toFileInfo++;
                    String numbBuff = readerBuff.ReadLine();
                    readerBuff.Close();
                    if (numbBuff == null)
                    {
                        break;
                    }


                    seriesMain = seriesMain * n;
                    if (fWriter == n + 1)
                    {
                        fWriter = 1;
                    }
                    else
                    {
                        fWriter = n + 1;
                    }
                    if (fReader == n + 1)
                    {
                        fReader = 1;
                    }
                    else
                    {
                        fReader = n + 1;
                    }
                    for (int i = 0, k = fWriter; i < n; i++, k++)
                    {
                        FileInfos[i].Delete();
                    }
                }

                data.Delete();
                FileInfo = "FileInfo" + fWriter + ".txt";
                StreamReader readerLast = new StreamReader(FileInfo);
                StreamWriter WriterLast = new StreamWriter(data.OpenWrite());
                String numbLast;
                while ((numbLast = readerLast.ReadLine()) != null)
                {
                    WriterLast.Write(numbLast + "\n");
                }
                readerLast.Close();
                WriterLast.Close();

                for (int i = 1; i <= 2 * n; i++)
                {
                    FileInfo = "FileInfo" + i + ".txt";
                    FileInfo FileInfoDel = new FileInfo(FileInfo);
                    FileInfoDel.Delete();
                }

            }
            catch (IOException e)
            {
                e.GetBaseException();
            }
        }

    }
}
