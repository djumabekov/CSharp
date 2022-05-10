using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_13 {
  internal class Problem_03 {
    /*
      Problem 03 - GenericListDelegates
      Напишите обобщенные методы методы (опираясь на предыдущую задачу StringListDelegates):
     */
    public static List<string> GetAllWords(string fileName) {
      char[] delims = { ' ', '.', '!', '?', ',', '(', ')', '\t', '\n', '\r', '-', ';', ':' };


      using var file = new StreamReader(fileName);

      List<string> wordList = new List<string>();

      string line; // строка из файла

      while ((line = file.ReadLine()) != null) // пока строка не null читаем файл
      {
        wordList.AddRange(line.Split(delims, StringSplitOptions.RemoveEmptyEntries)); //для удаления пустых строк
      }

      return wordList;

    }
    public static bool CheckIfAll<T>(List<T> list, Func<T, bool> func) {
      if (list == null)
        throw new Exception("Список не найден!!");
      foreach (T word in list) {
        if (!func(word)) return false;
      }
      return true;
    }
    public static bool CheckIfAny<T>(List<T> list, Func<T, bool> func) {
      if (list == null)
        throw new Exception("Список не найден!!");
      foreach (T word in list) {
        if (func(word)) return true;
      }
      return false;
    }
    public static T FirstOrDefault<T>(List<T> list, Func<T, bool> func) {
      if (list == null)
        throw new Exception("Список не найден!!");
      foreach (T word in list) {
        if (func(word)) return word;
      }
      return default(T);
    }
    public static int FindFirstIndex<T>(List<T> list, Func<T, bool> func) {
      if (list == null)
        throw new Exception("Список не найден!!");
      for (int i = 0; i < list.Count; i++) {
        if (func(list[i])) return i;
      }
      return -1;
    }
    public static int Count<T>(List<T> list, Func<T, bool> func) {
      if (list == null)
        throw new Exception("Список не найден!!");
      int count = 0;
      foreach (T word in list) {
        if (func(word)) count++;
      }
      return count;
    }

    public static T Min<T>(List<T> list) where T : IComparable<T> {
      if (list == null)
        throw new Exception("Список не найден!!");
      T min = list[0];
      foreach (T item in list)
        if (item.CompareTo(min) < 0) min = item;
      return min;
    }
    public static T Min<T>(List<T> list, Func<T, bool> func) where T : IComparable<T> {
      T min = default;
      bool isFound = false;
      foreach (var item in list) {
        if (func(item)) {
          if (!isFound) {
            isFound = true;
            min = item;
          }

          if (min.CompareTo(item) > 0) {
            min = item;
          }
        }
      }
      if (!isFound) throw new Exception("Значение не найдено!!");
      return min;
    }
    public static T Max<T>(List<T> list) where T : IComparable<T> {
      if (list == null)
        throw new Exception("Список не найден!!");
      T max = list[0];
      foreach (T item in list)
        if (item.CompareTo(max) > 0) max = item;
      return max;
    }
    public static T Max<T>(List<T> list, Func<T, bool> func) where T : IComparable<T> {
      T max = default;
      bool isFound = false;
      foreach (var item in list) {
        if (func(item)) {
          if (!isFound) {
            isFound = true;
            max = item;
          }

          if (max.CompareTo(item) < 0) {
            max = item;
          }
        }
      }
      if (!isFound) throw new Exception("Значение не найдено!!");
      return max;
    }
    public static List<T> Where<T>(List<T> list, Func<T, bool> func) {
      if (list == null)
        throw new Exception("Список не найден!!");
      List<T> newList = new List<T>();
      bool isFind = false;
      foreach (T item in list) 
        if (func(item)) { newList.Add(item); isFind = true; }
      if (!isFind) { throw new Exception("Значение не найдено!!"); }
      return newList;
    }

    public static List<T> GetSorted<T>(List<T> list) where T : IComparable<T> {
      if (list == null) 
        throw new Exception("Список не найден!!");
      List<T> newList = list.ToList();
      newList.Sort((T x, T y) => x.CompareTo(y));
      return newList;
    }
    public static List<T> GetSorted<T>(List<T> list, Comparison<T> comparison) {
      if (list == null) 
        throw new Exception("Список не найден!!");
      List<T> newList = list.ToList();
      newList.Sort(comparison);
      return newList;
    }

    public static bool IsSorted<T>(List<T> list) where T : IComparable<T> {
      //list.Sort(); // проверка отработки метода на отсортированный список
      if (list == null) 
        throw new Exception("Список не найден!!");
      for (int i=0; i< list.Count-1; i++) 
        if (list[i].CompareTo(list[i+1]) > 0) 
          return false;
      return true;
    }
    public static bool IsSorted<T>(List<T> list, Comparison<T> comparison) {
      //list.Sort(); // проверка отработки метода на отсортированный список
      if (list == null) 
        throw new Exception("Список не найден!!");
      for (int i = 0; i < list.Count - 1; i++) {
        if (comparison(list[i], list[i+1]) > 0) {
          return false;
        }
      }
      return true;
    }

    public static void Demo() {
      string fileName = @"C:\_0\War_and_Peace-UTF-8.txt";
      List<string> wordList = GetAllWords(fileName);
      WriteLine("======Демонстрация на List<string> из текста \"Война и мир\"======");
      WriteLine("======Выводим слова из книги War and Peace======");
      Utils.PrintListByLines(wordList);

      Func<string, bool> checkWord = (word) => word.Equals("War");
      bool isCheckedWord = CheckIfAll(wordList, checkWord);
      WriteLine($"Все ли слова в книге 'War'?  {isCheckedWord}");

      isCheckedWord = CheckIfAny(wordList, checkWord);
      WriteLine($"Есть ли в книге слово 'War'?  {isCheckedWord}");

      string word = FirstOrDefault(wordList, checkWord);
      WriteLine($"Первое слово, удовлетворяющее условию совпадения с 'War':  {word}");

      int indexOfWord = FindFirstIndex(wordList, checkWord);
      WriteLine($"Индекс первого слова, удовлетворяющее условию совпадения с 'War':  {indexOfWord}");

      int countOfWord = Count(wordList, checkWord);
      WriteLine($"Количество слов, удовлетворяющее условию совпадения с 'War':  {countOfWord}");

      string minOfWord = Min(wordList);
      WriteLine($"Минимальное значение из книги:  {minOfWord}");

      string minOfWordWithFunc = Min(wordList, (word) => word[0].Equals('s'));
      WriteLine($"Минимальное значение из книги начинающееся на 's':  {minOfWordWithFunc}");

      string maxOfWord = Max(wordList);
      WriteLine($"Максимальное значение:  {maxOfWord}");

      string maxOfWordWithFunc = Max(wordList, (word) => word[0].Equals('s'));
      WriteLine($"Максимальное значение из книги начинающееся на 's':  {maxOfWordWithFunc}");

      List<string> list = Where(wordList, (word) => word[0] == 'A');
      WriteLine("Список слов из книги начинающееся на 'A': ");
      Utils.PrintListByLines(list);

      list = GetSorted(wordList);
      WriteLine("Отсортированый cписок по возрастанию: ");
      Utils.PrintListByLines(list);

      list = GetSorted(wordList, (string x, string y) => x.CompareTo(y));
      WriteLine("Отсортированый список по условию comparison: ");
      Utils.PrintListByLines(list);

      bool isSorted = IsSorted(wordList);
      WriteLine($"Список упорядочен?  {isSorted}");

      isSorted = IsSorted(wordList, (string x, string y) => x.CompareTo(y));
      WriteLine($"Список отсортирован по условию comparison:  {isSorted}");

    }

    public static void Demo2() {
      int size = 1_000_000;
      Random rnd = new Random();
      List<int> intList = new List<int>(size);
      for (int i = 0; i < size; i++) {
        intList.Add(rnd.Next(int.MinValue, int.MaxValue));
      }
      int testNumber = intList[rnd.Next(0, intList.Count - 1)];

      WriteLine("\n======Демонстрация на List<int>======\n");
      WriteLine("======Выводим числа из списка======");
      Utils.PrintListByLines(intList);

      Func<int, bool> checkInt = (num) => num.Equals(testNumber);

      bool isCheckedInt = CheckIfAll(intList, checkInt);
      WriteLine($"Все ли в списке числа {testNumber}?  {isCheckedInt}");

      isCheckedInt = CheckIfAny(intList, checkInt);
      WriteLine($"Есть ли в списке число {testNumber}?  {isCheckedInt}");

      int num = FirstOrDefault(intList, checkInt);
      WriteLine($"Первое число, удовлетворяющее условию совпадения с {testNumber}:  {num}");

      int indexOfInt = FindFirstIndex(intList, checkInt);
      WriteLine($"Индекс первого числа, удовлетворяющее условию совпадения с {testNumber} :  {indexOfInt}");

      int countOfInt = Count(intList, checkInt);
      WriteLine($"Количество чисел, удовлетворяющее условию совпадения с {testNumber}:  {countOfInt}");

      int minOfInt = Min(intList);
      WriteLine($"Минимальное число из списка:  {minOfInt}");

      int minOfIntWithFunc = Min(intList, (num) => num % 2 == 0);
      WriteLine($"Минимальное четное значение:  {minOfIntWithFunc}");

      int maxOfInt = Max(intList);
      WriteLine($"Максимальное значение:  {maxOfInt}");

      int maxOfIntWithFunc = Max(intList, (num) => num % 2 == 0);
      WriteLine($"Максимальное четное значение:  {maxOfIntWithFunc}");

      List<int> list = Where(intList, (num) => num % 2 == 0);
      WriteLine("Список всех четных чисел: ");
      Utils.PrintListByLines(list);

      list = GetSorted(intList);
      WriteLine("Отсортированый cписок по возрастанию: ");
      Utils.PrintListByLines(list);

      list = GetSorted(intList, (int x, int y) => x.CompareTo(y));
      WriteLine("Отсортированый список по условию comparison: ");
      Utils.PrintListByLines(list);

      bool isSorted = IsSorted(intList);
      WriteLine($"Список упорядочен?  {isSorted}");

      isSorted = IsSorted(intList, (int x, int y) => x.CompareTo(y));
      WriteLine($"Список отсортирован по условию comparison:  {isSorted}");

    }

  }

}
