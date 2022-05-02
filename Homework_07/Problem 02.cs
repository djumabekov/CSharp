using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_7 {
  /*
  Problem 02
  По подобию метода GetIntArray в Utils, напишите метод 
  public static List<int> GetIntList(int size, int min = 0, int max = int.MaxValue),
  возвращающий List случайных чисел.
   */
  internal class Problem_02 {
    public static List<int> GetIntList(int size, int min = 0, int max = int.MaxValue) {
      List<int> list = new List<int>(size);
      var rnd = new Random(0);
      for (int i = 0; i < size; i++) {
        list.Add(rnd.Next(min, max));
      }
      return list;
    }

  }
}
