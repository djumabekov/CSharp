using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Classwork_06
{
	public class Student
	{
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

		public static Student[] GetStudentsArr(string fileName, int size = 10_000_000)
		{
			//. . .
			Student[] students = new Student[size];
			using (var file = new StreamReader(fileName))
			{
				string line;
				int count = 0;
				while ((line = file.ReadLine()) != null)
				{
					students[count++] = GetStudentFromLine(line);
					//Group group = GetGroupFromLine(line);
					//groups[count] = group;
					//count++;
					if (count == size)
						break;
				}
			}
			return students;
		}

		public static void PrintArray(Student[] arr)
		{

			int size = arr.Length;
			if (size <= 8)
			{
				for (int i = 0; i < size; i++)
				{
					Write(arr[i]);
				}
			}
			else
			{
				for (int i = 0; i < 4; i++)
				{
					Write(arr[i]);
				}
				Write(" . . . .");
				for (int i = size - 4; i < size; i++)
				{
					Write(arr[i]);
				}
			}
			WriteLine();
		}
	}
}
