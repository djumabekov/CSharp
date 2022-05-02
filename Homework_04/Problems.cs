using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork4
{
    internal class Problems
    {
        /*
        Problems
        Для получения высокой оценки дополнительно предоставьте самостоятельно решенные задачи 
        повышенной сложности, в том числе, и с предыдущего занятия.

        Problem - createRandUniqueArray
        Напишите функцию 
        int *createRandUniqueArray(int size, bool randomSeed = false)
        возвращающую динамический массив заданного размера size, содержащий УНИКАЛЬНЫЕ случайные числа.
        При randomSeed == false функция должна возвращать каждый раз один и тот же массив, при randomSeed == true - разные.
        Напишите тестовую функцию
        bool isUnique(const int *arr, int size) 
        для проверки уникальности массива.
        Напишите функцию 
        int *createRandUniqueArray(int size, int int, int max, bool randomSeed = false)
        возвращающую динамический массив, содержащий УНИКАЛЬНЫЕ случайные числа в интервале [min, max) (min включается, max - нет).
         */
        public static Random rnd = new Random(); //создаем статический экземпляр класс Random
        public static int[] CreateRandUniqueArray(int size, bool randomSeed = false) {
            rnd = randomSeed ? rnd : new Random(0); //если randomSeed=false, т.е. требуется получать одинаковый результат
                                                    //работы метода, создаем локальный экземпляр класса Random с Seed=0, иначе используем вышесозданный статически c Seed по умолчанию
            int[] arr = new int[size]; // создаем массив на size элементов
            for (int i = 0; i < arr.Length; i++) { // цикл наполнения массива
                arr[i] = rnd.Next(); // заполняем массив случайными числами
            }
            return arr; // возвращаем массив чисел
        }
        public static int[] CreateRandUniqueArray(int size, int min, int max, bool randomSeed = false) // перегруженный метод CreateRandUniqueArray
                                                                                                       //формирующий случайные числа в интервале (min, max)
        {
            rnd = randomSeed ? rnd : new Random(0); // метод возвращающий динамический массив заданного размера size, содержащий УНИКАЛЬНЫЕ случайные числа.
            int[] arr = new int[size]; // создаем массив на size элементов
            for (int i = 0; i < arr.Length; i++)// цикл наполнения массива случайными числами
            {
                arr[i] = rnd.Next() % ((max) - (min) + 1) + (min); // заполняем массив случайными числами
            }
            return arr;// возвращаем массив чисел
        }
        public static bool IsUnique(int[] arr) { // метод проверки уникальности массива
            bool isUnique = true; // булевая переменная сигнализирующий уникальность элементов массива
            for (int i = 0; i < arr.Length; i++)
            {
                do
                {
                    isUnique = true;
                    for (int j = 0; j < i; ++j)
                        if (arr[i] == arr[j])
                        {
                            isUnique = false;
                            break;
                        }
                } while (!isUnique);
            }      
            return isUnique;
        }
        public static void Print(int [] arr) // метод печати массива.
        {
            foreach (int item in arr) {
                Write($"{item}, ");
            }
        }

        public static void Demo() {

            WriteLine("\nrandomSeed = false:");
            int[] arr1 = CreateRandUniqueArray(10, false);
            bool isUnique1 = IsUnique(arr1);
            WriteLine("\narr1:");
            Print(arr1);
            WriteLine($"\nЭлементы в arr1 уникальны? = {isUnique1}");

            int[] arr2 = CreateRandUniqueArray(10, false);
            bool isUnique2 = IsUnique(arr2);
            WriteLine("\narr2:");
            Print(arr2);
            WriteLine($"\nЭлементы в arr2 уникальны? = {isUnique2}");

            WriteLine("\nrandomSeed = true:");
            int[] arr3 = CreateRandUniqueArray(10, true);
            bool isUnique3 = IsUnique(arr3);
            WriteLine("\narr3:");
            Print(arr3);
            WriteLine($"\nЭлементы в arr3 уникальны? = {isUnique3}");

            int[] arr4 = CreateRandUniqueArray(10, true);
            bool isUnique4 = IsUnique(arr4);
            WriteLine("\narr4:");
            Print(arr4);
            WriteLine($"\nЭлементы в arr4 уникальны? = {isUnique4}");

            WriteLine("\nРандом в диапазоне 100 и 1000, randomSeed = false:");

            int[] arr5 = CreateRandUniqueArray(10, 100, 1000, false);
            bool isUnique5 = IsUnique(arr5);
            WriteLine("\narr5:");
            Print(arr5);
            WriteLine($"\nЭлементы arr5 уникальны? = {isUnique5}");

            int[] arr6 = CreateRandUniqueArray(10, 100, 1000, false);
            bool isUnique6 = IsUnique(arr6);
            WriteLine("\narr6:");
            Print(arr6);
            WriteLine($"\nЭлементы arr6 уникальны? = {isUnique6}");

            WriteLine("\n\nРандом в диапазоне 100 и 1000, randomSeed = true:");
            int[] arr7 = CreateRandUniqueArray(10, 100, 1000, true);
            bool isUnique7 = IsUnique(arr7);
            WriteLine("\narr7:");
            Print(arr7);
            WriteLine($"\nЭлементы arr7 уникальны? = {isUnique7}");

            int[] arr8 = CreateRandUniqueArray(10, 100, 1000, true);
            bool isUnique8 = IsUnique(arr8);
            WriteLine("\narr8:");
            Print(arr8);
            WriteLine($"\nЭлементы arr8 уникальны? = {isUnique8}");
        }

    }
}
