using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_QuickSort
{
    class Program
    {

        static int[] createRandIntArr()
        {
            Random rand = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(0, 100);
            return arr;
        }

        static void printIntArr(int[] arr)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = createRandIntArr();

            QuickSort<int> qSort = new QuickSort<int>();

            printIntArr(arr);
            qSort.Sort(arr, 0, arr.Length - 1);
            printIntArr(arr);

            Console.ReadKey();
        }
    }

    public class QuickSort<T> where T : IComparable<T>
    {
        public void Sort(T[] arr, int l, int r)
        {
            int i = l, j = r;
            T x = arr[l + (r - l) / 2];
            while (i <= j)
            {
                while (arr[i].CompareTo(x) < 0) i++;
                while (arr[j].CompareTo(x) > 0) j--;

                if (i <= j)
                {
                    Swap(ref arr[i++], ref arr[j--]);
                }

                if (l < j)
                {
                    Sort(arr, l, j);
                }

                if (r > i)
                {
                    Sort(arr, i, r);
                }
            }
        }

        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
