global using static System.Console;

namespace Classwork_08 {
  class Program {

    static void Main(string[] args) {
      try {
        /*
        Problem 00 - ArrayListSort
        Измерьте времена сортировки массива целых чисел и List<int> размера size = 1_000_000_000, одинаково заполненных случайными числами в интервале (int.MinValue, int.MaxValue).
        Сравните результаты в режимах Release, x64 и Debug, x64.
        Дома, повторив и усреднив результаты нескольких измерений, составьте сводную таблицу в Excel (см. result.xlsx). 
        */

        WriteLine("\n====================Problem 00====================\n");

        //Problem_00.ArraySort();
        //Problem_00.ListSort();

        /*
        Problem 01
        Напишите метод, проверяющий, являются ли все элементы одномерного массива целых чисел уникальными (неповторяющимися):
        public static bool IsUnique(int[] arr).
        */
        WriteLine("\n====================Problem 01====================\n");

        //Problem_01.Demo();

        /*
        Problem 02
        Напишите метод для сортировки List студентов по фамилии, имени и дате рождения 
        public static int CompareByLastFirstNameBirthday(Student a, Student b).
        Отсортируйте List 10_000_000 студентов.
        Измерьте время сортировки.
        Выведите на печать с помощью Utils.PrintListByLines(studArr).
        */

        WriteLine("\n====================Problem 02====================\n");


        //Problem_02.Demo();

        /*
        Problem 03
        Отсортируйте List 1_000_000 групп в порядке:
         - возрастания по GroupName
         - убывания по GroupId.
        Измерьте время каждой сортировки.
        */


        WriteLine("\n====================Problem 03====================\n");

        //Problem_03.Demo();

        /*
        ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ

        Problem 01 (CountByBinarySearch)
        Создайте массив arr размером size = ??? (1_000_000_000 или больше) случайных целых чисел в интервале (0 - size/10).
        Скопируйте массив arr в массив arrSorted и отсортируйте arrSorted.
        Напишите метод
        public static int GetCountFromSorted(int[] arrSorted, int n),
        в котором способом бинарного поиска находится положение числа n в отсортированном массиве и общее количество его дубликатов (к-во дубликатов возвращается данным методом).
        Проверьте правильность работы GetCountFromSorted с помощью метода
        public static int GetCount(int[] arr, int n),
        который подсчитывает общее количество дубликатов n с помощью полного перебора массива.
        Проведите сравнение скорости работы данных двух методов для достаточно большого значения size (рекомендуется, чтобы общее время ИЗМЕРЕНИЙ не превышало минуты). Измерения провести в режиме Release, x64.

         */
        WriteLine("\n====================Problem_01__CountByBinarySearch====================\n");

        //Problem_01__CountByBinarySearch_.Demo();

        /*
        Problem 02 (StudentsBinarySearch)
        Используется продемонстрированный метод бинарного поиска по ИИН в массиве, 
        отсортированном по ИИН:
        public static int BinarySearchByIIN(Student[] arr, string iIN).

        Создайте вспомогательный массив studSampleArr на основе файла students_1_000_sample.txt, 
        содержащего случайную выборку 1000 студентов из файла students_10_000_000.txt.
        Напишите метод 
        public static void BinarySearchTiming(Student[] studArr,Student[] studSampleArr)
        измеряющий общее время поиска всех 1000 студентов в массиве studArr и выводящий количество 
        найденных и отсутствующих студентов.
        */

        WriteLine("\n====================Problem_02__StudentsBinarySearch====================\n");

        Problem_02__StudentsBinarySearch_.Demo();

      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd . . .");
      ReadLine();
    }
  }
}
