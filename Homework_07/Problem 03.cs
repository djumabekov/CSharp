using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_7 {
  /*
   Problem 03
    Напишите метод
    public static List<int> GetSomeEvensList(int max),
    возвращающий все положительные целые четные числа меньше max, не делящиеся на 5.
   */

  internal class Problem_03 {

    public static List<int> GetSomeEvensList(int max) {
      List<int> list = new List<int>();
      for(int i=0; i<max; i++) {
        if(i >= 0 && i % 5 != 0) list.Add(i);
      }
      return list;
    }
  }
}
