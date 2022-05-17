using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_17 {
  internal class Problem_03 {
    /*
    Problem 03 (MatrixTransform)
    Переставьте строки в матрице double [,]
      - по возрастанию суммы чисел в строке
      - по убыванию количества отрицательных чисел в строке
      - по возрастанию наименьшего элемента в строке
      - по убыванию наибольшего элемента в строке
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

    //  - по возрастанию суммы чисел в строке
    static void MatrixTransformBySum(double[,] mat) {
      double sum1, sum2, temp;
      int flag;
      do {
        flag = 0;
        for (int i = 0; i < mat.GetLength(0) - 1; i++) {
          sum1 = sum2 = 0;

          for (int j = 0; j < mat.GetLength(1); j++) {
            sum1 += mat[i,j];
            sum2 += mat[i + 1,j];
          }

          if (sum1 > sum2) {          
            //WriteLine($"sum1 = {sum1:N0}, sum2 = {sum2:N0} ");
            flag++;
            for (int j = 0; j < mat.GetLength(1); j++) {
              temp = mat[i,j];
              mat[i,j] = mat[i + 1,j];
              mat[i + 1,j] = temp;
            }
          }
        }

      } while (flag != 0);
    }

    //  - по убыванию количества отрицательных чисел в строке
    static void MatrixTransformByNegativeNum(double[,] mat) {
      double sum1, sum2, temp;
      int flag;
      do {
        flag = 0;
        for (int i = 0; i < mat.GetLength(0) - 1; i++) {
          sum1 = sum2 = 0;

          for (int j = 0; j < mat.GetLength(1); j++) {
            sum1 += mat[i, j] < 0? 1: 0;
            sum2 += mat[i + 1, j] < 0? 1: 0;
          }

          if (sum1 < sum2) {
            //WriteLine($"sum1 = {sum1:N0}, sum2 = {sum2:N0} ");
            flag++;
            for (int j = 0; j < mat.GetLength(1); j++) {
              temp = mat[i, j];
              mat[i, j] = mat[i + 1, j];
              mat[i + 1, j] = temp;
            }
          }
        }

      } while (flag != 0);
    }

    //    - по возрастанию наименьшего элемента в строке
    static void MatrixTransformByMinNum(double[,] mat) {
      double sum1, sum2, temp;
      int flag;
      do {
        flag = 0;
        for (int i = 0; i < mat.GetLength(0) - 1; i++) {
          sum1 = mat[i, 0];
          sum2 = mat[i + 1, 0];

          for (int j = 0; j < mat.GetLength(1)-1; j++) {
            sum1 = sum1 > mat[i, j+1] ? mat[i, j+1] : sum1;
            sum2 = sum2 > mat[i + 1, j + 1]? mat[i + 1, j + 1] : sum2;
          }
          //WriteLine($"sum1 = {sum1:N0}, sum2 = {sum2:N0} ");

          if (sum1 < sum2) {
            flag++;
            for (int j = 0; j < mat.GetLength(1); j++) {
              temp = mat[i, j];
              mat[i, j] = mat[i + 1, j];
              mat[i + 1, j] = temp;
            }
          }
        }

      } while (flag != 0);
    }


    //    - по убыванию наибольшего элемента в строке
    static void MatrixTransformByMaxNum(double[,] mat) {
      double sum1, sum2, temp;
      int flag;
      do {
        flag = 0;
        for (int i = 0; i < mat.GetLength(0) - 1; i++) {
          sum1 = mat[i, 0];
          sum2 = mat[i + 1, 0];

          for (int j = 0; j < mat.GetLength(1) - 1; j++) {
            sum1 = sum1 < mat[i, j + 1] ? mat[i, j + 1] : sum1;
            sum2 = sum2 < mat[i + 1, j + 1] ? mat[i + 1, j + 1] : sum2;
          }
          //WriteLine($"sum1 = {sum1:N0}, sum2 = {sum2:N0} ");

          if (sum1 < sum2) {
            flag++;
            for (int j = 0; j < mat.GetLength(1); j++) {
              temp = mat[i, j];
              mat[i, j] = mat[i + 1, j];
              mat[i + 1, j] = temp;
            }
          }
        }

      } while (flag != 0);
    }
    public static void Demo() {

      double[,] arr = CreateRandomMatrix(3, 5, -10, 10);

      WriteLine("before sort:");
      PrintMatrix(arr);

      WriteLine("по возрастанию суммы чисел в строке:");
      MatrixTransformBySum(arr);
      PrintMatrix(arr);

      WriteLine("по убыванию количества отрицательных чисел в строке:");
      MatrixTransformByNegativeNum(arr);
      PrintMatrix(arr);

      WriteLine("по возрастанию наименьшего элемента в строке:");
      MatrixTransformByMinNum(arr);
      PrintMatrix(arr);

      WriteLine("по убыванию наибольшего элемента в строке:");
      MatrixTransformByMaxNum(arr);
      PrintMatrix(arr);

    }
  }
}
