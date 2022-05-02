namespace Classwork_7 {
  class Person {
    public long PersonID { get; set; }
    public string IIN { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }


    public override string ToString() {
      return $"{PersonID} - {IIN} {LastName} {FirstName}";
    }
  }
}
