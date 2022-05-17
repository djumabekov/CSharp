global using static System.Console;

namespace Exam;
class Program {

  static void Main(string[] args) {
    try {
      /*
     Problem 01
      Найдите строки матрицы размером 10_000 * 10_000, содержащие наибольшее количество отрицательных чисел.  
      */
      WriteLine("\n====================Problem 01====================\n");

      Problem_01.Demo();

      /*
     Problem 02
      В массиве случайных целых чисел размером size = 100_000_000 найдите все отрицательные числа, встречающиеся менее n раз.
      int[] GetNumbers(int[] arr, int n)
     */
      WriteLine("\n====================Problem 02====================\n");

      //Problem_02.Demo();

      /*
      Problem 03
     Используя файл students_10_000_000.txt, найдите повторяющиеся (неуникальные) 
     первые 6 символов IIN и выведите их отсортированный список с указанием 
     частоты повторения в файл results.txt.
     */
      WriteLine("\n====================Problem 03====================\n");

     // Problem_03.Demo();


    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}
