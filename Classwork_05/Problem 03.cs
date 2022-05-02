using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork05
{
    /*
     Problem 03
    Напишите метод
    public static int MaxIdenticalNumbersCount(int[] arr),
    возврашающий максимальное количество одинаковых чисел в массиве.
     */
    internal class Problem_03
    {
        public static int MaxIdenticalNumbersCount(int[] arr)
        {
            int counter = 0;
            int maxMatches = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j]) counter++;
                    if (maxMatches < counter) maxMatches = counter;
                }
                counter = 0;
            }
            return maxMatches; 
        }

        static int[] CreateArray()
        {
            var rnd = new Random();
            //int size = 1_000_000;
            int size = 100;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(10, 100);
            }
            return arr;
        }

        public static void Demo()
        {
            int[] arr = CreateArray();
            WriteLine("Simple array:");
            //UtilsNS.Utils.PrintArray(arr);
            foreach (var item in arr) Write($"{item}, ");
            WriteLine($"\nМаксимальное количество одинаковых чисел в массиве: {MaxIdenticalNumbersCount(arr)}");
        }
    }
}
