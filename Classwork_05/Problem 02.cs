using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork05
{
    /*
     Problem 02
    Напишите следующие методы.
     */
    internal class Problem_02
    {
        /*
        Создание случайной матрицы со значениями элементов от min до max 
        static int[,] CreateRandomMatrix(int nRows, int nCols, int min = 0, int max = int.MaxValue)
        */

        static int[,] CreateRandomMatrix(int nRows, int nCols, int min = 0, int max = int.MaxValue) {
            int[,] arr = new int[nRows, nCols];
            var rnd = new Random(0);
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCols; j++)
                {
                    arr[i, j] = rnd.Next();
                }
            }
            return arr;
        }


        /*
         * Сортировка по строке row
         */
        static void SortRow(int[,] mat, int row) {
            int[] temp = new int[mat.GetLength(1)];

            for (int i = 0; i < mat.GetLength(1); i++)
            {
                temp[i] = mat[row, i];
            }
            Array.Sort(temp);
            for (int i = 0; i < temp.Length; i++)
            {
                mat[row, i] = temp[i];
            }
        }


        /*
         Сортировка по столбцу col
        static void SortCol(int[,] mat, int col)
         */
        static void SortCol(int[,] mat, int col) {
            int[] temp = new int[mat.GetLength(0)];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                temp[i] = mat[i, col];
            }
            Array.Sort(temp);
            for (int i = 0; i < temp.Length; i++)
            {
                mat[i, col] = temp[i];
            }
        }

        /*
        Сортировка по строкам (сортировка всех строк по отдельности)
        static void SortRows(int[,] mat)
        */
        static void SortRows(int[,] mat) {
            int[] temp = new int[mat.GetLength(1)];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    temp[j] = mat[i, j];
                }
                Array.Sort(temp);
                for (int j = 0; j < temp.Length; j++)
                {
                    mat[i, j] = temp[j];
                }
            }
            
        }

        /*
        Сортировка по столбцам (сортировка всех столбцов по отдельности)
        static void SortCols(int[,] mat) {
        */
        static void SortCols(int[,] mat)
        {
            int[] temp = new int[mat.GetLength(0)];

            for (int i = 0; i < mat.GetLength(1); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    temp[j] = mat[j, i];
                }
                Array.Sort(temp);
                for (int j = 0; j < temp.Length; j++)
                {
                    mat[j, i] = temp[j];
                }
            }

        }

        public static void Demo()
        {

            int[,] arr = CreateRandomMatrix(5, 5);

            WriteLine("before sort:");
            PrintMatrix(arr);

            WriteLine("after sort by ROW #2:");
            SortRow(arr, 2);
            PrintMatrix(arr);

            WriteLine("after sort by COL #2:");
            SortCol(arr, 2);
            PrintMatrix(arr);

            WriteLine("after sort by ALL ROWS:");
            SortRows(arr);
            PrintMatrix(arr);

            WriteLine("after sort by ALL COLS:");
            SortCols(arr);
            PrintMatrix(arr);
        }

        public static void PrintMatrix(int[,] mat) {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Write($"{mat[i, j]}, ");
                }
                WriteLine($"\n");
            }
        }


    }
}
