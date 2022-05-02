global using static System.Console;

namespace Homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Problem 01
                Напишите функцию создания  матрицы (двумерного массива), заполненной случайными вещественными числами от min до max :
                static double[,] CreateRandomMatrix(int nRow, int nCol, double min = 0, double max = 1)
                 */
                WriteLine("\n====================Problem 01====================\n");
                double[,] arr = Homework_03.Problem_01.CreateRandomMatrix(2, 10, 10, 100); //сформируем файл с вещественными числам
                Homework_03.Problem_01.PrintMatrix(arr);
                
                /*
                 Problem 02
                Напишите функцию сложения матриц
                static double[,] MatrixSum(double [,] a, double [,] b)
                Сделайте необходимые проверки.
                 */
                WriteLine("\n====================Problem 02====================\n");
                
                double[,] a = Homework_03.Problem_01.CreateRandomMatrix(2, 10, 10, 100); //сформируем файл с вещественными числам
                WriteLine("A:");
                Homework_03.Problem_01.PrintMatrix(a);
                
                double[,] b = Homework_03.Problem_01.CreateRandomMatrix(2, 10, 10, 100); //сформируем файл с вещественными числам
                WriteLine("B:");
                Homework_03.Problem_01.PrintMatrix(b);

                double[,] c = Homework_03.Problem_02.MatrixSum(a, b);
                WriteLine("A + B:");
                Homework_03.Problem_01.PrintMatrix(c);

                /*
                Problem 03
                Напишите функцию умножения матриц
                static double[,] MatrixMult(double [,] a, double [,] b)
                Сделайте необходимые проверки.
                 */
                WriteLine("\n====================Problem 03====================\n");

                c = Homework_03.Problem_03.MatrixMult(a, b);
                WriteLine("A * B:");
                Homework_03.Problem_01.PrintMatrix(c);

                /*
                Problems
                Для получения высокой оценки дополнительно предоставьте самостоятельно решенные задачи повышенной сложности.
                //to do
                Даны два массива: А[M] и B[N] (M и N вводятся с клавиатуры). Необходимо создать третий массив
                минимально возможного размера, в котором нужно
                собрать общие элементы двух массивов без повторений.
                */
                WriteLine("\n====================Problems====================\n");

                Homework_03.Problems.Demo();

            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            WriteLine("\nEnd . . .");
            ReadLine();
        }
    }
}