using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    internal class Problem_00
    {
        /*
        Problem 00 - NewtonsPi
        По формуле, приведенной на рисунке NewtonsPi.png, рассчитайте с максимальной точностью значение PI и сравните с Math.PI.
        Продемонстрируйте увеличение точности с ростом числа слагаемых N.
        */
        public static void NewtonsPi(int occuracyRate/*уровень точности вычисления*/) 
        {
            double CalculatePi(int i)
            {
                double PI = 0; //инициализируем переменную PI
                if (i <= occuracyRate) //пока i не больше указанной точности запускаем рекурсивный цикл вычисления PI 
                {
                    PI =   1 + i / (2.0 * i + 1) * CalculatePi(i + 1);
                }
                return PI; //возвращаем PI
            }

            double PI = 2 * CalculatePi(1);
            string result = (PI == Math.PI) ? "оба числа совпадают" : "оба числа не совпадают";
            Console.WriteLine($"Число ПИ с точностью числа слагаемых({occuracyRate}): {PI} => Число Math.PI = {Math.PI}, {result}");

        }
    }
}
