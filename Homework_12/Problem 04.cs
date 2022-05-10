using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_12 {

	internal class Problem_04 {
		/*
		Problem 00 (Devices) - Devices.txt 
		Реализуйте универсальную программу для сбора информации с измерительных приборов произвольных секретных объектов, 
		например - пусковых ракетных шахт, медовых ульев на пасеках, датчиков элементарных частиц в ЦЕРНЕ, метереостанций и т.п. 
		*/

		//Получение итогового результата для всего набора измерений прибора
		delegate double GetOutput(List<double> values);

		//Проверка статуса готовности устройства, подключенного к прибору
		delegate bool IsReady(List<double> values, double criticalPoint);

		public class Device {

			//все результаты измерений, хранящиеся в приборе
			public List<double> Values { get; set; } = new List<double>();
			//осуществление нового измерения 
			public void Add(double x) { 
				Values.Add(x);
			}
		}

		//минимальное значение(MinValue)
		static double GetMinValue(List<double> values) {
			return values.Min();
		}

		//максимальное значение (MaxValue)
		static double GetMaxValue(List<double> values) {
			return values.Max();
		}

		//сумма всех значений (SumValue)
		static double GetSumValue(List<double> values) {
			return values.Sum();
		}

		//количество всех значений (CountValue)
		static double GetCountValue(List<double> values) {
			return values.Count;
		}

		//среднее арифметическое(AverageValue)
		static double GetAverageValue(List<double> values) {
			return values.Average();
		}

		//среднее геометрическое (GeometricMeanValue)
		static double GetGeometricMeanValue(List<double> values) {
			double agr = 1;
			foreach (var value in values) {
				agr *= value;
			}
			return Math.Pow(agr, 1/values.Count);
		}

		//среднее квадратическое (квадратичное) - квадратный корень из среднего арифметического квадратов данных чисел (RootMeanSquareValue)
		static double GetRootMeanSquareValue(List<double> values) {
			double agr = 1;
			foreach (var value in values) {
				agr *= value*value;
			}
			return Math.Sqrt(agr / values.Count);
		}

		//среднее квадратическое отклонение - квадратный корень из среднего арифметического квадратов разностей чисел и их среднего (StandardDeviationValue)
		static double GetStandardDeviationValue(List<double> values) {
			double agr = 0;
			double avr = values.Average();
			foreach (var value in values) {
				agr += Math.Pow(value - avr, 2);
			}
			return Math.Sqrt(agr / values.Count);
		}

		//Получить массивы результатов измерений (GetResults) при использовании всех указанных методов сбора результатов.
		static List<double> GetResults(List<Device> deviceList, GetOutput resultMethod) {
				List<double> results = new List<double>();
				foreach (var device in deviceList)
					results.Add(resultMethod(device.Values));
				return results;
			}

		//хотя бы одно измерение превысило критическую точку (OneReady)
		static bool GetOneReady(List<double> values, double criticalPoint) {
			foreach(var value in values) {
				if (value > criticalPoint) return true;
      }
			return false;
		}

		//все измерения превысили критическую точку (AllReady)
		static bool GetAllReady(List<double> values, double criticalPoint) {
			foreach (var value in values) {
				if (value <= criticalPoint) return false;
			}
			return true;
		}

		//среднее значение всех измерений превысило критическую точку (AverageReady)
		static bool GetAverageReady(List<double> values, double criticalPoint) {
			return values.Average() > criticalPoint;
		}

		//Получить массивы статусов готовности приборов (GetReadyStatus) при использовании всех указанных методов проверки статуса готовности
		static List<bool> GetReadyStatus(List<List<double>> deviceList, IsReady readyMethod, double criticalPoint) {
			List<bool> readyStatus = new List<bool>();
			foreach (var device in deviceList)
				readyStatus.Add(readyMethod(device, criticalPoint));
			return readyStatus;
		}


		public static void Demo() {

			/*
			1. Сбор информации
			 */

			//Создать массив приборов, каждый из которых содержит различное (случайное) количество измерений (values) с разумным разбросом их значений.
			List<Device> devices = new List<Device>();
			Random rnd = new Random();
			for (int i = 0; i < 5; i++) {
				devices.Add(new Device());
				for (int j = 0; j < rnd.Next(5, 10); j++) {
					double value = rnd.Next(1, 40);
					devices[i].Add(value);
				}
			}

			List<List<double>> values = new List<List<double>>();


			List<double> minValues = GetResults(devices, GetMinValue);
			values.Add(minValues);
			for (int i = 0; i < minValues.Count; i++) WriteLine($"Измерение 1. Минимальное значение прибора {i + 1} = {minValues[i]}");
			WriteLine();

			List<double> maxValues = GetResults(devices, GetMaxValue);
			values.Add(maxValues);
			for (int i = 0; i < maxValues.Count; i++) WriteLine($"Измерение 2. Максимально значение прибора {i + 1} = {maxValues[i]}");
			WriteLine();

			List<double> sumValues = GetResults(devices, GetSumValue);
			values.Add(sumValues);
			for (int i = 0; i < sumValues.Count; i++) WriteLine($"Измерение 3. Сумма значений прибора {i + 1} = {sumValues[i]}");
			WriteLine();

			List<double> countValues = GetResults(devices, GetCountValue);
			values.Add(countValues);
			for (int i = 0; i < countValues.Count; i++) WriteLine($"Измерение 4. Количество значений прибора {i + 1} = {countValues[i]}");
			WriteLine();

			List<double> averageValues = GetResults(devices, GetAverageValue);
			values.Add(averageValues);
			for (int i = 0; i < averageValues.Count; i++) WriteLine($"Измерение 5. Среднее арифметическое значение прибора {i + 1} = {averageValues[i], 2:N3}");
			WriteLine();

			List<double> geometricMeanValues = GetResults(devices, GetGeometricMeanValue);
			values.Add(geometricMeanValues);
			for (int i = 0; i < geometricMeanValues.Count; i++) WriteLine($"Измерение 6. Среднее геометрическое значение прибора {i + 1} = {geometricMeanValues[i],2:N3}");
			WriteLine();

			List<double> rootMeanSquareValues = GetResults(devices, GetRootMeanSquareValue);
			values.Add(rootMeanSquareValues);
			for (int i = 0; i < rootMeanSquareValues.Count; i++) WriteLine($"Измерение 7. Среднее квадратичное значение прибора {i + 1} = {rootMeanSquareValues[i],2:N3}");
			WriteLine();

			List<double> standardDeviationValue = GetResults(devices, GetStandardDeviationValue);
			values.Add(standardDeviationValue);
			for (int i = 0; i < standardDeviationValue.Count; i++) WriteLine($"Измерение 8. Среднее квадратичное отклонение прибора {i + 1} = {standardDeviationValue[i],2:N3}");

			/*
			 2. Проверка статуса готовности устройства, подключенного к прибору
			 */

			//Получить массивы статусов готовности приборов (GetReadyStatus) при использовании всех указанных методов проверки статуса готовности.
				WriteLine();
				double criticalPoint = rnd.Next(1, 40);
				//хотя бы одно измерение превысило критическую точку (OneReady)
				List<bool> oneReady = GetReadyStatus(values, GetOneReady, criticalPoint);
				for (int i = 0; i < oneReady.Count; i++) WriteLine($"Измерение {i + 1}. Хотя бы одно измерение превысило критическую точку ({criticalPoint}) = {oneReady[i]}");
				WriteLine();
				//все измерения превысили критическую точку (AllReady)
				List<bool> allReady = GetReadyStatus(values, GetAllReady, criticalPoint);
				for (int i = 0; i < allReady.Count; i++) WriteLine($"Измерение {i + 1}. Все измерения превысили критическую точку ({criticalPoint}) = {allReady[i]}");
				WriteLine();
				//среднее значение всех измерений превысило критическую точку (AverageReady)
				List<bool> averageReady = GetReadyStatus(values, GetAverageReady, criticalPoint);
				for (int i = 0; i < averageReady.Count; i++) WriteLine($"Измерение {i + 1}. Cреднее значение всех измерений превысило критическую точку ({criticalPoint}) = {averageReady[i]}");
				WriteLine();
			}



	}
}
