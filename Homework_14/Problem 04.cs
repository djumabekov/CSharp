using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_14 {
  internal class Problem_04 {
    /*
    Problem 04 
    Убедитесь в уникальности GroupID и GroupName в файле groups_1_000_000.txt.
     */


    public static void Demo() {
      int size = 1_000;
      var hashSetGroupName = new HashSet<string>();
      var hashSetGroupId = new HashSet<long>();

      var groupArr = Group.GetGroupsArr(Globals.GroupFileName, size);

      foreach (var group in groupArr) {
        hashSetGroupName.Add(group.GroupName);
        hashSetGroupId.Add(group.GroupId);
      }
      WriteLine($"Count of Group Name = {hashSetGroupName.Count} | {size}");
      WriteLine($"Count of Group Id = {hashSetGroupId.Count} | {size}");

      if (hashSetGroupName.Count == size) WriteLine("GroupName уникальны"); else WriteLine("GroupName не уникальны");
      if (hashSetGroupId.Count == size) WriteLine("GroupID уникальны"); else WriteLine("GroupID не уникальны");

    }
  }
}
