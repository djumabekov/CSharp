using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_15 {
  internal class Problem_01 {
    /*
    Problem 01
    Подсчитайте частоту вхождения всех слов в файле "Война и мир - UTF-8.txt".
    Выведите первые и последние 20 слов, отсортированные по частоте вхождения (а внутри - по алфавиту). 
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
    public static void Demo() {
      string fileName = @"C:\_0\Война и мир - UTF-8.txt";

      var dict = new Dictionary<string, int>();
      List<string> wordList = GetAllWords(fileName);
      foreach (var word in wordList) {
        if (dict.ContainsKey(word))
          dict[word]++;
        else
          dict.Add(word, 1);
      }
      WriteLine($"Частота вхождения всех слов в файле \"Война и мир - UTF - 8.txt\" = {dict.Keys.Count}");

      var list = dict.ToList();

      list.Sort((a, b) => {
        int result;
        result = a.Value.CompareTo(b.Value);
        if (result == 0)
          return a.Key.CompareTo(b.Key);
        else
          return result;
      });

      int counter = 0;
      foreach (var item in list) {
        if(counter < 20 || counter > list.Count-20)
          WriteLine($"{item.Key, 20} - {item.Value, 5}");
        if (counter == 20) WriteLine("\n-----------------------------\n");
        counter++;
      }
    }
  }
}
