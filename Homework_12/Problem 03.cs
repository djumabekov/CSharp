using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_12 {
  internal class Problem_03 {
    /*
    Problem 03
    Измените код проекта Sensor так, чтобы клиенты получали информацию о событиях HighTemp, 
    LowTemp только при первом наступлении данных событий. Исключите дублирование вывода информации, 
    например в случае, если температура достигла tMax и пока не опускается ниже tMin.
    */
    delegate void AlarmHandler();
    //or can use Action()! 

    class Sensor {
      public event AlarmHandler HighTemp;
      public event AlarmHandler LowTemp;

      readonly double _tempMin = -5;
      readonly double _tempMax = 15;

      bool _isSleep { get; set; }

      double _temperature;

      public double Temperature {
        get { return _temperature; }
        set {
          _temperature = value;
          if (value > _tempMax & _isSleep) {
            if (HighTemp != null) {
              HighTemp();
              _isSleep = false;
            }
          }
          if (value < _tempMin & !_isSleep) {
            if (LowTemp != null) {
              LowTemp();
              _isSleep = true;
            }
          }
        }
      }

    }

    public static void Demo() {
      var sensor = new Sensor();
      sensor.HighTemp += () => { Console.WriteLine("Медвед проснулся! Превед, Медвед! "); };
      sensor.LowTemp += () => { Console.WriteLine("Медвед заснул . . ."); };

      Random rnd = new Random();
      for (int i = 0; i < 50; i++) {
        double temp = rnd.Next(-40, 40);
        Console.WriteLine($"\n{temp}");
        sensor.Temperature = temp;
        Thread.Sleep(100);
      }
      Console.WriteLine("\nНажмите Enter для продолжения . . .");
      Console.ReadLine();
    }
  }
}
