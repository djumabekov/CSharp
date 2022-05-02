﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03
{
    /*
    Problems
    Для получения высокой оценки дополнительно предоставьте самостоятельно решенные задачи повышенной сложности.

    //to do
    Даны два массива: А[M] и B[N] (M и N вводятся с клавиатуры). Необходимо создать третий массив
    минимально возможного размера, в котором нужно
    собрать общие элементы двух массивов без повторений.

    */
    internal class Problems
    {
        public static int[] CreatArrayValues()                                                                  // метод создания массива чисел
        {
            string str;
            while (true)
            {
                WriteLine("Введите несколько целых числа массива и нажмите Enter:");
                str = Console.ReadLine();                                                                       // читаем введенную пользователем строку
                if (str == null || str.Length < 2)                                                              // если строка null и ее длина меньше 2 символов
                {
                    continue;                                                                                   //то, просим пользователя ввести строку снова
                }
                break;                                                                                          // если все ок, идем дальше
            }
            int[] arr = str.Split(new char[] { ' ', '\t', ';', ',' }, StringSplitOptions.RemoveEmptyEntries). // разбиваем строку на массив символов 
            Where(x => !string.IsNullOrWhiteSpace(x)).
            Select(x => int.Parse(x)).ToArray();                                                               //и парсим их в целые числа
            return arr;                                                                                        // возвращаем массив целых чисел
        }

        //public static List<int> MergeUniqueArrayValues(int[] a, int[] b)                                           // метод поиска общих элементов двух массивов
        //                                                                                                           // без повторений и добавление их в третий массив
        //{
        //    List<int> arr = new List<int>();
        //    int size = 0;
        //    if (a == null || b == null || a.Length == 0 || b.Length == 0)                                       // если пришедшие массива пусты или их длина равна 0,
        //                                                                                                        // то выбрасываем исключение
        //    {
        //        throw new Exception("Массив пустой!");
        //    }

        //    // приступаем к вычислению количества совпадающих элементов
        //    for (int i = 0; i < a.Length; i++)                                                                  // цикл поиска количества совпадений для вычисления размера целевого (третьего) массива,
        //                                                                                                        // куда будем складывать совпадающие числа
        //    {
        //        bool flag = false;                                                                              // чтобы исключить дублирование, устанаваливаем флажок,
        //                                                                                                        // который будет сигнализировать, что такое число уже было использовано ранее в поиске
        //        for (int k = 0; k < i; k++)                                                                     // цикл поиска уже использованных чисел
        //        {
        //            if (a[i] == a[k])
        //            {
        //                flag = true;                                                                            // если нашли, что число ранее уже было в поиске, переключаем флажок,
        //                break;                                                                                  // и прерываем цикл
        //            }
        //        }
        //        if (flag == true) { continue; }                                                                 // если флажек true, то возвращаемся к началу цикла
        //                                                                                                        // потому что далее искать ранее использованное число смысла нет
        //        for (int j = 0; j < b.Length; j++)                                                              // цикл поиска совпадений чисел первого и второго массивов
        //        {
        //            if (a[i] == b[j])                                                                           // если совпадение найдено,
        //            {
        //                size++;                                                                                 // увеличиваем счетчик 
        //                //WriteLine($"size1 = {size }");
        //                arr.Add(a[i]);
        //                break;                                                                                  // и прерываем цикл
        //            }
        //        }
        //    }
        //    WriteLine($"Найдено совпадений: {size}");
        //    return arr;
        //}


        public static int[] MergeUniqueArrayValues(int[] a, int[] b)                                           // метод поиска общих элементов двух массивов
                                                                                                                   // без повторений и добавление их в третий массив
        {
            int[] arr = Array.Empty<int>();
            int size = 0;
            int m = 1;
            if (a == null || b == null || a.Length == 0 || b.Length == 0)                                       // если пришедшие массива пусты или их длина равна 0,
                                                                                                                // то выбрасываем исключение
            {
                throw new Exception("Массив пустой!");
            }

            // приступаем к вычислению количества совпадающих элементов
            for (int i = 0; i < a.Length; i++)                                                                  // цикл поиска количества совпадений для вычисления размера целевого (третьего) массива,
                                                                                                                // куда будем складывать совпадающие числа
            {
                bool flag = false;                                                                              // чтобы исключить дублирование, устанаваливаем флажок,
                                                                                                                // который будет сигнализировать, что такое число уже было использовано ранее в поиске
                for (int k = 0; k < i; k++)                                                                     // цикл поиска уже использованных чисел
                {
                    if (a[i] == a[k])
                    {
                        flag = true;                                                                            // если нашли, что число ранее уже было в поиске, переключаем флажок,
                        break;                                                                                  // и прерываем цикл
                    }
                }
                if (flag == true) { continue; }                                                                 // если флажек true, то возвращаемся к началу цикла
                                                                                                                // потому что далее искать ранее использованное число смысла нет
                for (int j = 0; j < b.Length; j++)                                                              // цикл поиска совпадений чисел первого и второго массивов
                {
                    if (a[i] == b[j])                                                                           // если совпадение найдено,
                    {
                        size++;                                                                                 // увеличиваем счетчик 
                        //WriteLine($"size1 = {size }");
                        Array.Resize(ref arr, m);
                        arr[m-1] = a[i];
                        m++;
                        break;                                                                                  // и прерываем цикл
                    }
                }
            }
            WriteLine($"Найдено совпадений: {size}");
            return arr;
        }

        public static void Demo() {
            WriteLine("Массив А: ");
            int[] arr1 = CreatArrayValues();
            WriteLine("Массив B: ");
            int[] arr2 = CreatArrayValues();

            WriteLine("Вариант 1. Поиск с использованием Intersect. Массив общих значений массивов А и В: ");
            int[] arr3 = arr1.Intersect(arr2).ToArray();
            foreach (int i in arr3) WriteLine($"{i} ");


            WriteLine("Вариант 2. Собственноручный поиск.Массив общих значений массивов А и В: ");
           int[] arr4 = MergeUniqueArrayValues(arr1, arr2);
            foreach (int i in arr4) WriteLine($"{i} ");
            }
    }
}