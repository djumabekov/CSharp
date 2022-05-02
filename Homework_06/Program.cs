using System;
using static System.Console;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace Classwork_06
{

    class Program
    {

		static void Main(string[] args)
		{
			string groupFileName = @"C:\_0\groups_1_000_000.txt";
			string groupFileNameBad = @"C:\_0\groups_bad.txt";
			string studentFileName = @"C:\_0\students_10_000_000.txt";
			try
			{
        /*
				 ОСНОВНЫЕ ЗАДАЧИ

				Problem 01 (GetStudentsArray.txt) 
				Измерьте времена создания массивов 1_000_000 групп и 10_000_000 студентов в режиме - x64, Release. 
				*/

        WriteLine("\n====================Problem 01====================\n");

        var sw = new Stopwatch();
        sw.Restart();
        var groupArr = Group.GetGroupsArr(groupFileName, 1_000);
        sw.Stop();
        WriteLine($"Group array size = {groupArr.Length},  Time elapsed for Group: {sw.Elapsed}\n");
        Group.PrintArray(groupArr);
        WriteLine();

        sw.Restart();
        var studArr = Student.GetStudentsArr(studentFileName, 10_000);
        WriteLine($"Student array size = {studArr.Length}, Time elapsed for Student: {sw.Elapsed}\n");
        sw.Stop();
        Student.PrintArray(studArr);

        /*
				В массиве 10_000_000 студентов:
				 - найдите максимальную длину фамилии и имени среди всех студентов.
				 - найдите максимальные и минимальные даты рождения.
				 */
        var longestLastName = studArr.Where(s => s.LastName.Length == studArr.Max(m => m.LastName.Length)).First();
        var longestFirstName = studArr.Where(s => s.FirstName.Length == studArr.Max(m => m.FirstName.Length)).First();

        DateTime earliest = studArr.Min(record => record.Birthday);
        DateTime latest = studArr.Max(record => record.Birthday);

        WriteLine($"Максимальная длина фамилии: {longestLastName.LastName},  Максимальная длина имени: {longestFirstName.FirstName}\n");
        WriteLine($"Максимальная дата рождения: {latest},  Минимальная дата рождения: {earliest}\n");

        /*
				Напишите метод
				public static Group[] GetGroupsArr(string fileName, out int nGoodGroups, int size = 0)
				дополнительно определяющий с помощью обработки исключений количество корректных строк в файле groups_1_000_000.txt - то есть количество реально записанных групп в массив. Проверьте работу метода, внеся в файл несколько преднамеренных ошибок.
				Последние незаполненный элементы массива, естественно, будут равны null - сделайте проверку и сопоставьте с nGoodGroups.
				 */

        var groupArr2 = Group.GetGroupsArr(groupFileNameBad, out int nGoodGroups, 10);
        WriteLine($"Group2 array size = {groupArr2.Length},  nGoodGroups: {nGoodGroups}\n");


        WriteLine("\n====================Problem 02====================\n");

        /*
				Problem 02
				Напишите программу, демонстрирующую возникновение и перехват ряда стандартных исключений: 
				ArgumentException
				ArgumentNullException
				ArgumentOutOfRangeException
				InvalidOperationException
				NotSupportedException
				DivideByZeroException
				OverflowException
				 */

        Problem_02.DemoExeptions();

			}
			catch (Exception ex)
			{
				WriteLine(ex.Message);
			}
			WriteLine("\nEnd . . .");
			ReadLine();
		}

	}
}
