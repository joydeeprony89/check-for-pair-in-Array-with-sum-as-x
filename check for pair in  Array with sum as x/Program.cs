using System;

namespace check_for_pair_in__Array_with_sum_as_x
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 4, 45, 6, 10, -8 };
            Console.WriteLine(HasArrayTwoCandidates(input, 12));
        }

        static bool HasArrayTwoCandidates(int[] arr, int sum)
        {
            int l = 0;
            int r = arr.Length - 1;
            Sort(arr, l , r);
            int i = 0, j = arr.Length - 1;
            while (i < j)
            {
                if (arr[i] + arr[j] == sum) return true;
                if (arr[i] + arr[j] < sum) i++;
                else j--;
            }
            return false;
        }

        static void Sort(int[] arr, int l,  int r)
        {
            if (l < r)
            {
                int position = Partition(arr, l, r);
                Sort(arr, l, position - 1);
                Sort(arr, position + 1, r);
            }
        }

        static int Partition(int[] arr, int l, int r)
        {
            int pivot = arr[r];
            int i = l;
            for(int j = i; j < r; j++)
            {
                if (arr[j] <= pivot)
                {
                    Swap(arr, i, j);
                    i++;
                }
            }

            Swap(arr, i, r);
            return i;
        }

        static void Swap(int[] arr, int i , int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
