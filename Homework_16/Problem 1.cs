using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_16 {
  internal class Problem_1 {
    /*
     Problems 01 - 02
      ExamTickets.txt
     */
    public static bool IsUnique(List<int> ticketList) {
      var tempList = ticketList;
      tempList.Sort();
      for (int i=0; i<tempList.Count-1; i++) {
        if (ticketList[i].Equals(ticketList[i + 1])) return false;
      }
      return true;
    }
  public static void Demo() {
      string fileName = @"in.txt";

      string fileOutName1 = @"out1.txt";
      using var outFile1 = new StreamWriter(fileOutName1);

      string fileOutName2 = @"out2.txt";
      using var outFile2 = new StreamWriter(fileOutName2);

      List<Student> students = Student.GetStudentList(fileName);

      var rnd = new Random();

      List<int> tickets = new List<int>();
      int counter = 0;
      while (counter < students.Count) {
        int value = rnd.Next(1, students.Count+1);
        if (!tickets.Contains(value)) {
          tickets.Add(value);
          WriteLine($"{tickets[counter]}");
          counter++;
        }
      }

      for (int i=0; i<students.Count; i++) {
        students[i].TicketNum = tickets[i];
        WriteLine($"{students[i]}");
      }

      students.Sort((a, b) => a.LastName.CompareTo(b.LastName));
      if (IsUnique(tickets)) {
        for (int i = 0; i < students.Count; i++) {
          outFile1.WriteLine($"{i}\t{students[i]}");
        }
      }

      students.Sort((a, b) => a.TicketNum.CompareTo(b.TicketNum));
      if (IsUnique(tickets)) { 
        for (int i = 0; i < students.Count; i++) {
            outFile2.WriteLine($"{i}\t{students[i]}");
        }
      }
        
    }
  }
}

