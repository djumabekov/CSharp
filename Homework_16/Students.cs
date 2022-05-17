using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_16 {
  /*
  Problem 01
  Назовите файл списка студентов Вашей группы in.txt.
  Прочитав файл, назначьте каждому студенту номер билета из интервала 1 - (к-во студентов) случайным образом.
  Номера билетов не должны повторяться!
   */

  class Student {
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public int TicketNum { get; set; }

    public override string ToString() {
      return $"{LastName} {FirstName}\t{TicketNum}";
    }

    public static int CompareByIIN(Student a, Student b) {
      return a.LastName.CompareTo(b.LastName);
    }

    public static int CompareByTicket(Student a, Student b) {
      return a.TicketNum.CompareTo(b.TicketNum);
    }

    public static Student GetStudentFromLine(string line) {
      int TicketNum;
      string[] words = line.Split('\t');
      int.TryParse(words[0], out TicketNum);
      return new Student { LastName = words[0], FirstName = words[1], TicketNum = TicketNum };
    }


    public static List<Student> GetStudentList(string fileName, int size = 6) {
      List<Student> students = new List<Student>();
      using (var file = new StreamReader(fileName)) {
        string line;
        int count = 0;
        while ((line = file.ReadLine()) != null) {
          students.Add(GetStudentFromLine(line));
          count++;
          if (count == size)
            break;
        }
      }
      return students;
    }

  }
}
