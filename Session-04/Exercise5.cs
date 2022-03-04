using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Exercise5
    {
        public Exercise5()
        {

        }
        public void Sort()
        {
            int[] array = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            Console.WriteLine("Original array : ");
            for (int i = 0; i < array.Length; i++){
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            Sorting(array, 0, array.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        } 
        private void Sorting(int[] array, int left, int right)
        {

            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                {
                    Sorting(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sorting(array, pivot + 1, right);
                }
            }

        }
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right]) return right;
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
