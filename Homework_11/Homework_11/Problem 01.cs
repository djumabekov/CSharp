using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11 {
  internal class Problem_01 {
    /*
    Problem 01
    Напишите программу вычисления интеграла от произвольной функции, используя простейший метод суммирования прощади прямоугольников под графиком функции:
    static double Integral(double a, double b, int n, Func<double, double> f),
    где a, b - пределы интегрирования, n = количесто интервалов разбиения, f - интегрируемая функция.

    Вычислите интегралы для различных встроенных и своих (дополнительно) функций. Рассмотрите не менее 3-х вариантов функций.
    Сделайте расчеты с различными n.
    Сравните результаты с точными значениями интегралов, используя известные формулы.
    */

    static double Integral(double a, double b, int n, Func<double, double> f) {
      double h = (b - a) / n;
      double result = 0;
      for (int i = 1; i <= n; i++) {
        result += f(a + h * (i - 0.5));
      }
      return h * result;
    }

    public static void Demo() {
      double a = 1;
      double b = 5;
      int n;
      double exactResult;

      WriteLine("============Вариант 1============");
      n = 5;
      Func<double, double> f1 = (double x) => x * x;
      exactResult = b * b * b / 3 - a * a * a / 3;

      for (int i = 0; i < n; i++) {
        double res = Integral(a, b, n, f1);
        WriteLine($"i = {i,2} n = {n,12}  {res,18:N10}  {exactResult,6:N2}  diff = {res - exactResult:0.00000000}");
        n *= 10;
      }

      WriteLine("============Вариант 2============");
      n = 5;
      Func<double, double> f2 = (double x) => Math.Sin(x);
      exactResult = -Math.Cos(b) + Math.Cos(a);

      for (int i = 0; i < n; i++) {
        double res = Integral(a, b, n, f2);
        WriteLine($"i = {i,2} n = {n,12}  {res,18:N10}  {exactResult,6:N2}  diff = {res - exactResult:0.00000000}");
        n *= 10;
      }

      WriteLine("============Вариант 3============");
      n = 5;
      Func<double, double> f3 = (double x) => Math.Cos(x);
      exactResult = Math.Sin(b) - Math.Sin(a);

      for (int i = 0; i < n; i++) {
        double res = Integral(a, b, n, f3);
        WriteLine($"i = {i,2} n = {n,12}  {res,18:N10}  {exactResult,6:N2}  diff = {res - exactResult:0.00000000}");
        n *= 10;
      }

      WriteLine("============Вариант 4============");
      n = 5;
      Func<double, double> f4 = (double x) => Math.Sin(x) + Math.Cos(x);
      exactResult = (Math.Sin(b)-Math.Cos(b)) - (Math.Sin(a) - Math.Cos(a));

      for (int i = 0; i < n; i++) {
        double res = Integral(a, b, n, f4);
        WriteLine($"i = {i,2} n = {n,12}  {res,18:N10}  {exactResult,6:N2}  diff = {res - exactResult:0.00000000}");
        n *= 10;
      }

    }

  }
}
