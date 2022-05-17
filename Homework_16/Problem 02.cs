using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Classwork_16 {
  internal class Problem_02 {
    /*
     Problem 02
    По мотивам идеи предыдущей задачи, напишите метод
    static int[] MakeTossArray(int size),
    возвращающий массив интервала 1 - size, переставленных случайным образом.
    */

    public static int[]  Sort(int[] array) {
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

    static int[] MakeTossArray(int size) {
      Random rnd = new Random();
      var hash = new HashSet<int>();
      for (int i = 0; i < size; i++) {
        int key = rnd.Next(1, size + 1);
        if (!hash.Contains(key))
          hash.Add(key);
      }
      int[] arr = hash.ToArray();
      return arr;  
    }

    public static void Demo() {
      int size = 6;

      //array = Sort(array);
      int count = 1;
      for (int i = 0; i < size; i++) {
        var sw = new Stopwatch();
        sw.Restart();
        count *= size;
        int[] array = MakeTossArray(count);
        sw.Stop();
        WriteLine($"size = {count}, Time elapsed: {sw.Elapsed}, {IsUnique(array)}\n");
      }
    }
  }
}
