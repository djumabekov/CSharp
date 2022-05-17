using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classwork_16 {
  internal class Problem_03 {
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

    public static void ReplaceInFile(string[] args) {
      try {


  
        /*
        Проверка с 3 параметрами:
        ReplaceInFile.exe "C:\_0\Война и мир - UTF-8.txt" "Page" "Страница" 
         */

        if ((args.Length == 3) && args[0] != null && args[1] != null && args[2] != null) {
          string oldFileName = args[0];
          string oldSubString = args[1];
          string newSubString = args[2];
          string fileOutName = @"temp.txt";

          string line;
          using var file1 = new StreamReader(oldFileName);
          using var file2 = new StreamWriter(fileOutName);

          while ((line = file1.ReadLine()) != null) {
            string newLine = line.Replace(oldSubString, newSubString);
            //WriteLine(line);
            file2.WriteLine($"{newLine}");
          }
          file1.Close();
          file2.Close();
          File.Replace(fileOutName, oldFileName, fileOutName+".bac", false);

          WriteLine("File has been written");
        }

        /*
         Проверка с 4 параметрами:
        ReplaceInFile.exe "C:\_0\Война и мир - UTF-8.txt" "Война и мир - new.txt" "Page" "Страница"   
        */
        if ((args.Length == 4) && args[0] != null && args[1] != null && args[2] != null && args[3] != null) {
          string oldFileName = args[0];
          string newFileName = args[1];
          string oldSubString = args[2];
          string newSubString = args[3];
          string line;
            using var file1 = new StreamReader(oldFileName);
            using var file2 = new StreamWriter(newFileName);
            while ((line = file1.ReadLine()) != null) {
              string newLine = line.Replace(oldSubString, newSubString);
              //WriteLine(line);
              file2.WriteLine($"{newLine}");
            }
            WriteLine("File has been written");
          }
      } catch (Exception ex) {
        WriteLine(ex.Message);
      }
    }

  }
}
