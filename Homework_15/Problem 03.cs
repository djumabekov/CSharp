using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_15 {
  internal class Problem_03 {
    /*
    Problem 03
    Проверьте равномерность распределения случайных чисел встроенного генератора Random(), проведя исследование последовательности из 10_000_000 (или более) целых чисел rnd.Next(-100, +100).
    Критерием равномерности служит одинаковость частот генерации каждого числа из интервала (-100, +100) в среднем.

    Повторите исследование с вещественными числами в интервале (-1, +1).
    Выведите суммарные количества чисел с частотами 2, 3, 4. 
     */
    public static void Demo() {
      Random rnd = new Random();
      int size = 10_000_000;

      var dict = new Dictionary<int, int>();
      for (int i=0; i<size; i++) {
        int key = rnd.Next(-100, 100);
        if (dict.ContainsKey(key))
          dict[key]++;
        else
          dict.Add(key, 1);
      }

      WriteLine("\n======Проверка равномерности распределения случайных чисел встроенного генератора Random() для INT======\n");

      double avr = 0;
      int counter = 0;
      foreach (var item in dict) {
        if (counter < 20 || counter > dict.Count - 20) {
          WriteLine($"{item.Key,20} - {item.Value,5}");
        }
        if (counter == 20) WriteLine("\n-----------------------------\n");
        avr += (double)item.Value/size;
        counter++;
      }
      WriteLine($"Одинаковость частот генерации каждого целого числа из интервала (-100, +100) в среднем = {avr, 2:N3}\n");

      WriteLine("\n======Проверка равномерности распределения случайных чисел встроенного генератора Random() для DOUBLE======\n");


      var dict2 = new Dictionary<double, int>();
      for (int i = 0; i < size; i++) {
        //double key =rnd.NextDouble() * (1 + 1) - 1;
        double key = Math.Round(rnd.NextDouble() * (1 + 1) - 1, 11);
        if (dict2.ContainsKey(key))
          dict2[key]++;
        else
          dict2.Add(key, 1);
      }

      avr = 0;
      counter = 0;
      foreach (var item in dict2) {
        if (counter < 20 || counter > dict2.Count - 20) {
          WriteLine($"{item.Key,20} - {item.Value,5}");
        }
        if (counter == 20) WriteLine("\n-----------------------------\n");
        avr += (double)item.Value / size;
        counter++;
      }
      WriteLine($"Одинаковость частот генерации каждого дробного числа из интервала (-1, +1) в среднем = {avr,2:N3}\n");

      counter = 0;
      foreach (var item in dict2) {
        if (item.Value >= 2 && item.Value <= 4) {
          //WriteLine($"{item.Key,20} - {item.Value,5}");
          counter++;
        }
      }
      WriteLine($"Суммарное количество дробный чисел с частотами 2, 3, 4 = {counter}\n");
    }
  }
}
