using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_17 {
  internal class Problem_02 {
    /*
     Problem 02
    Написать методы, переставляющие элементы в матрице double [,]:
     - по возрастанию по строкам:
      1  2  3  3
      3  6  7  8
     10 11 12 13

     - по убыванию по столбцам:
      13 10  6  3 
      12  8  3  2
      11  7  3  1
     */




    public static void PrintMatrix(double[,] mat) {
      for (int i = 0; i < mat.GetLength(0); i++) {
        for (int j = 0; j < mat.GetLength(1); j++) {
          Write($"{mat[i, j], 2:N0}, ");
        }
        WriteLine($"\n");
      }
    }

    // Сортировка по строке row
    static void SortRow(double[,] mat) {
      for (int i = 0; i < mat.GetLength(0); i++) 
        for (int j = 0; j < mat.GetLength(1) - 1; j++) 
          for (int k = 0; k < mat.GetLength(1) - j - 1; k++) 
            if (mat[i,k] > mat[i,k + 1]) {
              double tmp = mat[i,k];
              mat[i,k] = mat[i,k + 1];
              mat[i,k + 1] = tmp;
            }
    }
      //Сортировка по столбцу col

      static void SortCol(double[,] mat) {
      for (int i = 0; i < mat.GetLength(1); i++)
        for (int j = 0; j < mat.GetLength(0); j++)
          for (int k = j + 1; k < mat.GetLength(0); k++)
            if (mat[k,i] > mat[j,i]) {
              double temp = mat[k,i];
              mat[k,i] = mat[j,i];
              mat[j,i] = temp;
            }
      }

      static double[,] CreateRandomMatrix(int nRows, int nCols, double min = 0, double max = double.MaxValue) {
        double[,] arr = new double[nRows, nCols];
        var rnd = new Random(0);
        for (int i = 0; i < nRows; i++) {
          for (int j = 0; j < nCols; j++) {
            arr[i, j] = rnd.NextDouble() * (max - min) + min;
          }
        }
        return arr;
      }

      public static void Demo() {

        double[,] arr = CreateRandomMatrix(5, 3, 1, 15);

        WriteLine("before sort:");
        PrintMatrix(arr);

      WriteLine("after sort by ROW:");
      SortRow(arr);
      PrintMatrix(arr);

      WriteLine("after sort by COL:");
      SortCol(arr);
      PrintMatrix(arr);
    } 
    }
  }
