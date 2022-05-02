using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classwork_10.RunnaleClasses;

namespace Classwork_10 {
  internal class Problem_00__IRunnable_ {
    /*
    Problem 00 (IRunnable) - реализации задачи Vehicles с помощью интерфейса.
    В отдельном файле IRunnable.cs создайте интерфейс
    interface IRunnable {
	    double MaxSpeed { get; set; }
	    double Speed { get; set; }
	    void Run(double speed);
    }

    В отдельном файле RunnaleClasses.cs создайте классы  Car, Track, Man, Bear, реализующие IRunnable.
    public class Bear : IRunnable { 
    . . .	

    В классах:
    Конструктор, в котором устанавливается разумная максимальная скорость MaxSpeed для данного типа.

    Метод Run, приводящий объект в движение, в том числе, задающий скорость Speed:
    public void Run(double speed) {
      //ограничьте скорость (не более MaxSpeed, учитывая тип объекта)
      //Speed = speed, если speed < MaxSpeed;   
      WriteLine($"( Car, Track, Man, Bear) движется со скоростью {Speed}");
    }  

    В static class IRunnableDemo напишите методы:
    public static void Run(List<IRunnable> runnables, double speed)
    public static double GetAverageSpeed(List<IRunnable> runnables)

    Продемонстрируйте работу методов:
    public static void Demo() {
	    var objects = new List<IRunnable>() { new Car(), new Car(), new Truck(), new Man(), new Bear(), };

	    Run(objects, 2000);
	    WriteLine($"\nСредняя скорость = {GetAverageSpeed(objects)}\n");

	    Run(objects, 70);
	    WriteLine($"\nСредняя скорость = {GetAverageSpeed(objects)}\n");
    }
    */
    public static class IRunnableDemo{
      public static void Run(List<IRunnable> runnables, double speed) {
        foreach(var obj in runnables) {
          obj.Run(speed);
        }
      }

      public static double GetAverageSpeed(List<IRunnable> runnables) {
        double avrSpeed = 0;
        foreach (var obj in runnables) {
          avrSpeed += obj.Speed;
        }

        //avrSpeed = runnables.Average(obj => obj.Speed);

        return avrSpeed / runnables.Count;
      }
      public static void Demo() {
        var objects = new List<IRunnable>() { new Car(100), new Track(60), new Man(10), new Bear(20)};

        Run(objects, 5);
        WriteLine($"\nСредняя скорость = {GetAverageSpeed(objects)}\n");

        Run(objects, 7);
        WriteLine($"\nСредняя скорость = {GetAverageSpeed(objects)}\n");
      }
    }
 }
}
