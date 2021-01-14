using System;

namespace Lab_3_2_ADS
{
    class Program
    {
        //Программа для нахождения минмальной длинны нити между гвоздиками
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество гвоздиков");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[n];
            int[] Answer = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите координату X для гвоздика №{i + 1}");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Sort_Insertion(Array);

            Answer[0] = Array[1] - Array[0];
            Answer[1] = Array[2] - Array[0];

            for (int i = 2; i < n; i++)
            {
                Answer[i] = Math.Min(Answer[i - 1], Answer[i - 2]) + Array[i] - Array[i - 1];
            }


            Console.WriteLine($"Минимальная длинна нити: {Answer[n-1]}");
        }
        
        //Функция сортировки выбором
        static void Sort_Insertion(int[] Array)
        {

            int n = Array.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = Array[i];
                int j = i - 1;
                while (j >= 0 && Array[j] > key)
                {                   
                    Array[j + 1] = Array[j];
                    j--;
                }               

                Array[j + 1] = key;
            }

        }
    }
}
