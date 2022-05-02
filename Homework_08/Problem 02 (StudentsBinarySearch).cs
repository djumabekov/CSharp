using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using UtilsNS;

namespace Classwork_08 {
  internal class Problem_02__StudentsBinarySearch_ {
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

    public static int BynarySearchByIIN(StudentsNS.Student[] studArr, string iIn) {
      int min = 0;
      int max = studArr.Length - 1;
      while (min <= max) {
        // instead of: int mid = (min + max) / 2;
        int mid = min + ((max - min) / 2);
        if (iIn == studArr[mid].IIN) {
          return mid;
        } else if (iIn.CompareTo(studArr[mid].IIN) < 0) {
          max = mid - 1;
        } else {
          min = mid + 1;
        }
      }
      return -1;
    }

    public static void BinarySearchTiming(StudentsNS.Student[] studArr, StudentsNS.Student[] studSampleArr) {
      int countFoundStud = 0;
      for (int i = 0; i < studSampleArr.Length; i++) {
        if (BynarySearchByIIN(studArr, studSampleArr[i].IIN) >= 0) {
          countFoundStud++;
        } 
      }
      WriteLine($"Найдено студентов: {countFoundStud}, не найдено: {studSampleArr.Length - countFoundStud}\n");
    }


    public static void Demo() {
      int size = 1_000;
      var sw = new Stopwatch();

      sw.Restart();
      var studArr = StudentsNS.Student.GetStudentArr(StudentsNS.Globals.StudentFileName, size*100);
      Array.Sort(studArr, StudentsNS.Student.CompareByIIN);
      Utils.PrintArrayByLines(studArr);

      var studSampleArr = StudentsNS.Student.GetStudentArr(StudentsNS.Globals.Student1000SampleFileName, size);//Student1000SampleFileName
      Utils.PrintArrayByLines(studSampleArr);

      BinarySearchTiming(studArr, studSampleArr);
      
      WriteLine($"Общее время поиска 1000 студентов в массиве studArr: {sw.Elapsed}\n");
    }

  }
}
