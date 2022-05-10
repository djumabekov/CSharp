global using static System.Console;

namespace Classwork_14;

class Program {
  static void Main(string[] args) {
    try {
      /*
      Problem 01 
      Подсчитайте количество различных слов в тексте "Война и мир" (файл "Война и мир - UTF-8.txt") с помощью HashSet. 
      Выведите, также, и общее количество слов.
      */

      WriteLine("\n====================Problem 01====================\n");

      Problem_01.Demo();

      /*
      Problem 02
      Определите, когда начнут повторяться rnd.Next(int.MinValue, int.MaxValue) 
      с какого раза (timesBeforeFirstRepeat) и с какого числа (valueFirstRepeat).
      Выведите на консоль результаты 100(?) измерений. Каждый раз создавайте новый new Random(i), 
      где i - переменная цикла.
      Выведите среднее значение timesBeforeFirstRepeat (количество вызовов rnd.Next до первого повторения).
      */

      WriteLine("\n====================Problem 02====================\n");

      Problem_02.Demo();

      /*
      Problem 03 
      Подсчитайте по отдельности количества уникальных StudentID, групп, ИИН, фамилий, имен и дат рождения в файле students_10_000_000.txt.
      */

      WriteLine("\n====================Problem 03====================\n");

      Problem_03.Demo();

      /*
      Problem 04 
      Убедитесь в уникальности GroupID и GroupName в файле groups_1_000_000.txt.
       */

      WriteLine("\n====================Problem 04====================\n");

      Problem_04.Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}

