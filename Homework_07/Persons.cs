namespace Classwork_7 {
  class Persons {
    Person[] _persArr;

    public Persons(Person[] persArr) {
      _persArr = persArr;
    }

    public Person this[long personId] {
      get {
        Person person = null;
        foreach (var item in _persArr) {
          if (item.PersonID == personId)
            person = item;
        }
        return person;
      }
      set {
        for (int i = 0; i < _persArr.Length; i++) {
          if (_persArr[i].PersonID == personId)
            _persArr[i] = value;
        }
      }
    }

    public Person this[string IIN] {
      get {
        Person person = null;
        foreach (var item in _persArr) {
          if (item.IIN.Equals(IIN))
            person = item;
        }
        return person;
      }
      set {
        for (int i = 0; i < _persArr.Length; i++) {
          if (_persArr[i].IIN == IIN)
            _persArr[i] = value;
        }
      }
    }

  }
}
