using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6_1_ADS
{
    class Stack<T>
    {
        //Стек
        public static T[] items;
        public static int count = 0;  

        public static void CreateStack(int n)
        {
            items = new T[n];
        }

        public static void Push(T item)
        {
            if (count == items.Length)
            {
                throw new InvalidOperationException("Переполнение стека");
            }
           items[count++] = item;
        }

        public static T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            T item = items[--count];        
            return item;
        }

        public static T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Стек пуст");
            }
            return items[count - 1];
        }
    }
}
