using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Classwork_08 {
  internal class Problem_01 {
    /*
     Problem 01
    Напишите метод, проверяющий, являются ли все элементы одномерного массива 
    целых чисел уникальными (неповторяющимися):
    public static bool IsUnique(int[] arr).
    */
    public static bool IsUnique(int[] arr) {
      bool isUnic = true;
      for (int i=0; i<arr.Length-1; i++) {
        if (arr[i].Equals(arr[i + 1])) { isUnic = false; break; }
      }
      return isUnic;
    }

    public static void Demo() {
      int size = 100_000;
      var arr = UtilsNS.Utils.GetIntArray(size, int.MinValue);
      var sw = new Stopwatch();
      sw.Restart();
      Array.Sort(arr);
      UtilsNS.Utils.PrintArray(arr);
      bool isUnic = IsUnique(arr);
      WriteLine($"Arr is unic?: {isUnic}\n");

      WriteLine($"sorting and searching by time: {sw.Elapsed}\n");
    }

  }
}
