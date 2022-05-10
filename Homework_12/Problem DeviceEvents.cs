using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_12 {
  internal class Problem_DeviceEvents {
		/*
		 Problem 05 - DeviceEvents.txt
		*/
		public delegate void ValueAddedHandler(int deviceNumber, double newValue);
		public delegate void ValuesClearedHandler(int deviceNumber);


		public class Device {
			int _deviceNumber;
			public List<double> Values { get; set; } = new List<double>();

			public event ValueAddedHandler ValueAdded;
			public event ValuesClearedHandler ValuesCleared;

			public Device(int deviceNumber) { _deviceNumber = deviceNumber; }


			public void Add(double x) {
				Values.Add(x);
				ValueAdded(_deviceNumber, x);
				}


			public void Clear() {
				Values.Clear();
				ValuesCleared(_deviceNumber);
	}
		}


		public class DeviceDemo {
			static void AddValueInfo(int deviceNumber, double newValue) {
				WriteLine($"В приборе {deviceNumber} добавдено измерение со значением: {newValue}");
			} 

		static void ClearInfo(int deviceNumber) {
				WriteLine($"В приборе {deviceNumber} данные всех измерений удалены!");
			}

			public static void Demo() {
				var dev1 = new Device(1);
				dev1.ValueAdded += AddValueInfo;
				dev1.ValuesCleared += ClearInfo;

				var dev2 = new Device(2);
				dev2.ValueAdded += AddValueInfo;
				dev2.ValuesCleared += ClearInfo;

				dev1.Add(10); dev1.Add(20); dev1.Add(30);
				dev2.Add(100); dev2.Add(200); dev2.Add(300);
				dev1.Clear();
				dev2.Clear();
			}
		}
	}
}
