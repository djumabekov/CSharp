using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Classwork_7 {
	public class Student : IComparable {
		public long StudentId { get; set; }
		public string IIN { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime Birthday { get; set; }
		public long GroupId { get; set; }


		public override string ToString()
		{
			return $"{StudentId} {IIN} {LastName} {FirstName} {Birthday} {GroupId}";
		}

		private static Student GetStudentFromLine(string line)
		{
			//. . .
			string[] words = line.Split('\t');
			long studentId = Int64.Parse(words[0]);
			long groupId = Int64.Parse(words[5]);

			DateTime birthday = DateTime.ParseExact(words[4], "MM/dd/yyyy", null);
			return new Student() { StudentId = studentId, IIN = words[1], LastName = words[2], FirstName = words[3], Birthday = birthday, GroupId = groupId };
		}

		public static List<Student> GetStudentsArr(string fileName, int size = 10_000_000)
		{
			//. . .
			List<Student> students = new List<Student>(size);
			using (var file = new StreamReader(fileName))
			{
				string line;
				int count = 0;
				while ((line = file.ReadLine()) != null)
				{
					students.Add(GetStudentFromLine(line));
					//Group group = GetGroupFromLine(line);
					//groups[count] = group;
					count++;
					if (count == size)
						break;
				}
			}
			return students;
		}

		public static void PrintArray(List<Student> students)
		{

			int size = students.Count;
			if (size <= 8)
			{
				for (int i = 0; i < size; i++)
				{
					Write(students[i]);
				}
			}
			else
			{
				for (int i = 0; i < 4; i++)
				{
					Write(students[i]);
				}
				Write(" . . . .");
				for (int i = size - 4; i < size; i++)
				{
					Write(students[i]);
				}
			}
			WriteLine();
		}

		/*
		 * компаратор для сравнения объектов Student по ИИН 
		 */
		public int CompareTo(object? o) {
			if (o is Student student) return IIN.CompareTo(student.IIN);
			else throw new ArgumentException("Некорректное значение параметра");
		}
		/*
		 * метод проверки уникальности ИИН
		 */
		public static (bool result, string IIN) CheckUnicIIN(List<Student> students) {
			bool result = true;
			string IIN = "";
			var tupleLists = (result, IIN);
			// сортировка массива по ИИН от меньшего к большему
			students.Sort(delegate (Student x, Student y) { 
				return x.IIN.CompareTo(y.IIN);
			});

			for (int i=0; i< students.Count-1; i++) {
				//если в отстортированном массиве текущее значение ИИН равно следующему, то ИИН не уникальны (возвращаем false)
				if (students[i].IIN.Equals(students[i + 1].IIN)) { tupleLists.result = false; tupleLists.IIN = students[i].IIN; break; }
			}
			// иначе уникальны (возвращаем true)
			return tupleLists;
		}
		}
}
