using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    internal class Problem_01
    {
        /*
        Problem 01
        Ведите с клавиатуры номер трамвайного билета (6-значное число) и проверьте является ли данный билет 
        счастливым (если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних 
        трёх, то этот билет считается счастливым).
        */
        public static void CheckTicket()
        {
            Console.Write("Введите с клавиатуры номер трамвайного билета (6-значное число): ");
            string? str = Console.ReadLine(); //получаем введенную пользователем строку
            char[] ch = new char[str.Length]; //создаем массив символов введенной строки
            ch = str.ToCharArray(); //копируем посимвольно строку в элементы массива
            int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray(); //создаем массив чисел и для каждого элемента массива символов производим операцию парсинга в целое число 
            if (ch.Length == 6) // проверяем что число равно 6
            {
                int leftNumber = 0; //начальная сумма левой половины билета
                int rightNumber = 0; //начальная сумма правой половины билета

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i]; //суммируем первую часть билета
                    }

                    else rightNumber += ticketNumber[i];//суммируем вторую часть билета
                }

                if (leftNumber == rightNumber)//проверяем равны ли суммы обеих частией билета
                {
                    Console.WriteLine($"Билет считается счастливым: {leftNumber} = {rightNumber}");
                }

                else Console.WriteLine($"билет считается не счастливым: {leftNumber} != {rightNumber}");
            }

            else Console.WriteLine("Число введено не верно!");
        }
    }
}
