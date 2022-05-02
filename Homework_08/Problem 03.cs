using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using UtilsNS;

namespace Classwork_08 {
  internal class Problem_03 {
    /*
     
    Problem 03
    Отсортируйте List 1_000_000 групп в порядке:
     - возрастания по GroupName
     - убывания по GroupId.
    Измерьте время каждой сортировки.
    */

    public static void Demo() {
      int size = 100_000;
      var sw = new Stopwatch();

      sw.Restart();
      var groupArr = StudentsNS.Group.GetGroupsArr(StudentsNS.Globals.GroupFileName, size);//Student1000SampleFileName

      Array.Sort(groupArr, (a, b)=>a.GroupName.CompareTo(b.GroupName));
      WriteLine($"Sorting Group by Name (ASC) time: {sw.Elapsed}\n");

      WriteLine("Group:");
      Utils.PrintArrayByLines(groupArr);

      Array.Sort(groupArr, (a, b) => -a.GroupId.CompareTo(b.GroupId));
      WriteLine($"Sorting Group by Id (DESC) time: {sw.Elapsed}\n");

      WriteLine("Group:");
      Utils.PrintArrayByLines(groupArr);
    }
  }
}
