using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_7 {
  /*
   Problem 05 - GetOddEvenLists
    Решите предыдущую задачу, используя List<int>.
    public static (List<int> oddList, List<int> evenList) GetOddEvenLists(int[] arr) 

    Реализуйте метод распечатки
    public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0)
    по подобию PrintArray<T>, или воспользуйтесь кодом:
    public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0) {
	    PrintArray<T>(list.ToArray(), width, decimals);
    }

    Выполните проверку:
    WriteLine($"oddList.Count + evenList.Count == arr.Length: {oddList.Count + evenList.Count == arr.Length}");

    Обсудите преимущества данного подхода по сравнению с предыдущим.
   */
 
  internal class Problem_05 {
    public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0) {
      UtilsNS.Utils.PrintArray<T>(list.ToArray(), width, decimals);
    }


  }
}
