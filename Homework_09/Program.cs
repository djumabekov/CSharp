global using static System.Console;

namespace Classwork_09;
  class Program {

    static void Main(string[] args) {
      try {
      /*   
      Problem 00
      Создайте абстрактный базовый класс Employee (работник) с абстрактным методом Work().
      Создайте три производных класса: Director, Manager, Worker.
      Переопределите метод Work() для выполнения работы, соответствующей каждому типу работника.
      Напишите методы
      static void DoWork(Employee empl)
      static void DoWork(Employee[] employees)
      static void DoWork(List<Employee> employees)
      Продемонcтрируйте правильную работу всех методов по подобию MainPolymorphismIdeaDemo из демонстрационного проекта).
       */

      WriteLine("\n====================Problem 00====================\n");

      Demo.MainPolymorphismIdeaDemo();

      /*
      Problem 01 - Vehicles
		  Создайте абстрастный класс Vehicle (транспортное средство) с наследниками Car, Track, Bus, Motorcycle.
       */

      WriteLine("\n====================Problem 01====================\n");

      Problem_01.VehicleDemo.Demo();

      /*
      Problem 03 - Figures
      Создайте абстрактный базовый класс Figure с абстрактными методами вычисления площади и периметра. 
      Создайте производные классы: Rectangle (прямоугольник), Circle (круг), Trapezium (трапеция) со своими функциями площади и периметра. 
      В конструкторе трапеции задавайте длины 4-н сторон, для определения площади найдите в справочниках довольно длинную формулу!  

      В static class FigureDemo напишите методы:
      public static double GetArea(List<Figure> figures) - общая площадь
      public static double GetPerimeter(List<Figure> figures) - общий периметр
      public static (double min, double max, double avr) GetAreaStats(List<Figure> figures) - макcимальное, минимальное и среднее значения площади
      public static (double min, double max, double avr) GetPerimeterStats(List<Figure> figures) - то же с периметром
      public static Figure FindFigureWithMaxArea(List<Figure> figures) - фигура с наибольшей площадью 
      public static Figure FindFigureWithMaxPerimeter(List<Figure> figures) - фигура с наибольшим периметром 

      public static SortByArea (List<Figure> figures)
      public static SortByPerimeter (List<Figure> figures)

      Создайте List<Figure> figures, содержащий фигуры разных типов.
      Продемонстрируйте работу всех методов.
      */

      WriteLine("\n====================Problem 03====================\n");

      Problem_03.FigureDemo.Demo();


    } catch (Exception ex) {
        WriteLine(ex.Message);
      }
      WriteLine("\nEnd . . .");
      ReadLine();
    }
  }
