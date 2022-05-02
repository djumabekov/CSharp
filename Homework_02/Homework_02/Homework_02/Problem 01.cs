using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    /*
    Problem 01
    Прочитав набор вещественных чисел из файла numbers_in.txt (можно сформировать вручную), 
    выведите на консоль минимальное, максимальное и среднее их значение. 
    Сформируйте файл numbers_out.txt данных чисел, с исключенными минимальными и максимальными 
    (учесть случай, когда их несколько).
     */

    internal class Problem_01
    {
        const string _fileName1 = "numbers_in.txt"; // исходный файл с вещественными числам
        const string _fileName2 = "numbers_out.txt"; // целевой файл с результатами вычислений

        // сформируем файл с вещественными числам
        public static void WriteNumbersToTextFile() 
        {
            using var file1 = new StreamWriter(_fileName1);
            for (int i = 0; i < 10; i++)
            {
                double x = i * i + 0.1;
                file1.WriteLine($"{x};");
            }
            WriteLine("File has been written");
        }

        //прочитаем файл с вещественными числами, вычислим мин., макс. и среднее значение и запишем их в другой файл
        public static void ReadWriteNumbersInOut()
        {
            using var file1 = new StreamReader(_fileName1);  // исходный файл с вещественными числам
            using var file2 = new StreamWriter(_fileName2); // целевой файл с результатами вычислений

            List<Double> dNumbersList = new List<Double>(); // список содержащий вещественные числа добытые из файла
            string line; // строка из файла
            while ((line = file1.ReadLine()) != null) // пока строка не null читаем файл
            {
                double dNumber = Double.Parse(line.Split(';', StringSplitOptions.RemoveEmptyEntries)[0]); // разбиваем строку на массив и конвертируем строковое значение в вещественное
                dNumbersList.Add(dNumber); // добавляем вещественное число в список
                WriteLine($"number = {dNumber,5:N3}"); // выводим вещественное число в консоль
            }

            double min = dNumbersList.Min(); // вычисляем мин. значение в списке
            double max = dNumbersList.Max(); // вычисляем макс. значение в списке
            double avg = dNumbersList.Average(); // вычисляем среднее значение в списке

            WriteLine($"min number = {min,5:N3}, max number = {max,5:N3}, avg number = {avg,5:N3}"); // выводим результат в консоль

            foreach (double number in dNumbersList) { // пробегаемся по списку 
                if (number != min && number != max) { // если значения списка не равны min или max,
                    file2.WriteLine($"{number};"); // то записываем их в целевой файл
                }
            }
            WriteLine("File has been written");
        }
    }
}
