using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork4
{
    /*
     Problem 02
    Создайте массив студентов:
    Student[] studentArr = new Student[100];
    Создайте 5 студентов и внесите их в первые элементы массива.
    Распечатайте построчно содержимое всех 100 элементов массива.
    Корректно обрабатывайте (предотвращайте) ошибки при распечатке!
     */
    internal class Problem_02
    {
        public static void StudentsArr()
        {
            Student[] studentArr = new Student[100];
            for (int i = 0; i <= 5; i++)
            {
                studentArr[i] = new Student($"{i}8{i}65{i}32{i}", $"Student{i}", $"Studentov{i}", DateTime.Today);
            }

            for (int i = 0; i < 100; i++)
            {
                if (studentArr[i] != null)
                {
                    WriteLine($"{studentArr[i]}");
                }
            }
        }
    }
}
