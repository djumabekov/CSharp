using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_10 {
  internal class RunnaleClasses {
    public class Car : IRunnable {
      public double MaxSpeed { get; set; }
      public double Speed { get; set; }
      public Car(double maxSpeed) {
        MaxSpeed = maxSpeed;
      }
      public void Run(double speed) {
        if (speed < MaxSpeed) Speed = speed;
        WriteLine($"Car движется со скоростью {Speed}");
      }
    }

    public class Track : IRunnable {
      public double MaxSpeed { get; set; }
      public double Speed { get; set; }
      public Track(double maxSpeed) {
        MaxSpeed = maxSpeed;
      }
      public void Run(double speed) {
        if (speed < MaxSpeed) Speed = speed;
        WriteLine($"Track движется со скоростью {Speed}");
      }
    }
    public class Man : IRunnable {
      public double MaxSpeed { get; set; }
      public double Speed { get; set; }
      public Man(double maxSpeed) {
        MaxSpeed = maxSpeed;
      }
      public void Run(double speed) {
        if (speed < MaxSpeed) Speed = speed;
        WriteLine($"Man движется со скоростью {Speed}");
      }
    }
    public class Bear : IRunnable {
      public double MaxSpeed { get; set; }
      public double Speed { get; set; }
      public Bear(double maxSpeed) {
        MaxSpeed = maxSpeed;
      }
      public void Run(double speed) {
        if (speed < MaxSpeed) Speed = speed;
        WriteLine($"Bear движется со скоростью {Speed}");
      }
    }
    
  }
}
