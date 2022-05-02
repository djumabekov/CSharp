using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork05
{
    /*
    Problem 05 - SimpleMergeSort
    Заполните два массива целых чисел длины nLen1= 200_000 , 
    nLen2=400_000 случайными четными и нечетными целыми числами соответственно в возрастающем порядке 
    (можно отсортировать массивы после формирования). 
    Выходной массив длины nLen1 + nLen2 должен содержать их объединение в возрастающем порядке. 
    Не прибегая к сортировке, найдите предельно быстрый способ заполнения выходного массива.
    Сделайте полную автоматическую проверку результата.
    Выведите начальные и конечные части каждого массива.
    [6 8 14 44 58 62 . . . ] + [3 5 11 23 27 47 . . . ] =
    [3 5 6 8 11 23 27 44 47 62 ]
     */
    internal class Problem05
    {
        public static int[] SimpleMergeSort() {
            int[] arr1 = CreateRandomArray(2);
            int[] arr2 = CreateRandomArray(4);

            Array.Sort(arr1);
            Array.Sort(arr2);
            WriteLine("\nArr1:");
            foreach (var item in arr1) Write($"{item}, ");
            WriteLine("\nArr2:");
            foreach (var item in arr2) Write($"{item}, ");

            int[] arr3 = new int[arr1.Length + arr2.Length];
            int i = 0, j = 0;
            for (int k = 0; k < arr3.Length; k++)
            {
                arr3[k] =
                    i >= arr1.Length ? arr2[j++] :
                    j >= arr2.Length ? arr1[i++] :
                    arr1[i] > arr2[j] ? arr2[j++] : arr1[i++];
            }
            return arr3;
        }


        static int[] CreateRandomArray(int size)
        {
            int[] arr = new int[size];
            var rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(10, 100);
            }
            return arr;
        }

        public static void Demo()
        {
            int[] arr = SimpleMergeSort();
            WriteLine("\nMerge 2 arrays:");
            foreach (var item in arr) Write($"{item}, ");
        }
    }
}
