using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_7 {
  /*
   Problem 06
  Напишите метод, возвращающий кортеж из двух List<int> - чисел до первого вхождения числа splitter включительно и остальных.
  public static (List<int> firstList, List<int> secondList) GetSomeLists(int[] arr, int splitter).
  */
  internal class Problem_06 {

    public static (List<int> firstList, List<int> secondList) GetSomeLists(List<int> arr, int splitter) {
      List<int> firstList = new List<int>(); //четные
      List<int> secondList = new List<int>(); //нечетные
      var tupleLists = (firstList, secondList);
      int index = arr.IndexOf(splitter);
      for (int i = 0; i <= index; i++) firstList.Add(arr[i]);
      for (int i = index+1; i < arr.Count; i++) secondList.Add(arr[i]);
      return tupleLists;
    }
  }
}
