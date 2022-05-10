using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_13 {
  internal class Problem_02 {
    /*
    Problem 02
    Напишите обобщенный метод
    public static void RearrangeByDesc<T> . . .
    "переставляющий" три элемента a, b, c обобщенного типа T в порядке убывания.
    */
    static void RearrangeByDesc<T>(T a, T b, T c) where T : IComparable<T> {
      List<T> list = new List<T>();
      list.Add(a);list.Add(b);list.Add(c);
      list.Sort((T x, T y) => -x.CompareTo(y));
      Utils.PrintList(list);
    }

    public static void Demo() {
      int i1 = 30, i2 = 80, i3 = 10;
      double d1 = 60, d2 = 70, d3 = 40;
      string s1 = "Hello", s2 = "World", s3 = "!!!";

      WriteLine($"Переставление {i1} и {i2} и {i3} в порядке убывания: "); RearrangeByDesc<int>(i1, i2, i3);
      WriteLine($"Переставление {d1} и {d2} и {d3} в порядке убывания: "); RearrangeByDesc<double>(d1, d2, d3);
      WriteLine($"Переставление {s1} и {s2} и {s3} в порядке убывания: "); RearrangeByDesc<string>(s1, s2, s3);
    }

  }
}
