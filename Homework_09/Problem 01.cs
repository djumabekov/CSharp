using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_09 {
	/*
   ОСНОВНЫЕ ЗАДАЧИ

		Problem 01 - Vehicles
		Создайте абстрастный класс Vehicle (транспортное средство) с наследниками Car, Track, Bus, Motorcycle.

		public abstract class Vehicle {
			public double MaxSpeed { get; set; }
			public double Speed { get; set; }
			public abstract void Run(double speed);
		}

		В классах - наследниках реализуйте:
		Конструктор, в котором устанавливается разумная максимальная скорость MaxSpeed для данного типа.

		Виртуальный метод, приводящий в движение транспортное средство, в том числе, задающий скорость Speed:
		public override void Run(double speed) {
			//ограничьте скорость (не более MaxSpeed, учитывая тип автомобиля)
			//Speed = speed, если speed < MaxSpeed;   
			WriteLint($"( Car, Track, Bus, Motorcycle) движется со скоростью {Speed}");
		}  

		В static class VehicleDemo напишите методы:
		public static void Run(List<Vehicle> autos, double speed)
		public static double GetAverageSpeed(List<Vehicle> autos)

		Создайте List<Vehicle> autos, содержащий автомобили разных типов.

		Продемонстрируйте работу методов:
		public static void Demo() {
			var autos = new List<Vehicle>() { new Car(), new Car(), new Truck(), new Bus(), new Motorcycle(), };
	
			Run(autos, 2000);
			WriteLine($"\nСредняя скорость = {GetAverageSpeed(autos)}\n");
	
			Run(autos, 70);
			WriteLine($"\nСредняя скорость = {GetAverageSpeed(autos)}\n");
		}

   */
	internal class Problem_01 {

		public abstract class Vehicle {
			public double MaxSpeed { get; set; }
			public double Speed { get; set; }
			public abstract void Run(double speed);
		}

		public class Car : Vehicle {

			public Car(int MaxSpeed) {
				this.MaxSpeed = MaxSpeed;
			}
			public override void Run(double speed) {
				if (speed < MaxSpeed) Speed = speed;
				WriteLine($"Car едет со скоростью {Speed}");
			}
		}
		public class Track : Vehicle {
			public Track(int MaxSpeed) {
				this.MaxSpeed = MaxSpeed;
			}
			public override void Run(double speed) {
				if (speed < MaxSpeed) Speed = speed;
				WriteLine($"Track едет со скоростью {Speed}");
			}
		}

		public class Bus : Vehicle {
			public Bus(int MaxSpeed) {
				this.MaxSpeed = MaxSpeed;
			}
			public override void Run(double speed) {
				if (speed < MaxSpeed) Speed = speed;
				WriteLine($"Bus едет со скоростью {Speed}");
			}
		}

		public class Motorcycle : Vehicle {
			public Motorcycle(int MaxSpeed) {
				this.MaxSpeed = MaxSpeed;
			}
			public override void Run(double speed) {
				if (speed < MaxSpeed) Speed = speed;
				WriteLine($"Motorcycle едет со скоростью {Speed}");
			}
		}

		public static class VehicleDemo {
			public static void Run(List<Vehicle> autos, double speed) {
				foreach (var item in autos) {
					item.Run(speed);
				}
			}
			public static double GetAverageSpeed(List<Vehicle> autos) {
				double averageSpeed = 0;
				foreach (var item in autos) {
					averageSpeed += item.Speed;
				}
				return averageSpeed / autos.Count;
			}


		public static void Demo() {

			Vehicle car = new Car(100);
			Vehicle track = new Track(100);
			Vehicle bus = new Bus(100);
			Vehicle motocycle = new Motorcycle(100);

			var autos = new List<Vehicle> { car, track, bus, motocycle };

			Run(autos, 20);
			WriteLine($"\nСредняя скорость = {GetAverageSpeed(autos)}\n");

			Run(autos, 70);
			WriteLine($"\nСредняя скорость = {GetAverageSpeed(autos)}\n");
		}
		}
	}
}
