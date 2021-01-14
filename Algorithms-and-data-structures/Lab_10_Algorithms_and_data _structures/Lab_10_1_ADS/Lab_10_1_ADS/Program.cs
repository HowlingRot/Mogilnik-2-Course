using System;
using System.IO;
using System.Collections.Generic;

/*
Правила заполнения файлов:
Первая строка содержит количество городов, в следующих номера городов,
разделённые пробелами, с которыми напрямую соединён i город
dataA - файл с чётно-нечётная магистраль
dataB - файл с не чётно-нечётная магистраль
 
*/


namespace Lab_10_1_ADS
{
	class Program
	{

		static int n;
		static int count;
		static List<List<int>> lists = new List<List<int>>();
		static List<int> met = new List<int>();
		static bool two;
		static bool connect;
		static int ma;

		static int BFS(int v)
		{
			int[] dols = { 1, 0 };
			int count = 1;
			two = true;			
			met[v] = 0;
			Queue<int> fifo = new Queue<int>();
			fifo.Enqueue(v);
			while (fifo.Count != 0)
			{
				int tmp = fifo.Dequeue();
				for (int i = 0; i < lists[tmp].Count; i++)
				{
					if (met[lists[tmp][i]] == -1)
					{
						count++;
						met[lists[tmp][i]] = (met[tmp] + 1) % 2;
						dols[(met[tmp] + 1) % 2]++;
						fifo.Enqueue(lists[tmp][i]);
					}
					else if (met[lists[tmp][i]] == met[tmp])
					{
						two = false;
					}
				}
			}
			if (two)
			{
				if (dols[0] > dols[1])
				{
					ma += dols[0];
				}
				else
				{
					ma += dols[1];
				}
			}
			else
			{
				ma++;
			}
			if (two)
			{
				Console.WriteLine("Города, входящие в множество(0 - нет, 1 - да): ");
				for (int i = 0; i < met.Count; i++)
				{
					Console.WriteLine($"Город {i} - {met[i]}");
				}
			}			
			return count;
		}

		static void Main(string[] args)
		{
			FileStream fs = new FileStream("A:\\Works\\Laboratory\\Algorithms_and_data _structures\\Lab_10_Algorithms_and_data _structures\\Lab_10_1_ADS\\dataA.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader("A:\\Works\\Laboratory\\Algorithms_and_data _structures\\Lab_10_Algorithms_and_data _structures\\Lab_10_1_ADS\\dataA.txt");
			ma = 0;
			

			byte[] NumberOfCities = new byte[1];
			fs.Read(NumberOfCities, 0, 1);
			string textFromFile = System.Text.Encoding.Default.GetString(NumberOfCities);
			Console.WriteLine($"Количество городов: {textFromFile}");
			n = Convert.ToInt32(textFromFile);

			lists.Capacity = n;

			for (int i = 0; i < n; i++)
			{
				met.Add(-1);
			}

			string line;
			sr.ReadLine();
			int j = 0;
			for (int i = 0; i < n; i++)
			{
				lists.Add(new List<int>());
			}

				while (!sr.EndOfStream)
			{
				line = sr.ReadLine();
				line.Split(" ");
				for(int i =0;i<line.Length;i+=2)
				{
					lists[j].Add(Convert.ToInt32(line[i].ToString()) - 1);
				}
				j++;
			
			}		

			int C = BFS(0);
			int times = 1;

			if (C == n && !two)
			{
				Console.WriteLine("Магистраль чётно-нечётная");
			}
			else if (C == n && two)
			{
				Console.WriteLine("Магистраль не чётно-нечётная");
			}
			else if (C != n)
			{
				for (int i = 0; i < n; i++)
				{
					if (met[i] == -1)
					{
						C += BFS(i);
						times++;
					}
				}
				Console.WriteLine("Магистраль не чётно-нечётная");
			}
			}

	}
}



		
