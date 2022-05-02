using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoNS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Problem 01
                Изучите и продемонстрируйте работу методов класса string, перечисленных в
                public static void StringMethods()
                проекта Demo данного занятия.
                 */

                WriteLine("\n====================Problem 01====================\n");
                Homework_05.Problem_01.StringMethods();

                /*
                Problems
                Для получения высокой оценки дополнительно предоставьте самостоятельно решенные задачи повышенной сложности, в том числе, и с предыдущего занятия.

                Problem - removeStep

                Напишите функцию
                size_t removeStep(T *arr, size_t size, const T value)
                удаляющую из динамического массива arr все элементы равные value, посредством сдвига остальных к началу массива и возвращающую количество элементов, не равных value (назовем его validCount).
                Значения последних элементов после удаления (сдвига) в количестве size-validCount неопределены. Они нас не интересуют, но остаются в массиве, так как размер массива не меняется!
                Задача должна быть решенена предельно эффективным способом, без использования сортировки и с помощью единственного прохода по массиву!

                Использую функцию removeStep, реализуйте
                void removeFromArray(T *arr, size_t size, const T value, T *arrNew,  size_t *validCount)
                возвращающую новый динамический массив arrNew, содержащий оставшиеся после удаления элементы (в количестве validCount).
                 */

                WriteLine("\n====================Problems====================\n");
                Homework_05.Problems.Demo();

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
