using System;

namespace Lab_3_1_ADS
{
    class Program
    {
        //Программа для решения задачи об акциях методом "Разделяй и властвуй"
        static void Main(string[] args)
        {
               
            Console.WriteLine("Введите количество дней:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[n + 1];
              
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine($"День {i}");
                    Array[i] = Convert.ToInt32(Console.ReadLine());
                }
          

            int[] ChangeArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                ChangeArray[i] = Array[i + 1] - Array[i];
            }

            int Left = 0;
            int Right = n-1;
            int[] Answer = Findmax(ChangeArray, Left, Right);
            Console.WriteLine($"Прибыль: {Answer[2]}. День покупки: {Answer[0]}. День продажи: {Answer[1]}.");

        }


        static int[] Findmax(int[] Array, int Left, int Right)
        {
            int[] Results = new int[3];
            int n = Array.Length;           
            if (Right == Left)
            {
                Results[0] = Left;
                Results[1] = Right;
                Results[2] = Array[Left];
                return Results;
            }
            else
            {
                int Middle = (Left + Right) / 2;

                int[] LeftArray = Findmax(Array, Left, Middle);
                int leftlow = LeftArray[0];
                int lefthigh = LeftArray[1];
                int leftsum = LeftArray[2];

                int[] RightArray = Findmax(Array, Middle+1, Right);
                int rightlow = RightArray[0];
                int righthigh = RightArray[1];
                int rightsum = RightArray[2];

                int[] MiddleArray = Maxsubarray(Array, Left, Right, Middle);
                int crosslow = MiddleArray[0];
                int crosshigh = MiddleArray[1];
                int crosssum = MiddleArray[2];

                if (leftsum >= rightsum && leftsum >= crosssum)
                {
                    Results[0] = leftlow;
                    Results[1] = lefthigh;
                    Results[2] = leftsum;
                    return Results;
                }
                else
                {
                    if (rightsum >= leftsum && rightsum >= crosssum)
                    {
                        Results[0] = rightlow;
                        Results[1] = righthigh;
                        Results[2] = rightsum;
                        return Results;
                    }
                    else
                    {
                        Results[0] = crosslow;
                        Results[1] = crosshigh;
                        Results[2] = crosssum;
                        return Results;
                    }
                }
            }

        }
        static int[] Maxsubarray(int[] Array, int Left, int Right,int Middle)
        {
            int[] Results = new int[3];
            int leftsum = 0;
            int sum = 0;
            int maxleft = 0;
            for (int i = Middle; i >= Left; i--)
            {
                sum += Array[i];
                if (sum > leftsum)
                {
                    leftsum = sum;
                    maxleft = i;
                }
            }
            int rightsum = 0;
            int maxright = 0;
            sum = 0;
            for (int i = Middle + 1; i <= Right; i++)
            {
                sum += Array[i];
                if (sum > rightsum)
                {
                    rightsum = sum;
                    maxright = i+1;
                }
            }
            Results[0] = maxleft;
            Results[1] = maxright;
            Results[2] = leftsum + rightsum;
            return Results;
        }

    }
}