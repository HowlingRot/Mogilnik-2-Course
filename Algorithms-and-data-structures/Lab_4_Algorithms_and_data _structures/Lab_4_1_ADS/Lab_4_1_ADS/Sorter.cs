using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4_1_ADS
{
    class Sorter
    {
		//Число операций сравнения и обмена
		public static int Compare_Times = 0, Swap_Times = 0;

		//Сортировка выбором
		public static void Sort_Selection(int[] Array)
		{
			int n = Array.Length;

			for (int i = 0; i < n - 1; i++)
			{
				int minimal_element = i;
				for (int j = i + 1; j < n; j++)
				{

					Compare_Times++;
					if (Array[j] < Array[minimal_element])
						minimal_element = j;
				}

				Swap_Times++;
				int temp = Array[minimal_element];
				Array[minimal_element] = Array[i];
				Array[i] = temp;
			}
		}

		//Сортировка вставками
		public static void Sort_Insertion(int[] Array)
		{

			int n = Array.Length;
			for (int i = 1; i < n; ++i)
			{
				int key = Array[i];
				int j = i - 1;				
				while (j >= 0 && Array[j] > key)
				{

					Compare_Times++;
					Swap_Times++;
					Array[j + 1] = Array[j];
					j--;
				}
				Compare_Times++;

				Array[j + 1] = key;
			}

		}

		//Сортировка обменом
		public static void Sort_Swap(int[] Array)
		{

			int n = Array.Length;
			for (int i = 0; i < n - 1; i++)
				for (int j = 0; j < n - i - 1; j++)
				{
					Compare_Times++;
					if (Array[j] > Array[j + 1])
					{

						Swap_Times++;

						int temp = Array[j];
						Array[j] = Array[j + 1];
						Array[j + 1] = temp;
					}
				}

		}

		//Быстрая сортировка
		public static void Quick_Sort(int[] arr, int left, int right)
		{
			Compare_Times++;
			if (left < right)
			{
				int pivot = Partition(arr, left, right);

				Compare_Times++;
				if (pivot > 1)
				{
					Quick_Sort(arr, left, pivot - 1);
				}
				
				Compare_Times++;
				if (pivot + 1 < right)
				{
					Quick_Sort(arr, pivot + 1, right);
				}
			}

		}

		private static int Partition(int[] arr, int left, int right)
		{
			int pivot = arr[left];
			while (true)
			{
				Compare_Times++;
				while (arr[left] < pivot)
				{
					left++;
					Compare_Times++;
				}

				Compare_Times++;
				while (arr[right] > pivot)
				{
					right--;
					Compare_Times++;
				}

				Compare_Times++;
				if (left < right)
				{
					Compare_Times++;
					if (arr[left] == arr[right])
						return right;

					Swap_Times++;
					int temp = arr[left];
					arr[left] = arr[right];
					arr[right] = temp;
				}
				else
				{
					return right;
				}
			}
		}

		//Гибридная сортировка(TimSort)
		public static void TimSort(int[] Array)
		{					
			int n = Array.Length;
			int Run = GetMinrun(n);

		
				for (int i = 0; i < n; i += Run)

				InsertionSort(Array, i, Math.Min((i + 31), (n - 1)));

			for (int size = Run; size < n; size = 2 * size)

			{

				for (int left = 0; left < n; left += 2 * size)

				{

					
					int mid = left + size - 1;

					int right = Math.Min((left + 2 * size - 1), (n - 1));

					if (right >= mid)
					{
						Merge(Array, left, mid, right);
					}

					

				}
			}
			
		}

		private static int GetMinrun(int n)
		{
			int r = 0;          
			while (n >= 64)
			{
				Compare_Times++;
				r |= n & 1;
				n >>= 1;
			}
			return n + r;
		}

		private static void InsertionSort(int[] Array, int left, int right)
		{
			for (int i = left + 1; i < right; i++)
			{
				int current = Array[i];
				int j = i - 1;
				while ((j >= left) && (current < Array[j]))
				{
					Compare_Times++;
					Swap_Times++;
					Swap(ref Array[j], ref Array[j + 1]);
					--j;
				}
				Compare_Times++;
			}
		}

		private static void Merge(int[] Array, int l, int m, int r)
		{

			int len1 = m - l + 1, len2 = r - m;

			int[] left = new int[len1];
			int[] right = new int[len2];

			for (int f = 0; f < len1; f++)
			{
				left[f] = Array[l + f];
			}
				
			for (int f = 0; f < len2; f++)
			{
				right[f] = Array[m + 1 + f];
			}
			


			int i = 0;

			int j = 0;

			int k = l;

			while (i < len1 && j < len2)
			{
				Compare_Times++;
				if (left[i] <= right[j])
				{
					
					Array[k] = left[i];

					i++;

				}

				else

				{
					
					Array[k] = right[j];

					j++;

				}

				k++;
				Compare_Times++;
			}

			while (i < len1)
			{
				Compare_Times++;
				Array[k] = left[i];

				k++;

				i++;

			}		

			while (j < len2)
			{
				Compare_Times++;
				Array[k] = right[j];

				k++;

				j++;

			}

		}

		static void Swap(ref int a, ref int b)
		{
			int c;
			c = a;
			a = b;
			b = c;
		}


	}

	

}
