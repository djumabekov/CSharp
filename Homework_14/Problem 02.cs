using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_14 {
  internal class Problem_02 {
    /*
    Problem 02
    Определите, когда начнут повторяться rnd.Next(int.MinValue, int.MaxValue) 
    с какого раза (timesBeforeFirstRepeat) и с какого числа (valueFirstRepeat).
    Выведите на консоль результаты 100(?) измерений. Каждый раз создавайте новый new Random(i), 
    где i - переменная цикла.
    Выведите среднее значение timesBeforeFirstRepeat (количество вызовов rnd.Next до первого повторения).
    */

    public static void Demo() {
      int size = 1_000_000;
      int count = 100;
      int avrTimesBeforeFirstRepeat = default;

      for (int k = 0; k < count; k++) {
        var hashSet = new HashSet<int>();
        int timesBeforeFirstRepeat = default;
        int valueFirstRepeat = default;

        for (int i = 0; i < size; i++) {
          var rnd = new Random(i*k);
          int value = rnd.Next(10, 100);  //rnd.Next(int.MinValue, int.MaxValue); // для проверки сократим диапазон чисел от 10 до 100
          if (hashSet.Contains(value)) {
            valueFirstRepeat = value;
            timesBeforeFirstRepeat = i;
            avrTimesBeforeFirstRepeat += timesBeforeFirstRepeat;
            break;
          }
          hashSet.Add(value);
        }
        WriteLine($"====================Массив: {k+1}====================");

        WriteLine($"С какого раза начинаются повторения: {timesBeforeFirstRepeat}");
        WriteLine($"С какого числа начинаются повторения: {valueFirstRepeat}");
      }
      WriteLine($"\n================ИТОГО:===============");
      WriteLine($"Среднее значение когда начинаются повторения: {avrTimesBeforeFirstRepeat / count}");
    }


  }
}
