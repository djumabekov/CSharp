using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classwork_17 {
  internal class Problem_05 {
    /*
     Problem 05
      В тексте "Война и мир - UTF-8.txt" найдите:
       - самое длинное предложение (или несколько) в отношении количества букв с учетов всех символов, включая пробелы
       - самое длинное предложение (или несколько) в отношении количества слов
       - все предложения, содержащие заданное количество символов (выведите в отсортированном по алфавиту порядке)
       - все предложения, содержащие заданное количество заданного символа (выведите в отсортированном по алфавиту порядке)
    */

    public static (int, int, List<string>, List<string>) BigSentencesByLettersInFile(int lettersCount, char sym, int symCount) {
      string s = null;

      int count = 0;
      List<int> words = new List<int>();
      List<string> sentenseLessThenLettersCount = new List<string>();
      List<string> sentenseLessThenLettersCountAndContainsSym = new List<string>();
      try {
        string FileName = @"C:\_0\Война и мир - UTF-8.txt"; ;
        string line;
        using var file = new StreamReader(FileName);
        string temp = "Война и мир.";

        string sentence="";
        while ((line = file.ReadLine()) != null) {
          sentence += line; // new string(line.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToString());
          //WriteLine($"{sentence}");

        }
        char[] separators = { '.', '!', '?', };
        List<string> sentences = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
        char[] separators2 = { ' ', ',', };
        count = 0;
        foreach (var item in sentences) {
          count = item.Split(separators2, StringSplitOptions.RemoveEmptyEntries).ToList().Count;
          words.Add(count);
        }

        foreach (var item in sentences) {
          if (item.Length == lettersCount) {
            sentenseLessThenLettersCount.Add(item);
          }
        }


        foreach (var item in sentences) {
          count = 0;
          if (item.Contains(sym)) {
            for (int i = 0; i < item.Length; i++) {
              if (item[i] == sym) {
                count++;
              }
            }
            if (count == symCount) {
              sentenseLessThenLettersCountAndContainsSym.Add(item);
            }
          }
        }

       s = sentences[0];
        foreach (var item in sentences) {
          if (item.Length > s.Length) { 
            s = item;
          }
        }
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      return (s.Length, words.Max(), sentenseLessThenLettersCount, sentenseLessThenLettersCountAndContainsSym);
    }

    public static void Demo() {
      int sentLength = 60;
      int symCount = 3;
      char sym = 'ц';

     (int bigSentenseByLetters, int bigSentenseByWords, var sentenseLessThenLetter, var sentenseLessThenLettersCountAndContainsSym) = BigSentencesByLettersInFile(sentLength, sym, symCount);

      Write($"\nСамое длиное предложение в файле 'Война и мир - UTF-8.txt':\n {bigSentenseByLetters} букв. \n");
      Write("\n---------------------------------------------------\n");
      Write($"\nСамое длиное предложение в файле 'Война и мир - UTF-8.txt' содержит {bigSentenseByWords} слов. \n");
      Write("\n---------------------------------------------------\n");
      Write($"\nвсе предложения, содержащие заданное количество символов({sentLength}): \n");
      Utils.PrintListByLines(sentenseLessThenLetter);
      Write("\n---------------------------------------------------\n");
      Write($"\nВсе предложения, содержащие заданное количество заданного символа ('{sym}', {symCount}) : \n");
      Utils.PrintListByLines(sentenseLessThenLettersCountAndContainsSym);
    }

  }
}
