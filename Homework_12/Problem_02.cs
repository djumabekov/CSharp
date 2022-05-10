using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_12 {
  internal class Problem_02 {
		/*
		 Problem 02 (StringListDelegates)
		 Напишите метод
		 public static List<string> GetAllWords(string fileName),
		 возвращающий все слова из текстового файла, используя следующие разделители:
		 char[] delims = {' ', '.', '!', '?', ',', '(', ')', '\t', '\n', '\r', '-', ';', ':' };
		 var arr = line.Split(delims, StringSplitOptions.RemoveEmptyEntries); //для удаления пустых строк


		 Напишите методы:
		 public static bool CheckIfAll(List<string> list, Func<string, bool> func)
		 public static bool CheckIfAny(List<string> list, Func<string, bool> func)
		 public static string FirstOrDefault(List<string> list, Func<string, bool> func)
		 public static int FindFirstIndex(List<string> list, Func<string, bool> func) 
		 public static int Count(List<string> list, Func<string, bool> func) 

		 CheckIfAll - проверяет, удовлетворяют ли все слова в list условию func.
		 CheckIfAny - проверяет, удовлетворяет ли хоть одно слово в list условию func.
		 FirstOrDefault - возвращает первое слово, удовлетрворяющее условию func или string.Empty, если не находит.
		 FindFirstIndex - возвращает индекс первого вхождения или -1, если не находит.
		 Count - возвращает количество слов, удовлетворяющих условию func.

		 В духе приведенного образца, напишите свою демонстрацию, использую БОЛЕЕ СЛОЖНЫЕ лямбда-выражения:
		 public static void Demo () {
			 string fileName = @"C:\_0\Война и мир - UTF-8.txt";
			 var list = UtilsNS.Strings.GetAllWords(fileName);
			 bool result; int index, count;
			 result = CheckIfAll(list, (s) => s.Length > 0);
			 WriteLine(result);
			 result = CheckIfAll(list, (s) => s.Length > 1);
			 WriteLine(result);
			 result = CheckIfAll(list, (s) => s.Contains("a"));
			 WriteLine(result);

			 result = CheckIfAny(list, (s) => s.Length == 16);
			 WriteLine(result);
			 WriteLine();

			 result = CheckIfAny(list, (s) => s == "медведь");
			 WriteLine(result);
			 count = Count(list, (s) => s == "медведь");
			 WriteLine(count);
			 index = FindFirstIndex(list, (s) => s == "медведь");
			 WriteLine(index);

			 count = Count(list, (s) => s.Contains("медвед"));
			 WriteLine(count);
			 count = Count(list, (s) => s.StartsWith("мед"));
			 WriteLine(count);

			 var word = FirstOrDefault(list, (s) => s.StartsWith("мед"));
			 WriteLine(word);
			 WriteLine();

			 count = Count(list, (s) => s == "Андрей" || s == "Пьер" || s == "Наташа" );
			 WriteLine(count);
		 }

		*/

		public static List<string> GetAllWords(string fileName) {
			char[] delims = { ' ', '.', '!', '?', ',', '(', ')', '\t', '\n', '\r', '-', ';', ':' };


			using var file = new StreamReader(fileName);

			List<string> wordList = new List<string>(); 

			string line; // строка из файла

			while ((line = file.ReadLine()) != null) // пока строка не null читаем файл
			{
				wordList.AddRange(line.Split(delims, StringSplitOptions.RemoveEmptyEntries)); //для удаления пустых строк
			}

			return wordList;

		}

		public static bool CheckIfAll(List<string> list, Func<string, bool> func) {
			foreach (var word in list) {
				if (!func(word)) return false;
			}
			return true;
		}

		public static bool CheckIfAny(List<string> list, Func<string, bool> func) {
			foreach (var word in list) {
				if (func(word)) return true;
			}
			return false;
		}

		public static string FirstOrDefault(List<string> list, Func<string, bool> func) {
			foreach (var word in list) {
				if (func(word)) return word;
			}
			return string.Empty;
		}
		public static int FindFirstIndex(List<string> list, Func<string, bool> func) {
			for (int i=0; i< list.Count; i++) {
				if (func(list[i])) return i;
			}
			return -1;

		}
		public static int Count(List<string> list, Func<string, bool> func) {
			int count = 0;
			foreach (var word in list) {
				if (func(word)) count++;
			}
			return count;
		}


		public static void Demo() {
			string fileName = @"C:\_0\War_and_Peace-UTF-8.txt";
			List<string> wordList = GetAllWords(fileName);
			Utils.PrintListByLines(wordList);

			Func<string, bool> checkWord = (word) =>  word.Equals("War");
			Func<string, bool> checkWordSize = (word) =>  word.Length > 8;
			Func<string, bool> checkWordFirstSym = (word) =>  word.First() == 'A' || word.First() == 'B' || word.First() == 'C';
			Func<string, bool> checkWordLastSym = (word) => word.Last() == 'a' || word.Last() == 'b' || word.Last() == 'c';
			Func<string, bool> checkWordFirstLastSym = (word) => word.First() == 'A' & word.Last() == 'a' || word.First() == 'B' & word.Last() == 'b' || word.First() == 'C' & word.Last() == 'c';

			bool isCheckedWord = CheckIfAll(wordList, checkWord);
			WriteLine($"Все ли слова в книге 'War'?  {isCheckedWord}");

			isCheckedWord = CheckIfAny(wordList, checkWordSize);
			WriteLine($"Есть ли в книге слово больше 8 символов?  {isCheckedWord}");

			string word = FirstOrDefault(wordList, checkWordFirstSym);
			WriteLine($"Первое слово, удовлетрворяющее условию первого символа равного А,B или С ?  {word}");

			word = FirstOrDefault(wordList, checkWordLastSym);
			WriteLine($"Первое слово, удовлетрворяющее условию последнего символа равного a,b или c ?  {word}");

			int indexOfWord = FindFirstIndex(wordList, checkWordLastSym);
			WriteLine($"Индекс первого слова, удовлетрворяющее условию последнего символа равного a,b или c ?  {indexOfWord}");

			int countOfWord = Count(wordList, checkWordFirstLastSym);
			WriteLine($"Количество слов, удовлетворяющее условию первого символа равного А ,B или С и последнего символа равного a,b или c соответственно?  {countOfWord}");

		}

	}
}
