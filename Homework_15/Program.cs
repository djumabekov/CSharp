global using static System.Console;

namespace Classwork_15;
class Program {

  static void Main(string[] args) {
    try {

      /*
       Problem 01
       Подсчитайте частоту вхождения всех слов в файле "Война и мир - UTF-8.txt".
       Выведите первые и последние 20 слов, отсортированные по частоте вхождения (а внутри - по алфавиту). 
        */

      WriteLine("\n====================Problem 01====================\n");

      Problem_01.Demo();

      /*
       Problem 02
        Реализуйте класс Students с методами быстрого поиска по StudentID и IIN:
        class Students {
          Dictionary<long, Student> _dictByID = new Dictionary<long, Student>();
          Dictionary<string, Student> _dictByIIN = new Dictionary<string, Student>();

          public Students(string fileName, int size = 0) {	. . .

          public Student FindByID(long studentID) { . . .

          public Student FindByIIN(string iIN) { . . .
        }	

        Реализуйте класс Groups с методом быстрого поиска по GroupID:
          public Group FindByID(long groupID) { . . .
      */

      WriteLine("\n====================Problem 02====================\n");

      Problem_02.Demo();

      /*
      Problem 03
      Проверьте равномерность распределения случайных чисел встроенного генератора Random(), проведя исследование последовательности из 10_000_000 (или более) целых чисел rnd.Next(-100, +100).
      Критерием равномерности служит одинаковость частот генерации каждого числа из интервала (-100, +100) в среднем.

      Повторите исследование с вещественными числами в интервале (-1, +1).
      Выведите суммарные количества чисел с частотами 2, 3, 4. 
       */

      WriteLine("\n====================Problem 03====================\n");

      Problem_03.Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}
