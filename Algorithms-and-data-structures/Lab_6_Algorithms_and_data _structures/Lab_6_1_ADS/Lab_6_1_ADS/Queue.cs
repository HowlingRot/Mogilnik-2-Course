using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_1_ADS
{
    class Queue<T>
    {
        //Очередь
        public static T[] items;
        public static int rear = 0; 
        public static int frnt = 1;

        public static void CreateQueue(int n)
        {
            items = new T[n];
        }

        public static void Insert(T x)
        {
            rear++;
            if (rear == items.Length)
            {
                throw new InvalidOperationException("Переполнение стека");
            }
            items[rear] = x;   
        }

        public static void Print()
        {
            for (int h = frnt; h <= rear; h++)
                Console.WriteLine(items[h]);
        }

        public static T Remove()
        {
            if (rear == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            T x = items[frnt];
            for (int h =frnt; h < rear; h++)
            {
                items[h] = items[h + 1];
            }
            rear--;
            return x;
        }
    }
}
