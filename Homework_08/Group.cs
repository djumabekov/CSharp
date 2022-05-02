namespace StudentsNS;
class Group {
  public long GroupId { get; set; }
  public string GroupName { get; set; }


  public override string ToString() {
    return $"{GroupId} {GroupName}";
  }


  private static Group GetGroupFromLine(string line) {
    string[] words = line.Split('\t');
    long groupId = Int64.Parse(words[0]);
    return new Group { GroupId = groupId, GroupName = words[1] };
  }



  public static Group[] GetGroupsArr(string fileName, int size = 1_000_000) {
    Group[] groups = new Group[size];
    using (var file = new StreamReader(fileName)) {
      string line;
      int count = 0;
      while ((line = file.ReadLine()) != null) {
        groups[count++] = GetGroupFromLine(line);
        if (count == size)
          break;
      }
    }
    return groups;
  }



  public static List<Group> GetGroupsList(string fileName, int size = 1_000_000) {
    var groups = new List<Group>();
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
}

