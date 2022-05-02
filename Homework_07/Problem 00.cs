using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Classwork_7 {
  /*

ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ

Problem 00
Добавить в класс Persons  индексатор по ИИН:
public Person this[string IIN] 
Продемонстрировать чтение - запись с его помощью.
 */
  internal class Problem_00 {

    public static void PersonsDemo() {
      Person[] persArr = {
        new Person { PersonID = 10, IIN = "111111111111", LastName = "Smith", FirstName = "Sean" },
        new Person { PersonID = 5, IIN = "222222222222", LastName = "Karimov", FirstName = "Karim" },
        new Person { PersonID = 4, IIN = "333333333333", LastName = "Ivanov", FirstName = "Ivan" },
        new Person { PersonID = 20, IIN = "", LastName = "Borisov", FirstName = "Boris" },
        new Person { PersonID = 15, IIN = "555555555555", LastName = "Abramov", FirstName = "Abram" },
      };

      //by students -indexer by IIN:
      var persons = new Persons(persArr);
      Person person; 
      long newId = 444; 
      string newINN = "444444444444", newLastName = "Abaev", newFirstName = "Abai";
      Person newPerson = new Person { PersonID = newId, IIN = newINN, LastName = newLastName, FirstName = newFirstName };

      person = persons["555555555555"];
      WriteLine($"{person}");
      persons["555555555555"] = newPerson;
      person = persons[newINN];
      WriteLine($"{person}");
    }
  }
}

