using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_2_ADS
{
    class Stack<T>
    {
        public  T[] items;
        public int count = 0;

        public  void CreateStack(int n)
        {
            items = new T[n];
        }

        public void Push(T item)
        {
            if (count == items.Length)
            {
                throw new InvalidOperationException("Переполнение стека");
            }
            items[count++] = item;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            T item = items[--count];
            return item;
        }

        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            return items[count - 1];
        }
    }
}
