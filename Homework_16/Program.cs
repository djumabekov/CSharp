global using static System.Console;

namespace Classwork_16;
class Program {

  static void Main(string[] args) {
    try {

      /*
       Problems 01 - 02
        ExamTickets.txt
       */

      WriteLine("\n====================Problem 01====================\n");

      Problem_1.Demo();

      /*
       Problem 02
      По мотивам идеи предыдущей задачи, напишите метод
      static int[] MakeTossArray(int size),
      возвращающий массив интервала 1 - size, переставленных случайным образом.
      */

      WriteLine("\n====================Problem 02====================\n");

      Problem_02.Demo();

      /*
      Problem 03 - ReplaceInFile
      Напишите программу, создающую файл ReplaceInFile.exe, при запуске которого с параметрами
      ReplaceInFile.exe oldFileName, newFileName, oldSubString, newSubString
      происходит создание файла newFileName, в котором все подстроки (слова, в частности) oldSubString заменены на newSubString.
      Например:
      ReplaceInFile.exe "C:\_0\Война и мир - UTF-8.txt", "Война и мир - new.txt", "CHAPTER  ", "ГЛАВА - "

      ДОПОЛНИТЕЛЬНО
      В случае запуска с ТРЕМЯ параметрами
      ReplaceInFile.exe fileName, oldSubString, newSubString
      Происходит переписывание файла fileName с осуществленной заменой подстрок.
       */

      WriteLine("\n====================Problem 03====================\n");

      Problem_03.ReplaceInFile(args);

      /*
      ДОПОЛНИТЕЛЬНАЯ ЗАДАЧА

       Problem 04
       Напишите метод 
       public static int[] GetUniqueRandomArray(int size, int min = 0, int max = int.MaxValue)
       возвращающий случайный массив НЕПОВТОРЯЮЩИХСЯ целых чисел в заданном интервале. Все числа из интервала [min, max] должны иметь равную вероятность появления в итоговом массиве.

       Обеспечьте максимально быструю скорость формирования массива!

       Возвращаемый массив проверяйте на уникальность чисел с помощью метода
       static bool IsUnique(int[] arr).
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
