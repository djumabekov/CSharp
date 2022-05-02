using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Classwork_10.ValuableClasses;

namespace Classwork_10 {
  internal class Problem_01___IValuable {
		/*
    Problem 01 - IValuable
		Реализуйте интерфейс IValuable
		interface IValuable {
			double GetValue();
		}
		для классов Book, Picture, Statue, Rarity (разместите их в файле ValuableClasses.cs).
		Стоимость объектов данных классов задается в их конструкторах.
		Например:
		class Picture : IValuable {
			double _value;

			public Picture(double value) {
				_value = value;
			}

			public double GetValue() => _value * 1.1;
		}

		В классе static class ValuableDemo:

		Напишите метод
		static List<IValuable> GeRandomValuableList(int size),
		возвращающий List, заполненный случайным образом объектами, реализующими  интерфейс IValuable.

		Напишите метод
		static double GetWorth(IValuable v),
		возвращающий стоимость любого из переданного ей объекта.

		Напишите метод
		static double GetWorth(List<IValuable> list),
		возвращающий суммарную стоимость объектов в массиве.

		Напишите метод
		static void BubleSort(List<IValuable> list),
		сортирующий по возрастанию методом пузырька любой List, элементы которого реализуют интерфейс IValuable.

		Напишите метод
		static void SortByValue(List<IValuable> list) {
			list.Sort(CompareByValue);
		}
		сортирующий с помощью библиотечного метода Sort по УБЫВАНИЮ любой List, 
		элементы которого реализуют интерфейс IValuable с помощью вспомогательного метода
		static int CompareByValue(IValuable a, IValuable b)


		Продемонстрируйте работу, В ЧАСТНОСТИ ВЫПОЛНИВ:
		public static void Demo() {
			var list = new List<IValuable> { new Book(100), new Rarity(10), new Statue(80), new Picture(50) };
			BubleSort(list);
			foreach (var item in list) {
				WriteLine(item.GetValue());
			}
			WriteLine();

			SortByValue(list);
			foreach (var item in list) {
				WriteLine(item.GetValue());
			}
			WriteLine();
			WriteLine($"Общая стоимость: {GetWorth(arr)}");
			//. . . 
		}
    */
		public static class ValuableDemo {
			static List<IValuable> GeRandomValuableList(int size) {
				var rnd = new Random();

				List<IValuable> valuable = new List<IValuable>(size);
				for (int i=0; i<size; i++) {
					valuable.Add(new Book(rnd.Next(10, 100)));
					valuable.Add(new Rarity(rnd.Next(30, 90)));
					valuable.Add(new Statue(rnd.Next(60, 200)));
					valuable.Add(new Picture(rnd.Next(50, 220)));
				}
				return valuable;
			}

			public static double GetWorth(IValuable v) {
				return v.GetValue();
      }

			static double GetWorth(List<IValuable> list) {
				double sum = 0;
				foreach(var obj in list) {
					sum += obj.GetValue();
        }
				return sum;
      }

			public static void BubleSort(List<IValuable> list) {
				IValuable temp;
				for (int i=0; i<list.Count; i++) {
					for (int j = 0; j < list.Count; j++) {
						if (list[i].GetValue() > list[j].GetValue()) {
							temp = list[i];
							list[i] = list[j];
							list[j] = temp;
						}
					}
        }
      }
			static int CompareByValue(IValuable a, IValuable b) {
				return -a.GetValue().CompareTo(b.GetValue());
      }
			public static void SortByValue(List<IValuable> list) {
				list.Sort(CompareByValue);
			}

			public static void Demo() {
				int size = 10;
				var list = GeRandomValuableList(size);

				WriteLine($"\nПузырьковая сортировка:\n");
				BubleSort(list);

				foreach (var item in list) {
					Write($"{item.GetValue(), 6:N2}, ");
				}
				WriteLine();

				WriteLine($"\nCортировка с помощью библиотечного метода Sort:\n");
				SortByValue(list);
				foreach (var item in list) {
					Write($"{item.GetValue(),6:N2}, ");
				}
				WriteLine();

				WriteLine($"\nОбщая стоимость: {GetWorth(list),6:N2}");
				//. . . 
			}
		}

	}
}
