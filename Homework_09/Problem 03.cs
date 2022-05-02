using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_09 {
  internal class Problem_03 {
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

    public abstract class Figure {

      public double Area { get; set; }
      public double Perimeter { get; set; }
      public abstract void CalcArea();
      public abstract void CalcPerimeter();
    }

    public class Rectangle : Figure {
      public double Weidth { get; set; }
      public double Height { get; set; }
      public Rectangle(double weidth, double height) {
        Weidth = weidth;
        Height = height;
      }
      public override void CalcPerimeter() {
        Perimeter = 2 * (Weidth + Height);
      }

      public override void CalcArea() {
        Area = Weidth * Height;
      }
    }

    public class Circle : Figure {
      public double Radius { get; set; }

      public Circle(double radius) {
        Radius = radius;
      }
      public override void CalcPerimeter() {
        Perimeter = 2 * Radius * Math.PI;
      }

      public override void CalcArea() {
        Area = Math.PI * Radius * Radius;
      }
    }

    public class Trapezium : Figure {

      public double A { get; set; }
      public double B { get; set; }
      public double C { get; set; }
      public double D { get; set; }

      public Trapezium(double a, double b, double c, double d) {
        A = a;
        B = b;
        C = c;
        D = d;
      }
      public override void CalcPerimeter() {
        Perimeter = A + B + C + D;
      }

      public override void CalcArea() {
        double k1 = (A + B) / 2.0;
        double k2 = ((B - A) * (B - A) + C * C - D * D) / (2 * (B - A));
        Area = k1 * Math.Sqrt(C * C - k2 * k2);
      }
    }

    public static class FigureDemo {
      public static double GetArea(List<Figure> figures) {
        double AllArea = 0;
        foreach (var figure in figures) {
          figure.CalcArea();
          AllArea += figure.Area;
        }
        return AllArea;
      }

      public static double GetPerimeter(List<Figure> figures) {
        double AllPerimeter = 0;
        foreach (var figure in figures) {
          figure.CalcPerimeter();
          AllPerimeter += figure.Perimeter;
        }
        return AllPerimeter;
      }

      public static (double min, double max, double avr) GetAreaStats(List<Figure> figures) {
        double min = figures.Min(figure => figure.Area);
        double max = figures.Max(figure => figure.Area);
        double avr = figures.Average(figure => figure.Area);
        return (min, max, avr);
      }

      public static (double min, double max, double avr) GetPerimeterStats(List<Figure> figures) {
        double min = figures.Min(figure => figure.Perimeter);
        double max = figures.Max(figure => figure.Perimeter);
        double avr = figures.Average(figure => figure.Perimeter);
        return (min, max, avr);
      }
      public static Figure FindFigureWithMaxArea(List<Figure> figures) {
        SortByArea(figures);
        return figures.LastOrDefault();
      }

      public static Figure FindFigureWithMaxPerimeter(List<Figure> figures) {
        SortByPerimeter(figures);
        return figures.LastOrDefault();
      }

      public static void SortByArea(List<Figure> figures) {
        figures.Sort((f1, f2) => f1.Area.CompareTo(f2.Area));
      }

      public static void SortByPerimeter(List<Figure> figures) {
        figures.Sort((f1, f2) => f1.Perimeter.CompareTo(f2.Perimeter));
      }


    public static void Demo(){
      var rnd = new Random();
      int size = 100;
      List<Figure> figures = new List<Figure>(size);
      for (int i = 0; i < size; i++) {
        figures.Add(new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10)));
        figures.Add(new Circle(rnd.Next(1, 10)));
        figures.Add(new Trapezium(rnd.Next(1, 5), rnd.Next(5, 7), rnd.Next(9, 10), rnd.Next(9, 10)));

      }
      WriteLine($"создано фигур: {figures.Count}");

      WriteLine($"общая площадь: {GetArea(figures),6:N2}");
      WriteLine($"общий периметр: {GetPerimeter(figures),6:N2}");
      WriteLine($"макcимальное, минимальное и среднее значения площади: {GetAreaStats(figures).max,6:N2}, {GetAreaStats(figures).min,2:N2}, {GetAreaStats(figures).avr,2:N2}");
      WriteLine($"макcимальное, минимальное и среднее значения периметра: {GetPerimeterStats(figures).max,6:N2}, {GetPerimeterStats(figures).min,2:N2}, {GetPerimeterStats(figures).avr,2:N2}");
      WriteLine($"фигура с наибольшей площадью: {FindFigureWithMaxArea(figures).Area,6:N2}");
      WriteLine($"фигура с наибольшим периметром: {FindFigureWithMaxPerimeter(figures).Perimeter,6:N2}");

      }
    }
  }
}
