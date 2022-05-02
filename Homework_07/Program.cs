using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_7 {
  class Program {

    static void Main(string[] args) {
      try {
        /*
        Problem 01
        Написать extention method для класса string HelloTo().
        Например:
        WriteLine("Pooh".HelloTo());
        WriteLine(studentName.HelloTo());
        WriteLine("Пятачок".HelloTo());
        */

        WriteLine("\n====================Problem 01====================\n");

        string studentName = "Vasya";
        WriteLine("Pooh".HelloTo());
        WriteLine(studentName.HelloTo());
        WriteLine("Пятачок".HelloTo());

        /*
        Problem 02
        По подобию метода GetIntArray в Utils, напишите метод 
        public static List<int> GetIntList(int size, int min = 0, int max = int.MaxValue),
        возвращающий List случайных чисел.
         */

        WriteLine("\n====================Problem 02====================\n");

        List<int> list = Problem_02.GetIntList(10, 1, 100);
        Write($"{list.Count}, ");
        foreach (int item in list) Write($"{item}, ");
        WriteLine("\n\n");
        /*     
        Problem 03
        Напишите метод
        public static List<int> GetSomeEvensList(int max),
        возвращающий все положительные целые четные числа меньше max, не делящиеся на 5.
         */

        WriteLine("\n====================Problem 03====================\n");

        list = Problem_03.GetSomeEvensList(100);
        foreach (int item in list) Write($"{item}, ");

        /*
        Problem 04 - GetOddEvenArrays
        Напишите метод, возвращающий кортеж из массивов нечетных и четных чисел, извлекаемых из переданного массива целых чисел:
        public static (int[] oddArr, int[] evenArr) GetOddEvenArrays(int[] arr).
        Для создания массива используйте Utils.GetIntArray, для распечатки - Utils.PrintArray(arrOdd); Utils.PrintArray(arrEven);
        Выполните проверку:
        WriteLine($"oddArr.Length + evenArr.Length == arr.Length: {oddArr.Length + evenArr.Length == arr.Length}");
         */

        WriteLine("\n====================Problem 04====================\n");

        (List<int> evenArr, List<int> oddArr) =  Problem_04.GetOddEvenArrays(list);
        WriteLine("\n\n evenArr:");
        foreach (int item in evenArr) Write($"{item}, ");
        WriteLine("\n\n oddArr:");
        foreach (int item in oddArr) Write($"{item}, ");

        /*
         Problem 05 - GetOddEvenLists
        Решите предыдущую задачу, используя List<int>.
        public static (List<int> oddList, List<int> evenList) GetOddEvenLists(int[] arr) 

        Реализуйте метод распечатки
        public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0)
        по подобию PrintArray<T>, или воспользуйтесь кодом:
        public static void PrintList<T>(List<T> list, int width = 8, int decimals = 0) {
	        PrintArray<T>(list.ToArray(), width, decimals);
        }

        Выполните проверку:
        WriteLine($"oddList.Count + evenList.Count == arr.Length: {oddList.Count + evenList.Count == arr.Length}");

        Обсудите преимущества данного подхода по сравнению с предыдущим.
         */

        WriteLine("\n====================Problem 05====================\n");

        (evenArr, oddArr) = Problem_04.GetOddEvenArrays(list);
        WriteLine("\n\n evenArr:");
        Problem_05.PrintList<int>(evenArr);
        WriteLine("\n\n oddArr:");
        Problem_05.PrintList<int>(oddArr);

        /*
         Problem 06
        Напишите метод, возвращающий кортеж из двух List<int> - чисел до первого вхождения числа splitter включительно и остальных.
        public static (List<int> firstList, List<int> secondList) GetSomeLists(int[] arr, int splitter).
         */

        WriteLine("\n====================Problem 06====================\n");

        (List<int> firstList, List<int> secondList) = Problem_06.GetSomeLists(list, 51);
        WriteLine("\n\n firstList:");
        Problem_05.PrintList<int>(firstList);
        WriteLine("\n\n secondList:");
        Problem_05.PrintList<int>(secondList);

        /*
        Problem 07
        Реализуйте следующие extention методы для класса String:
        DeleteSpaces() - удалить пробелы, переводы строк и символы табуляции 
        GetChar(int n) - символ в позиции n
        DeleteChars(char ch) - удалить все символы ch
        IsInt() - является ли строка представлением int (можно ли конвертировать?)
        IsDouble() - является ли строка представлением double (можно ли конвертировать?) 
        ToInt() - конвертация в int
        ToDouble() - конвертация в double

        Приведите пример использования fluent - способа вызова метода DeleteSpaces() вместе с другими библиотечными или собственными методами.
         */

        WriteLine("\n====================Problem 07====================\n");

        Problem_07.DemoExtentions();

        /*
     
        ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ

        Problem 00
        Добавить в класс Persons  индексатор по ИИН:
        public Person this[string IIN] 
        Продемонстрировать чтение - запись с его помощью.
         */
        WriteLine("\n====================Problem 00====================\n");

        Problem_00.PersonsDemo();

        /*
         Problem 01
        Проверьте, являются ли все IIN в файле students_10_000_000.txt уникальными.
        При решении задачи используйте тип List вместо array!
        Внесите изменения в исходный текстовый файл, чтобы убедиться в правильности Вашего решения.
        В коде решения приведите необходимые пояснения.
         */
        WriteLine("\n====================Problem 01====================\n");

        string studentFileName = @"C:\_0\students_10_000_000.txt";

        var studArr = Student.GetStudentsArr(studentFileName, 1000);
        WriteLine($"\nStudents array. Size = {studArr.Count}\n");
        Student.PrintArray(studArr);

        WriteLine($"\nSorted By IIN Students array. Size = {studArr.Count}\n");
        (bool isIINUnic, string IIN) = Student.CheckUnicIIN(studArr); //получаем результат проверки уникальности ИИН
        Student.PrintArray(studArr);

        WriteLine($"\nИИН студентов уникальны? = {(isIINUnic ? "Да, все в порядке!" : $"Нет, найден первый неуникальный ИИН: {IIN}")}\n");

      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd . . .");
      ReadLine();
    }
  }
}
