using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_2_ADS
{
    class Queue<T>
    {
        public  T[] items;
        public  int rear = 0;
        public  int frnt = 1;

        public void CreateQueue(int n)
        {
            items = new T[n];
        }

        public void Insert(T x)
        {
            rear++;
            if (rear == items.Length)
            {
                throw new InvalidOperationException("Переполнение стека");
            }
            items[rear] = x;
        }

        public void Print()
        {
            for (int h = frnt; h <= rear; h++)
                Console.WriteLine(items[h]);
        }

        public void Remove()
        {
            if (rear == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            for (int h = frnt; h < rear; h++)
            {
                items[h] = items[h + 1];
            }
            rear--;
   
        }
    }
}
