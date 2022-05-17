using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Exam {
  internal class Problem_02 {
    /*
     Problem 02
      В массиве случайных целых чисел размером size = 100_000_000 найдите все отрицательные числа, встречающиеся менее n раз.
      int[] GetNumbers(int[] arr, int n)
     */

    public static int[] GetNumbers(int[] arr, int n) {
      List<int> res = new List<int>();
      List<int> temp = arr.ToList();
      var sw = new Stopwatch();
      sw.Restart();
      temp.Sort();
      WriteLine($"Array sorted by time: {sw.Elapsed}\n");

      int i = 0;
      for (; i < temp.Count; i++) {
        int current = temp[i];
        if (current >= 0) break;
        else {
          if (!res.Contains(current)){
            int startPos = temp.IndexOf(current);
            int endPos = temp.LastIndexOf(current);
            if (endPos - startPos < n) {
              //WriteLine($"endPos - startPos = {endPos - startPos}\n");
              res.Add(current);
            }
            i = endPos + 1; 
          }
        }
      }
      return res.ToArray();
    }
    public static void Demo() {

      int limit = 1_000_000;
      var sw = new Stopwatch();
      sw.Restart();
      int[] arr = Utils.GetIntArray(100_000_000, int.MinValue/ 10_000_000, int.MaxValue/ 10_000_000);
      WriteLine($"Array create by time: {sw.Elapsed}\n");

      sw.Restart();
      int[] res = GetNumbers(arr, limit);
      WriteLine($"Searching by time: {sw.Elapsed}\n");
      sw.Stop();
      WriteLine($"Все отрицательные числа, встречающиеся менее {limit} раз: ");
      Utils.PrintArrayByLines(res);
    }
  }
}
