global using static System.Console;

namespace Classwork_13;

class Program {
  static void Main(string[] args) {
    try {

      /*
      Problem 01 (MinMaxGenerics)
       */

      WriteLine("\n====================Problem 01====================\n");

      Problem_01.Demo();

      /*
     Problem 02
     Напишите обобщенный метод
     public static void RearrangeByDesc<T> . . .
     "переставляющий" три элемента a, b, c обобщенного типа T в порядке убывания.
     */

      WriteLine("\n====================Problem 02====================\n");

      Problem_02.Demo();

      /*
        Problem 03 - GenericListDelegates
        Напишите обобщенные методы методы (опираясь на предыдущую задачу StringListDelegates):

       * Продемонстрируйте их работу на List<string> из текста "Война и мир" 
       * (аналогично демонстрации задачи StringListDelegates, но с добавленными выше методами). 
       */

      WriteLine("\n====================Problem 03====================\n");

      Problem_03.Demo();

      /*
       * Продемонстрируйте их работу на List<int> (большой, рандомный!) 
       * (аналогично демонстрации задачи StringListDelegates, но с добавленными выше методами). 
       */

      Problem_03.Demo2();

      /*
      ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ

     Problem 01
     Реализуйте, опираясь на ранее решенную задачу, класс LinkedList<T> (обобщенный односвязный список). 
      Продемонстрируйте его работу на встроенных и пользовательских (class или struct) типах данных.

     */

      WriteLine("\n====================Problem 01 LinkedList<T>(обобщенный односвязный список)====================\n");

      Problem_01_2.Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}


