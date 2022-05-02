using System;
using static System.Console;
using System.Diagnostics;

namespace Classwork_10 {
  public class Problem_03 {
    /*
    ДОПОЛНИТЕЛЬНО

    Problem 03
    В проекте Bechmark_InterfaceVsVirtual реализуйте невиртуальный метод HelloNonVirt 
    (полностью аналогичный виртуальному HelloVirt) и проведите измерения времени работы вариантов:
    */
    interface IMovable {
      void Hello();
    }

    class ClassWithInterface : IMovable {
      public long Count = 0;
      public void Hello() {
        Count++;
      }
    }


    class Animal {
      public long Count = 0;
      public virtual void HelloVirt() {
      }
      public void HelloNonVirt() {
      }
    }


    class Bear : Animal {
      public override void HelloVirt() {
        Count++;
      }
      public new void HelloNonVirt() {
        Count++;
      }
    }


    public static void Demo() {
      long nTimes = 1_000_000_000;
      Animal animal;

      var sw = new Stopwatch();

      // измерение времени работы невиртуального метода
      //. . .
      //. . .


      animal = new Bear();

      sw.Restart();
      for (long i = 0; i < nTimes; i++) {
        animal.HelloVirt();
      }
      sw.Stop();
      WriteLine(animal.Count);
      WriteLine($"animal.HelloVirt() time : {sw.Elapsed}\n");

      sw.Restart();
      for (long i = 0; i < nTimes; i++) {
        animal.HelloNonVirt();
      }
      sw.Stop();
      WriteLine(animal.Count);
      WriteLine($"animal.HelloNonVirt() time : {sw.Elapsed}\n");

      IMovable interf = new ClassWithInterface();
      sw.Restart();
      for (long i = 0; i < nTimes; i++) {
        interf.Hello();
      }
      sw.Stop();
      WriteLine(((ClassWithInterface)interf).Count);
      WriteLine($"interf.Hello() time     : {sw.Elapsed}\n");

      WriteLine("\nEnd . . .");
      ReadLine();
    }
  }
}