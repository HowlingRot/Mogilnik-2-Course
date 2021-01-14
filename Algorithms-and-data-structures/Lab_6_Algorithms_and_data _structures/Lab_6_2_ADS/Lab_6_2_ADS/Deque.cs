using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_2_ADS
{
    class Deque<T>
    {
        public T[] items;
        public int rear = 0;
        public int frnt = 1;

        public void CreateDeque(int n)
        {
            items = new T[n];
        }

        public void AddLast(T x)
        {
            if (rear == items.Length)
            {
                throw new InvalidOperationException("Переполнение стека");
            }
            items[rear] = x;
            rear++;
        }

        public void AddFirst(T x)
        {
            if (rear == items.Length)
            {
                throw new InvalidOperationException("Переполнение стека");
            }
            if (rear == 0)
            {
                items[0] = x;
                rear++;
            }
            else if (rear == 1)
            {
                items[1] = items[0];
                items[0] = x;
                rear++;
            }
            else
            {
                for (int h = rear; h > 0; h--)
                {
                    items[h] = items[h - 1];
                }
                items[0] = x;
                rear++;
            }

        }

        public void Print()
        {
            for (int h = 0; h < rear; h++)
                Console.WriteLine(items[h]);
        }

        public T RemoveLast()
        {
            if (rear == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            T x = items[0];
            for (int h = 0; h < rear; h++)
            {
                items[h] = items[h + 1];
            }
            rear--;
            return x;
        }

        public T RemoveFirst()
        {
            if (rear == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            rear--;
            T x = items[rear];
            return x;
        }
    }
}
