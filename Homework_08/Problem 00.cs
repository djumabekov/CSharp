using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Classwork_08 {
  internal class Problem_00 {
    /*
     Problem 00 - ArrayListSort
      Измерьте времена сортировки массива целых чисел и List<int> размера size = 1_000_000_000, 
      одинаково заполненных случайными числами в интервале (int.MinValue, int.MaxValue).
      Сравните результаты в режимах Release, x64 и Debug, x64.
      Дома, повторив и усреднив результаты нескольких измерений, составьте сводную таблицу в Excel (см. result.xlsx). 
    */

   public static void ArraySort() {
      int size = 100_000;
      var arr = UtilsNS.Utils.GetIntArray(size, int.MinValue);
      var sw = new Stopwatch();
      sw.Restart();
      Array.Sort(arr);
      WriteLine($"Sorting int ARRAY by time: {sw.Elapsed}\n");
    }

    public static void ListSort() {
      int size = 100_000;
      List<int> list = UtilsNS.Utils.GetIntList(size, int.MinValue);
      var sw = new Stopwatch();
      sw.Restart();
      list.Sort();
      WriteLine($"Sorting int LIST (Sort()) by time: {sw.Elapsed}\n");

      sw.Restart();
      list.Sort((x, y) => x.CompareTo(y));
      WriteLine($"Sorting int LIST (x.CompareTo(y)) by time: {sw.Elapsed}\n");

      sw.Restart();
      list.Sort((x, y) => -x.CompareTo(y));
      WriteLine($"Sorting int LIST (-x.CompareTo(y)) by time: {sw.Elapsed}\n");
    }


  }
}
