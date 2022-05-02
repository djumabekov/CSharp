using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork05
{
    /*
    Problem 01 (SortInside)
    Напишите метод для сортировки элементов внутри одномерного массива типа 
    long между индексами iMin и iMax. Вне данного интервала числа должны остаться на своих местах.
    static void SortInside(long[] arr, int iMin, int iMax). 
    Приведите убедительную демонстрацию правильной работы метода.
     */
    internal class Problem_01
    {
        static void SortInside(long[] arr, int iMin, int iMax)
        {
            Array.Sort(arr, iMin, iMax - iMin);
        }


        static long[] CreateRandArray()
        {
            //int size = 1_000_000;
            int size = 10;
            long [] arr = new long[size];
            var rnd = new Random(0);
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.NextInt64();
            }
            return arr;
        }

        public static void Demo() {
            long[] arr = CreateRandArray();
            WriteLine("before sort:");
            UtilsNS.Utils.PrintArray(arr, decimals: 0);
            SortInside(arr, 0, 4);
            WriteLine("after sort:");
            UtilsNS.Utils.PrintArray(arr, decimals: 0);
        }
    }
}
