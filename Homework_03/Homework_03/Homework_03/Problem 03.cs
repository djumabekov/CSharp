using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    /*
    Problem 03
    Напишите функцию умножения матриц
    static double[,] MatrixMult(double [,] a, double [,] b)
    Сделайте необходимые проверки.
     */
    internal class Problem_03
    {
        public static double[,] MatrixMult(double[,] a, double[,] b) {
            if (a.GetLength(0) != b.GetLength(0) && a.GetLength(1) != b.GetLength(01))
            {
                throw new Exception("К-во строк и столбцов двух матриц должны быть равны!");
            }
            double[,] arr = new double[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    arr[i, j] = a[i, j] * b[i, j];
                }
                Write("\n");
            }
            return arr;
        }
    }
}
