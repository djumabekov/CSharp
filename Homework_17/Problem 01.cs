using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_17 {
  internal class Problem_01 {
    /*
    Problem 01
    Напишите метод транспонирующий матрицу (зеркально отображающий относительно главной диагонали) n*m -> m*n.
    */

    static int[,] CreateRandomMatrix(int nRows, int nCols, int min = 0, int max = int.MaxValue) {
      int[,] arr = new int[nRows, nCols];
      var rnd = new Random(0);
      for (int i = 0; i < nRows; i++) {
        for (int j = 0; j < nCols; j++) {
          arr[i, j] = rnd.Next(min, max);
        }
      }
      return arr;
    }

    static void TransporationMatrix(int[,] mat) {

      for (int i = 0; i < mat.GetLength(0); i++) {
        for (int j = i + 1; j < mat.GetLength(1); j++) {
          var tmp = mat[i, j];
          mat[i, j] = mat[j, i];
          mat[j, i] = tmp;
        }
      }
    }

    public static void PrintMatrix(int[,] mat) {
      for (int i = 0; i < mat.GetLength(0); i++) {
        for (int j = 0; j < mat.GetLength(1); j++) {
          Write($"{mat[i, j]}, ");
        }
        WriteLine($"\n");
      }
    }

    public static void Demo() {

      int[,] arr = CreateRandomMatrix(3, 3, 1, 4);

      WriteLine("before transporation:");
      PrintMatrix(arr);

      WriteLine("after transporation:");
      TransporationMatrix(arr);
      PrintMatrix(arr);

    }

  }
}
