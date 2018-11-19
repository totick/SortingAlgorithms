using System;

namespace SortingAlgorithms
{

    class MainClass
    {

        public static void PrintArray(int[] a)
        {
            foreach(var value in a)
            {
                Console.Write("{0} ", value);
            }
        }

        public static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }

        //Simplest sorting algorithm.
        //Swaps the adjacent value if it is in the wrong order
        //Pretty slow and ineffective
        public static void BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        Swap(a, j, j + 1);
                    }
                }
            }
        }



        public static void Main(string[] args)
        {
            //Bubble sort test
            int[] a = new int[6] { 5, 1, 4, 2, 8, 9 };
            BubbleSort(a);
            PrintArray(a);
        }
    }
}
