using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Classwork_15;
/*
 ОСНОВНЫЕ ЗАДАЧИ

 Problem 01 (GetStudentsArray.txt) 
 Измерьте времена создания массивов 1_000_000 групп и 10_000_000 студентов в режиме - x64, Release. 

 */
public class Group {
  public long GroupId { get; set; }
  public string GroupName { get; set; }

  public override string ToString() {
    return $"{GroupId} {GroupName}";
  }


  public static Group GetGroupFromLine(string line) {
    string[] words = line.Split('\t');
    long groupId = Int64.Parse(words[0]);
    return new Group() { GroupId = groupId, GroupName = words[1] };
  }



  public static Group[] GetGroupsArr(string fileName, int size = 1_000_000) {
    Group[] groups = new Group[size];
    using (var file = new StreamReader(fileName)) {
      string line;
      int count = 0;
      while ((line = file.ReadLine()) != null) {
        groups[count++] = GetGroupFromLine(line);
        //Group group = GetGroupFromLine(line);
        //groups[count] = group;
        //count++;
        if (count == size)
          break;
      }
    }
    return groups;
  }



  public static List<Group> GetGroupsList(string fileName, int size = 1_000_000) {
    List<Group> groups = new List<Group>();
    using (var file = new StreamReader(fileName)) {
      string line;
      int count = 0;
      while ((line = file.ReadLine()) != null) {
        groups.Add(GetGroupFromLine(line));
        if (count == size)
          break;
      }
    }
    return groups;
  }


  public static void PrintArray(Group[] arr) {

    int size = arr.Length;
    if (size <= 8) {
      for (int i = 0; i < size; i++) {
        Write(arr[i]);
      }
    } else {
      for (int i = 0; i < 4; i++) {
        Write(arr[i]);
      }
      Write(" . . . .");
      for (int i = size - 4; i < size; i++) {
        Write(arr[i]);
      }
    }
    WriteLine();
  }


  public static Group[] GetGroupsArr(string fileName, out int nGoodGroups, int size = 0) {
    Group[] groups = new Group[size];
    using (var file = new StreamReader(fileName)) {
      nGoodGroups = 0;
      string line;
      int count = 0;
      while ((line = file.ReadLine()) != null) {
        try {
          groups[count++] = GetGroupFromLine(line);
          nGoodGroups++;
        } catch (Exception ex) {
          WriteLine(ex.Message);
        }
        if (count == size)
          break;
      }
    }
    return groups;
  }
}
