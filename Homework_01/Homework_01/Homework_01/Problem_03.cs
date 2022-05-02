using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    internal class Problem_03
    {
    /*
    Problem 03
    Напишите программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
    Программа должна сосчитать количество введенных пользователем пробелов. 
     */
    public static void ReadKeyFindSpaces()
    {
        Console.Write("Введите символы и пробелы, а затем точку: ");
        char ch;
        int spaceCount = 0; //количество пробелов

        //запускаем цикл до ввода пользователем символа "точки"
        do
        {
            ch = Console.ReadKey().KeyChar; //получаем значение каждой нажатой клавиши
            if (ch == ' ') spaceCount++; //если "пробел", то увеличиваем счетчик
        }
        while (ch != '.');

        Console.Write($"\nКоличество пробелов до точки: { spaceCount}");
        }
    }
}
