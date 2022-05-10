using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_13 {
  internal class Problem_01 {
    /*
    Problem 01 (MinMaxGenerics)
    Напишите обобщенный метод GetMinMax для трех обобщенных параметров, 
    возвращающий минимальное и максимальное значения параметров. 
    Проверьте его работоспособность на типах int, double и string.
    static (T min, T max) GetMinMax<T>(T a, T b, T c) where T : IComparable<T> {...}
    */
    static (T min, T max) GetMinMax<T>(T a, T b, T c) where T : IComparable<T> {
      T min = a, max = a;

      // Нахождениа минимума
      if (b.CompareTo(min) < 0) {
        min = b;
      }
      if (c.CompareTo(min) < 0) {
        min = c;
      }


      // Нахождение максимума
      if (b.CompareTo(max) > 0) {
        max = b;
      }
      if (c.CompareTo(max) > 0) {
        max = c;
      }
      return (min, max);
    }

    public static void Demo() {
      int i1 = 30, i2 = 80, i3 = 10;
      double d1 = 60, d2 = 70, d3 = 40;
      string s1 = "Hello", s2 = "World", s3 = "!!!";

      WriteLine($"сравнение {i1} и {i2} и {i3} = Мин. и макс значение: {GetMinMax<int>(i1, i2, i3)}");
      WriteLine($"сравнение {d1} и {d2} и {d3} = Мин. и макс значение:{GetMinMax<double>(d1, d2, d3)}");
      WriteLine($"сравнение {s1} и {s2} и {s3} = Мин. и макс значение:{GetMinMax<string>(s1, s2, s3)}");
    }

  }
}