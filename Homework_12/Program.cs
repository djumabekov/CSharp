global using static System.Console;
namespace Classwork_12;
class Program {

  static void Main(string[] args) {
    try {
      /*
      Problem 02 (StringListDelegates)
      */
      WriteLine("\n====================Problem 02====================\n");

      Problem_02.Demo();

      /*
      Problem 03
      Измените код проекта Sensor так, чтобы клиенты получали информацию о событиях HighTemp, 
      LowTemp только при первом наступлении данных событий. Исключите дублирование вывода информации, 
      например в случае, если температура достигла tMax и пока не опускается ниже tMin.
      */

      WriteLine("\n====================Problem 03====================\n");

      Problem_03.Demo();

      /*
		  Problem 00 (Devices) - Devices.txt 
		  Реализуйте универсальную программу для сбора информации с измерительных приборов произвольных секретных объектов, 
		  например - пусковых ракетных шахт, медовых ульев на пасеках, датчиков элементарных частиц в ЦЕРНЕ, метереостанций и т.п. 
		  */

      WriteLine("\n====================Problem 04====================\n");

      Problem_04.Demo();

      /*
       Problem 05 - DeviceEvents.txt
      */

      WriteLine("\n====================Problem 05 - DeviceEvents.txt====================\n");

      Problem_DeviceEvents.DeviceDemo.Demo();

    } catch (Exception ex) {
      WriteLine(ex.Message);
    }
    ReadLine();
  }
}