global using static System.Console;

namespace Homework_11;
class Program {

  static void Main(string[] args) {
    try {
      /*
      Problem 01
      Напишите программу вычисления интеграла от произвольной функции, используя простейший метод суммирования прощади прямоугольников под графиком функции:
      static double Integral(double a, double b, int n, Func<double, double> f),
      где a, b - пределы интегрирования, n = количесто интервалов разбиения, f - интегрируемая функция.

      Вычислите интегралы для различных встроенных и своих (дополнительно) функций. Рассмотрите не менее 3-х вариантов функций.
      Сделайте расчеты с различными n.
      Сравните результаты с точными значениями интегралов, используя известные формулы.
      */

      WriteLine("\n====================Problem 01====================\n");

      Problem_01.Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}
