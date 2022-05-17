using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam {
  internal class Problem_03 {
    /*
     Problem 03
    Используя файл students_10_000_000.txt, найдите повторяющиеся (неуникальные) 
    первые 6 символов IIN и выведите их отсортированный список с указанием 
    частоты повторения в файл results.txt.
    */
    private static string GetIINFromLine(string line) {
      string[] words = line.Split('\t');
      return words[1];
    }

    public static List<string> GetDateStudentsIIN(string fileName, int size = 0) {
      List<string> ListByIIN = new List<string>();
      using (var file = new StreamReader(fileName)) {
        string line;
        int count = 0;
        while ((line = file.ReadLine()) != null) {
          ListByIIN.Add(GetIINFromLine(line).Substring(0, 6));
          count++;
          if (count == size)
            break;
        }
      }
      return ListByIIN;
    }



    public static void Demo() {
      int size = 10_000_000;
      string stufFileName = @"C:\_0\students_10_000_000.txt";
      var studentsIIN = GetDateStudentsIIN(stufFileName, size);

      var dict = new Dictionary<string, int>();
      foreach (var IIN in studentsIIN) {
        if (dict.ContainsKey(IIN))
          dict[IIN]++;
        else
          dict.Add(IIN, 1);
      }

      var list = dict.ToList();

      list.Sort((a, b) => {
        int result;
        result = a.Value.CompareTo(b.Value);
        if (result == 0)
          return a.Key.CompareTo(b.Key);
        else
          return result;
      });

      for (int i = 0; i < list.Count; i++) { 
        
      }

      int counter = 0;
      foreach (var item in list) {
        if (counter < 20 || counter > list.Count - 20)
          WriteLine($"{item.Key,20} - {item.Value,5}");
        if (counter == 20) WriteLine("\n-----------------------------\n");
        counter++;
      }

      const string _fileName = "results.txt";
      using var file = new StreamWriter(_fileName);
      foreach (var item in dict) {
        file.WriteLine($"{item.Key,20} - {item.Value,5}");

      }

    }
  }
}
