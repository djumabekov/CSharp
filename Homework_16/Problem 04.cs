using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Classwork_16 {
  internal class Problem_04 {
    /*
     ДОПОЛНИТЕЛЬНАЯ ЗАДАЧА

      Problem 04
      Напишите метод 
      public static int[] GetUniqueRandomArray(int size, int min = 0, int max = int.MaxValue)
      возвращающий случайный массив НЕПОВТОРЯЮЩИХСЯ целых чисел в заданном интервале. Все числа из интервала [min, max] должны иметь равную вероятность появления в итоговом массиве.

      Обеспечьте максимально быструю скорость формирования массива!

      Возвращаемый массив проверяйте на уникальность чисел с помощью метода
      static bool IsUnique(int[] arr).
     */
    public static int[] Sort(int[] array) {
      var tempArr = array;
      int temp;
      for (int i = 0; i < tempArr.Length - 1; i++) {
        for (int j = i + 1; j < tempArr.Length; j++) {
          if (tempArr[i] > tempArr[j]) {
            temp = tempArr[i];
            tempArr[i] = tempArr[j];
            tempArr[j] = temp;
          }
        }
      }
      return tempArr;
    }
    public static bool IsUnique(int[] array) {
      var hash = new HashSet<int>(array.ToHashSet());
      if (hash.Count == array.Length) return true;
      return false;
    }
    public static int[] GetUniqueRandomArray(int size, int min = 0, int max = int.MaxValue) {
      Random rnd = new Random();
      var hash = new HashSet<int>();
      for (int i = 0; i < size; i++) {
        int key = rnd.Next(min, max);
        if (!hash.Contains(key))
          hash.Add(key);
      }
      int[] arr = hash.ToArray();
      return arr;
    }
    public static void Demo() {
      int size = 10_000_000;

      var sw = new Stopwatch();
      sw.Restart();
      int[] array = GetUniqueRandomArray(size, 0, int.MaxValue);
      sw.Stop();
      Utils.PrintArrayByLines(array);
      WriteLine($"size = {size}, Time elapsed: {sw.Elapsed}, {IsUnique(array)}\n");

    }

  }
}
