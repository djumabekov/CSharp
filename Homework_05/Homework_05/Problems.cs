using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    internal class Problems
    {
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

        public static int removeStep(int[] arr, int value) { //метод удаления из массива значения навного number и получаем оставшееся валидное количество значений
            int validCount = 0; // изначально задаем количество равное 0
            for (int i = 0; i < arr.Length; i++) {
                if (value == arr[i]) // если значение value найдено в массиве
                {
                    for (int j = i; j < arr.Length - 1; j++) // запускаем цикл с индекса найденного элемента
                    {
                        arr[j] = arr[j + 1];// и сдигаем элементы массива на один шаг назад замещая значение value
                    }
                }
                else
                {
                    validCount++; // увеличиваем счетчик на единицу
                }
            }
            return validCount; // валидное количество значений
        }

        public static int[] removeFromArray(int[] arr, int validCount) // метод возвращающий целевой массив с учетом размера validCount без значений number
        {
            int[] result = new int[validCount]; // формируем массив result размером validCount
            for (int i = 0; i < validCount; i++) { // запускаем цикл 
                result[i] = arr[i]; // копируем значения arr в result только до validCount (остальные значения нам не нужны)
            }
            return result; // возвращаем массив 
        }
        static int[] CreateArray(int size, int minValue, int maxValue) // метод создания рандомного массива заданного размера
        {
            var rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(minValue, maxValue);
            }
            return arr; // возвращаем массив 
        }

        public static void Demo() {
            const int minValue = 1;
            const int maxValue = 100;
            string str;
            while (true)
            {
                Write($"Введите с клавиатуры число от : {minValue} до {maxValue}: ");
                str = Console.ReadLine();
                if (str == null || str.Length < 1) continue;
                break;
            }
            int number = int.Parse(str);
            int size = 100; // размер исходного массива 
            int[] arr = CreateArray(size, minValue, maxValue);
            WriteLine($"\nИсходный массив размером: {size} ") ;
            foreach (var item in arr) Write($"{item}, ");

            WriteLine($"\nМассив с удаленными значениеми = {number}");
            int validCount = removeStep(arr, number); // вызываем метод удаления из массива значения number и получаем оставшееся валидное количество значений
            foreach (var item in arr) Write($"{item}, ");
            WriteLine($"\nОставшееся валидное количество значений = {validCount} ");

            WriteLine($"\nНовый массив result без {number}: ");
            int[] result = removeFromArray(arr, validCount); // вызываем метод возвращающий целевой массив с учетом размера validCount без значений number
            foreach (var item in result) Write($"{item}, ");
            WriteLine($"\nМассив result содержит {number}?  {(result.Contains(number)? " Да " : " Нет ")} "); // проверка присутствия в массиве result значения number

        }
    }
}
