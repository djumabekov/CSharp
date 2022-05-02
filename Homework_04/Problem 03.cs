using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork4
{
    /*   
    Problem 03
    Реализуйте два метода 
    void ArrInfo1(double[] arr, . . .)
    . .  ArrInfo2(double[] arr)
    позволяющие получить минимальное, максимальное и среднее значения массива с помощью:
    1) out - параметров
    2) tuple
    Продемонстрируйте работу на случайном массиве из 100_000_000 элементов.
     */
    public class Problem_03
    {
        const int size = 1000;
        static double[] arr = new double[size];
        public double min, max, avr;
        public static void CreateArray() {

            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++) { 
                arr[i] = rnd.NextDouble();
            }
        }
        
        public static void ArrInfo1(double[] arr, out double min, out double max, out double avr) {
            min = arr.Min();
            max = arr.Max();
            avr = arr.Average();

        }
         public static (double min, double max, double avr) ArrInfo2(double[] arr) {
           
            double min = arr.Min();
            double max = arr.Max();
            double avr = arr.Average();
            return (min, max, avr);
        }
        public static void PrintArrInfo()
        {
            ArrInfo1(arr, out double min, out double max, out double avr);
            WriteLine($"PrintArrInfo1: min = {min}; max = {max}; avr = {avr}\n");

            (double min2, double max2, double avr2) = ArrInfo2(arr);
            WriteLine($"PrintArrInfo2: min = {min2}; max = {max2}; avr = {avr2}\n");
        }

    }
}
