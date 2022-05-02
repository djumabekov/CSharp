using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_09 {

  /*   
  Problem 00
  Создайте абстрактный базовый класс Employee (работник) с абстрактным методом Work().
  Создайте три производных класса: Director, Manager, Worker.
  Переопределите метод Work() для выполнения работы, соответствующей каждому типу работника.
  Напишите методы
  static void DoWork(Employee empl)
  static void DoWork(Employee[] employees)
  static void DoWork(List<Employee> employees)
  Продемонcтрируйте правильную работу всех методов по подобию MainPolymorphismIdeaDemo из демонстрационного проекта).
   */
  public abstract class Employee {
    public abstract void Work();

    static void DoWork(Employee empl) {
      empl.Work();
    }
    static void DoWork(Employee[] employees) {
      foreach (var empl in employees)
        WriteLine($"{empl.Work}");
    }
    static void DoWork(List<Employee> employees) {
      foreach (var empl in employees)
        WriteLine($"{empl.Work}");
    }
  }

  public class Director : Employee {
    public override void Work() {
      WriteLine("Я директор - руковожу компанией");
    }
  }

  public class Manager : Employee {
    public override void Work() {
      WriteLine("Я менеджер - руковожу проектом");
    }
  }

  public class Worker : Employee {
    public override void Work() {
      WriteLine("Я рабочий - работаю работу");
    }
  }

  public class Demo {
      public static void Hello(Employee a) {
        //some work ...
        a.Work();
        //some work ...
      }

      static void HelloList(List<Employee> employee) {
        //some work ...
        foreach (var item in employee) {
          item.Work();
        }
        //some work ...
      }
      static void HelloArray(Employee[] employee) {
        //some work ...
        foreach (var item in employee) {
          item.Work();
        }
        //some work ...
      }

      public static void MainPolymorphismIdeaDemo() {
        Employee director = new Director();
        Employee manager = new Manager();
        Employee worker = new Worker();

        Hello(director); Hello(manager); Hello(worker);
        WriteLine();

        var employeersList = new List<Employee> { director, manager, worker };
        var employeersArray = new Employee[] { director, manager, worker };
        HelloList(employeersList);
        HelloArray(employeersArray);
      }
    }
  }

