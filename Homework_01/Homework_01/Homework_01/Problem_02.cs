using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    internal class Problem_02
    {
        /*
        Problem 02
        Дано целое положительные N. Найдите число, полученное при прочтении числа N справа налево и его квадрат. 
        Например, если было введено число 345, то программа должна вывести числа 543 и 294849, а если 200, то 2 и 4.
         */
        public static void ReverseIntPow2()
        {
            Console.Write("Введите целое число: ");
            string? str = Console.ReadLine(); //получаем введенное пользователем число в виде строки
            char[] arr = str.ToCharArray();//создаем массив символов введенной строки
            Array.Reverse(arr);//переворачиваем массив символов
            string reverseStr = new string(arr);//превращаем массив обратно в строку и возвращаем
            int reverseNum = int.Parse(reverseStr);//парсим строку в число
            Console.WriteLine($"Число исходное: {str}. Число перевернутое {reverseNum}. Квадрат числа: {reverseNum*reverseNum}");
        }
    }
}
