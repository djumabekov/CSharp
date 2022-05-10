using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_14 {
  internal class Problem_03 {
    /*
    Problem 03 
    Подсчитайте по отдельности количества уникальных StudentID, групп, ИИН, фамилий, имен и дат рождения в файле students_10_000_000.txt.
    */

   
    public static void Demo() {
      int size = 1_000;
      var hashSetGroup = new HashSet<long>();
      var hashSetIIN = new HashSet<string>();
      var hashSetLastname = new HashSet<string>();
      var hashSetFirstname = new HashSet<string>();
      var hashSetBirthdate = new HashSet<DateTime>();

      var studArr = Student.GetStudentArr(Globals.StudentFileName, size);

      foreach (var student in studArr) {
        hashSetGroup.Add(student.GroupId);
        hashSetIIN.Add(student.IIN);
        hashSetLastname.Add(student.LastName);
        hashSetFirstname.Add(student.FirstName);
        hashSetBirthdate.Add(student.Birthday);
      }

      WriteLine($"Count of unic Group = {hashSetGroup.Count}");
      WriteLine($"Count of unic IIN = {hashSetIIN.Count}");
      WriteLine($"Count of unic Lastname = {hashSetLastname.Count}");
      WriteLine($"Count of unic Firstname = {hashSetFirstname.Count}");
      WriteLine($"Count of unic Birthdate = {hashSetBirthdate.Count}");

    }
  }
}
