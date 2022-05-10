using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Classwork_15 {
	/*
	 Problem 02
		Реализуйте класс Students с методами быстрого поиска по StudentID и IIN:
		class Students {
			Dictionary<long, Student> _dictByID = new Dictionary<long, Student>();
			Dictionary<string, Student> _dictByIIN = new Dictionary<string, Student>();

			public Students(string fileName, int size = 0) {	. . .

			public Student FindByID(long studentID) { . . .
	
			public Student FindByIIN(string iIN) { . . .
		}	

		Реализуйте класс Groups с методом быстрого поиска по GroupID:
			public Group FindByID(long groupID) { . . .
			 */
	internal class Problem_02 {
    /*
     Problem 02
     */

    class Students: Student {
      Dictionary<long, Student> _dictByID = new Dictionary<long, Student>();
      Dictionary<string, Student> _dictByIIN = new Dictionary<string, Student>();
			public Students(string fileName, int size = 0) {
				using (var file = new StreamReader(fileName)) {
					string line;
					int count = 0;
					while ((line = file.ReadLine()) != null) {
						_dictByID.Add(GetStudentFromLine(line).StudentId, GetStudentFromLine(line));
						_dictByIIN.Add(GetStudentFromLine(line).IIN, GetStudentFromLine(line));
						count++;
						if (count == size)
							break;
					}
				}
			}

			public Student FindByID(long studentID) {
				Student student = null;
        try {
					if (_dictByID.TryGetValue(studentID, out Student s)) {
						student = s;
					}
				}
				catch (Exception ex) {
					WriteLine(ex.Message);
				}
				return student;
			}

			public Student FindByIIN(string iIN) {
				Student student = null;
				try {
					if (_dictByIIN.TryGetValue(iIN, out Student s)) {
						student = s;
					}
				} catch (Exception ex) {
					WriteLine(ex.Message);
				}
				return student;
			}
			public static List<Student> GetStudentWithGroupNameList(string studFileName, string groupFileName, int size = 10_000) {

				var studentsList = GetStudentList(studFileName, size);

				var groups = new Groups(groupFileName, size);

				var studentsWithGroups = new List<Student>();

				for (int i = 0; i < studentsList.Count; i++) {
					studentsWithGroups.Add(new Student() {
						Birthday = studentsList[i].Birthday,
						FirstName = studentsList[i].FirstName,
						LastName = studentsList[i].LastName,
						GroupId = studentsList[i].GroupId,
						IIN = studentsList[i].IIN,
						StudentId = studentsList[i].StudentId,
						GroupName = groups.FindByID(studentsList[i].GroupId).GroupName,
					});
				}
				return studentsWithGroups;
			}
		}

		class Groups: Group {
			Dictionary<long, Group> _dictByID = new Dictionary<long, Group>();
			public Groups(string fileName, int size = 0) {
				using (var file = new StreamReader(fileName)) {
					string line;
					int count = 0;
					while ((line = file.ReadLine()) != null) {
						_dictByID.Add(GetGroupFromLine(line).GroupId, GetGroupFromLine(line));
						if (count == size)
							break;
					}
				}
			}

			public Group FindByID(long groupID) {
				Group group = null;
				try {
					if (_dictByID.TryGetValue(groupID, out Group g)) {
						group = g;
					}
				} catch (Exception ex) {
					WriteLine(ex.Message);
				}
				return group;
			}
		}


		public static void Demo() {
			int size = 1_000_000;
			string studFileName = @"C:\_0\students_10_000_000.txt";
			string studFileNameSample = @"C:\_0\students_1_000_sample.txt";
			string groupFileName = @"C:\_0\groups_1_000_000.txt";

			WriteLine("Подгружаем файлы... \n");

			var students = new Students(studFileName, size);

			var studentsSample= Student.GetStudentList(studFileNameSample, 1000);

			WriteLine("=======Измерние времени поиска в Dictionary========= \n");

			var sw = new Stopwatch();
			sw.Restart();
			int count = 0;
			foreach (var student in studentsSample) {
				students.FindByID(student.StudentId);
				count++;
			}
			sw.Stop();
			WriteLine($"Time elapsed for find {count} StudentId = {sw.Elapsed}\n");

			sw.Restart();
			count = 0;
			foreach (var student in studentsSample) {
				students.FindByIIN(student.IIN);
				count++;
			}
			sw.Stop();
			WriteLine($"Time elapsed for find {count}  IIN = {sw.Elapsed}\n");

      WriteLine();

			var studentsList = Student.GetStudentList(studFileName, size);

			WriteLine("=======Измерение времени поиска в List========= \n");

			sw.Restart();
			count = 0;
			foreach (var student in studentsSample) {
				studentsList.Find(i => i.StudentId == student.StudentId);
				count++;
			}
			sw.Stop();
			WriteLine($"Time elapsed for find {count} StudentId = {sw.Elapsed}\n");

			sw.Restart();
			count = 0;
			foreach (var student in studentsSample) {
				studentsList.Find(i => i.IIN == student.IIN);
				count++;
			}
			sw.Stop();
			WriteLine($"Time elapsed for find {count} IIN = {sw.Elapsed}\n");

			WriteLine("=======Сформируем файл studentsAndGroups_10_000_000.txt и выведем в консоль========= \n");

			var studList = Students.GetStudentWithGroupNameList(studFileName, groupFileName, size);
			Utils.PrintListByLines(studList);

			string fileOutName = @"C:\_0\studentsAndGroups_10_000_000.txt";
			using var outFile = new StreamWriter(fileOutName);
			foreach (var item in studList) outFile.WriteLine($"{item}");
		}

	}
}
