using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_14 {
  internal class Problem_01 {
    /*
    Problem 01 
    Подсчитайте количество различных слов в тексте "Война и мир" (файл "Война и мир - UTF-8.txt") с помощью HashSet. 
    Выведите, также, и общее количество слов.
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

      var hashSet = new HashSet<string>();
      List<string> wordList = GetAllWords(fileName);

      foreach (var word in wordList) {
        hashSet.Add(word);
      }
      int count = hashSet.Count;
      WriteLine($"Количество различных слов в тексте \"Война и мир\" = {count}");
    }
  }
}
