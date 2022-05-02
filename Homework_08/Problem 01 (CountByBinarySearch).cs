using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using UtilsNS;

namespace Classwork_08 {
  internal class Problem_01__CountByBinarySearch_ {

    /*
     ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ

    Problem 01 (CountByBinarySearch)
    Создайте массив arr размером size = ??? (1_000_000_000 или больше) 
    случайных целых чисел в интервале (0 - size/10).

    Скопируйте массив arr в массив arrSorted и отсортируйте arrSorted.
    Напишите метод

    public static int GetCountFromSorted(int[] arrSorted, int n),
    в котором способом бинарного поиска находится положение числа n 
    в отсортированном массиве и общее количество его дубликатов 
    (к-во дубликатов возвращается данным методом).

    Проверьте правильность работы GetCountFromSorted с помощью метода
    public static int GetCount(int[] arr, int n),
    который подсчитывает общее количество дубликатов n с помощью полного перебора массива.
    Проведите сравнение скорости работы данных двух методов для достаточно 
    большого значения size (рекомендуется, чтобы общее время ИЗМЕРЕНИЙ не превышало минуты). 
    Измерения провести в режиме Release, x64.
     */
    public static int GetCountFromSorted(int[] arrSorted, int n) {
      int idx = Array.BinarySearch(arrSorted, n); // бинарный поиск ищет "делением массива пополам", поэтому возвращаемый индекс первого найденного элемента может оказаться в середине таких чисел 
      int dublicateCnt = 0;

      if (idx >= 0) {
        for (int i = idx; i < arrSorted.Length - 1; i++) {
          if (arrSorted[idx].Equals(arrSorted[i + 1])) dublicateCnt++; // учитывая, что наш массив отстортирован, нам остается найти соседние дубликаты в правом крыле начиная от индекса найденного числа 
          else break; // поиск только тех элементов которые совпадают с нашим числом, поэтоу как только мы натыкаемся на иное число прерываем цикл
        }
        for (int i = idx; i >= 0; i--) {
          if (arrSorted[idx].Equals(arrSorted[i])) dublicateCnt++; // учитывая, что наш массив отстортирован, нам остается найти соседние дубликаты в левом крыле начиная от индекса найденного числа 
          else break; // поиск только тех элементов которые совпадают с нашим числом, поэтому как только мы натыкаемся на иное число прерываем цикл
        }
      }
      return dublicateCnt;
    }

    public static int GetCount(int[] arr, int n) { // поиск обычным перебором всех эелементов массива

      int dublicateCnt = 0;
      foreach (int item in arr) {
        if (item.Equals(n)) {
          dublicateCnt++;
        }
      }
      return dublicateCnt;
    }

    public static void Demo() {
      int size = 100_000_000;
      var arr = Utils.GetIntArray(size, max:size/10);

      int[] arrSorted = new int[size];

      Array.Copy(arr, arrSorted, size);

      var sw = new Stopwatch();
      sw.Restart();
      Array.Sort(arrSorted);
      Utils.PrintArray(arrSorted);
      //foreach (var item in arrSorted) Write($"{item}, ");
      WriteLine("\nВведите целое число для поиска дубликатов в массиве: ");
      int number = int.Parse(Console.ReadLine());

      WriteLine($"Sorting by time: {sw.Elapsed}\n");

      sw.Restart();
      int dublicateCnt = GetCountFromSorted(arrSorted, number);
      WriteLine($"Searching dublicate by GetCountFromSorted(): {dublicateCnt}\n");
      WriteLine($"Searching time: {sw.Elapsed}\n");

      sw.Restart();
      dublicateCnt = GetCount(arrSorted, number);
      WriteLine($"Searching dublicate by GetCount(): {dublicateCnt}\n");
      WriteLine($"Searching time: {sw.Elapsed}\n");


    }
  }
}
