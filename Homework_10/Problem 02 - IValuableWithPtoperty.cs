using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classwork_10.ValuableWPClasses;


namespace Classwork_10 {
  internal class Problem_02___IValuableWithPtoperty {
    /*
    Problem 02 - IValuableWithPtoperty 
    Аналогично Problem 01, но для интерфейса со свойством Value(вместо метода GetValue).
    */
    static List<IValuableWP> GeRandomValuableList(int size) {
      var rnd = new Random();

      List<IValuableWP> valuable = new List<IValuableWP>(size);
      for (int i = 0; i < size; i++) {
        valuable.Add(new Book(rnd.Next(10, 100)));
        valuable.Add(new Rarity(rnd.Next(30, 90)));
        valuable.Add(new Statue(rnd.Next(60, 200)));
        valuable.Add(new Picture(rnd.Next(50, 220)));
      }
      return valuable;
    }

    public static double GetWorth(IValuableWP v) {
      return v.Value;
    }
    static double GetWorth(List<IValuableWP> list) {
      double sum = 0;
      foreach (var obj in list) {
        sum += obj.Value;
      }
      return sum;
    }

    public static void BubleSort(List<IValuableWP> list) {
      IValuableWP temp;
      for (int i = 0; i < list.Count; i++) {
        for (int j = 0; j < list.Count; j++) {
          if (list[i].Value > list[j].Value) {
            temp = list[i];
            list[i] = list[j];
            list[j] = temp;
          }
        }
      }
    }
    static int CompareByValue(IValuableWP a, IValuableWP b) {
      return -a.Value.CompareTo(b.Value);
    }
    public static void SortByValue(List<IValuableWP> list) {
      list.Sort(CompareByValue);
    }
    public static void Demo() {
      int size = 10;
      var list = GeRandomValuableList(size);

      WriteLine($"\nПузырьковая сортировка:\n");
      BubleSort(list);
      foreach (var item in list) {
        Write($"{item.Value,6:N2}, ");
      }
      WriteLine();

      WriteLine($"\nCортировка с помощью библиотечного метода Sort:\n");
      SortByValue(list);
      foreach (var item in list) {
        Write($"{item.Value,6:N2}, ");
      }
      WriteLine();
      WriteLine($"\nОбщая стоимость: {GetWorth(list),6:N2}");
      //. . . 
    }
  }
}
