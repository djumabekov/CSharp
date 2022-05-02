using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    /*
    Problem 01
    Напишите функцию создания  матрицы (двумерного массива), заполненной случайными вещественными числами от min до max :
    static double[,] CreateRandomMatrix(int nRow, int nCol, double min = 0, double max = 1)
     */
    internal class Problem_01
    {
        public static double[,] CreateRandomMatrix(int nRow, int nCol, double min = 0, double max = 1) {
            Random rnd = new Random();
            double[,] arr = new double[nRow, nCol];
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = rnd.NextDouble();
                }
            }
            return arr;
        }

        public static void PrintMatrix(double[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Write($"{arr[i, j], 5:N3}  ");
                }
                Write("\n");
            }
        }

        public static void PrintMatrix(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Write($"{arr[i]} ");
            }
            Write("\n");    
        }
    }
}
