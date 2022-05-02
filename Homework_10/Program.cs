global using static System.Console;

namespace Classwork_10;
class Program {

  static void Main(string[] args) {
    try {
      /*   
      Problem 00 (IRunnable) - реализации задачи Vehicles с помощью интерфейса.
      */

      WriteLine("\n====================Problem 00====================\n");

      Problem_00__IRunnable_.IRunnableDemo.Demo();

      /*   
      Problem 01 - IValuable
      */

      WriteLine("\n====================Problem 01====================\n");

      Problem_01___IValuable.ValuableDemo.Demo();

     /*   
    Problem 02 - IValuableWithPtoperty 
    Аналогично Problem 01, но для интерфейса со свойством Value(вместо метода GetValue).
     */

    WriteLine("\n====================Problem 02====================\n");

    Problem_02___IValuableWithPtoperty.Demo();

    /*
    ДОПОЛНИТЕЛЬНО

    Problem 03
    В проекте Bechmark_InterfaceVsVirtual реализуйте невиртуальный метод HelloNonVirt 
    (полностью аналогичный виртуальному HelloVirt) и проведите измерения времени работы вариантов:
    */

    WriteLine("\n====================Problem 03====================\n");

    Problem_03.Demo();


    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    WriteLine("\nEnd . . .");
    ReadLine();
  }
}
