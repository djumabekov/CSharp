﻿global using static System.Console;
class Program
{
    public static void Main(string[] args)
    {
    try
    {
    /*
    Problem 00 - NewtonsPi
    По формуле, приведенной на рисунке NewtonsPi.png, рассчитайте с максимальной точностью значение PI и сравните с Math.PI.
    Продемонстрируйте увеличение точности с ростом числа слагаемых N.
    */
    Homework_01.Problem_00.NewtonsPi(15); //точность 15 (не совпадает с числом Math.PI) 
    Homework_01.Problem_00.NewtonsPi(20); //точность 20 (не совпадает с числом Math.PI) 
    Homework_01.Problem_00.NewtonsPi(51); //точность 51 (полное совпадение с числом Math.PI) 
    /*
    Problem 01
    Ведите с клавиатуры номер трамвайного билета (6-значное число) и проверьте является 
    ли данный билет счастливым (если на билете напечатано шестизначное число, 
    и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).
    */
    Homework_01.Problem_01.CheckTicket();
    /*
    Problem 02
    Дано целое положительные N. Найдите число, полученное при прочтении числа N справа налево и его квадрат. 
    Например, если было введено число 345, то программа должна вывести числа 543 и 294849, а если 200, то 2 и 4.
     */
    Homework_01.Problem_02.ReverseIntPow2();
    /*
    Problem 03
    Напишите программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
    Программа должна сосчитать количество введенных пользователем пробелов. 
     */
    Homework_01.Problem_03.ReadKeyFindSpaces();

    }
    catch (Exception ex)
    {
        WriteLine(ex.Message);
    }
        WriteLine("\nEnd ...");
        ReadLine();
    }
}
