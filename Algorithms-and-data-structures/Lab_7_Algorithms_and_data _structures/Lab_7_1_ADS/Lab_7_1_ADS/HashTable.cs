using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7_1_ADS
{
    class HashTable
    {
        public int N;
        public long[] Table;
        const int c = 3;
        const int d = 2;

        public void Create_HashTable(int copasity)
        {
            Table = new long[copasity];
            Array.Fill(Table, 0);
            N = copasity;
        }

        private int Hash_Function(int value)
        {
            int z = value * value / 2;
            return z;        
        }

        public void Add(int value)
        {
            int Hash_Key = Hash_Function(value) % N;
            int temp = Hash_Key;
            int i = 0;

            while (true)
            {
                if (Table[temp] == 0)
                {
                    Table[temp] = value;
                    break;
                }
                i++;
                temp = Hash_Key + (c * i) + (d * i * i);
                if (temp > Table.Length)

                {
                    break;
                }
            }

        }

        public int Search(int value)
        {
            int Hash_Key = Hash_Function(value) % N;
            int temp = Hash_Key;
            int i = 0;

            while (true)
            {
                if (Table[temp] == value)
                {
                    Table[temp] = value;
                    return temp;
                }
                i++;
                temp = Hash_Key + (c * i) + (d * i * i);
                if (temp > Table.Length)
                {
                    Console.WriteLine("Такого элемента нет");
                    return -1;
                }
            }

        }
    }
}
