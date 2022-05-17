using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Exam {
  internal class Problem_01 {
    /*
     Problem 01
    Найдите строки матрицы размером 10_000 * 10_000, содержащие наибольшее количество отрицательных чисел. 
     */
    public static void PrintMatrix(double[,] mat) {
      for (int i = 0; i < mat.GetLength(0); i++) {
        for (int j = 0; j < mat.GetLength(1); j++) {
          Write($"{mat[i, j],2:N0}, ");
        }
        WriteLine($"\n");
      }
    }

    static double[,] CreateRandomMatrix(int nRows, int nCols, double min = 0, double max = double.MaxValue) {
      double[,] arr = new double[nRows, nCols];
      var rnd = new Random();
      for (int i = 0; i < nRows; i++) {
        for (int j = 0; j < nCols; j++) {
          arr[i, j] = rnd.NextDouble() * (max - min) + min;
        }
      }
      return arr;
    }
    //  - по убыванию количества отрицательных чисел в строке
    static int[] MatrixGetRowMaxNegativeNum(double[,] mat) {
      int[] res = new int[mat.GetLength(0)];
      for (int i = 0; i < mat.GetLength(0); i++) {
        int countNegativeNum = 0;
        for (int j = 0; j < mat.GetLength(1); j++) {
          if (mat[i, j] < 0) {
            countNegativeNum++;
          }
          res[i] = countNegativeNum;
        }
      }
      return res;
    }


    // не оптимальный поиск

    //static int[] MatrixGetRowMaxNegativeNum2(double[,] mat) {
    //  int[] res = new int[mat.GetLength(0)];

    //  for (int i = 0; i < mat.GetLength(0); i++) {
    //    List<double> temp = new List<double>();
    //    for (int j = 0; j < mat.GetLength(1); j++) {
    //      temp.Add(mat[i, j]);
    //    }

    //    temp.Sort();
    //    int countNegativeNum = 0;
    //    foreach (var item in temp) {
    //      if (item >= 0) {
    //        break;
    //      } else
    //        countNegativeNum++;
    //    }
    //    res[i] = countNegativeNum;
    //  }
    //  return res;
    //}

    public static void Demo() {
      int rows = 10_000, cols = 10_000;

      double[,] arr = CreateRandomMatrix(rows, cols, -10, 10);

      //PrintMatrix(arr);

      var sw = new Stopwatch();
      sw.Restart();
      int[] result = MatrixGetRowMaxNegativeNum(arr);
      WriteLine($"Matrix Get Row Max Negative Num by time: {sw.Elapsed}\n");


      int max = -1;
      int index = -1;

      for (int i = 0; i < result.Length; i++)
        if (max <= result[i]) {
          max = result[i];
          index = i;
        } 
      WriteLine($"Индекс строки, содержащая наибольшее количество отрицательных чисел: {index}, количество: {result.Max()}");


    }
  }
}
