using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using UtilsNS;

namespace Classwork_08 {
  internal class Problem_02 {
    /*
    Problem 02
    Напишите метод для сортировки List студентов по фамилии, имени и дате рождения 
    public static int CompareByLastFirstNameBirthday(Student a, Student b).
    Отсортируйте List 10_000_000 студентов.
    Измерьте время сортировки.
    Выведите на печать с помощью Utils.PrintListByLines(studArr).
     */

    public static int CompareByLastFirstNameBirthday(StudentsNS.Student a, StudentsNS.Student b) {

        int result = a.LastName.CompareTo(b.LastName);
        if (result != 0)
          return result;
        else if(a.FirstName.CompareTo(b.FirstName) != 0) 
          return a.FirstName.CompareTo(b.FirstName);
        else 
          return a.Birthday.Date.CompareTo(b.Birthday.Date);
    }

    public static void Demo() {
      int size = 100_000;
      var sw = new Stopwatch();

      sw.Restart();
      List<StudentsNS.Student> studArr = StudentsNS.Student.GetStudentList(StudentsNS.Globals.Student1000SampleFileName, size);//Student1000SampleFileName

      studArr.Sort(CompareByLastFirstNameBirthday);
      WriteLine($"Sorting student list time: {sw.Elapsed}\n");

      WriteLine("Students:");
      Utils.PrintListByLines(studArr);
    }
  }
}
