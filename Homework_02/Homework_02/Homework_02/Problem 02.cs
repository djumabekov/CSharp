using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02
{
    /*
    ДОПОЛНИТЕЛЬНО:
    Problem 02
    Программно сформируйте файл in.txt, содержащий строчки с фамилией, именем, отчеством и датой рождения друзей 
    (с помощью метода DateTime), разделенные символом табуляции '\t'.
    Программно прочитав сформированный файл, выведите на консоль и в файл out.txt аналогичные строки с добавлением 
    поля поздравления с датой на неделю ранее.
     */
    internal class Problem_02
    {
        const string _fileName1 = "in.txt"; // исходный файл с ФИО и датой рождения
        const string _fileName2 = "out.txt"; // целевой файл с ФИО и датой рождения и датой поздравления

        public static Random r = new Random(); // генератор случайных чисел
        public static DateTime GenerateRandomDay() // метод генератор случайных дат
        {
            DateTime start = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(r.Next(range));
        }

        public static string GenerateName(int len) // метод генератор случайных ФИО
        {
            string[] consonants = { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц" };
            string[] vowels = { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц" };
            string Name = "";
            for (int i = 0; i < 3; i++){
                Name += consonants[r.Next(consonants.Length)].ToUpper();
                Name += vowels[r.Next(vowels.Length)];
                int b = 2; 
                while (b < len){
                    Name += consonants[r.Next(consonants.Length)];
                    b++;
                    Name += vowels[r.Next(vowels.Length)];
                    b++;
                }
                Name += " ";
            }
            return Name;
        }


        // сформируем файл с с ФИО и датой рождения
        public static void WritePeopleListWithHBDate() 
        {
            using var file1 = new StreamWriter(_fileName1);
            for (int i = 0; i < 10; i++)
            {
                string name = GenerateName(6); //генерируем фио
                string date = GenerateRandomDay().ToString("dd/MM/yyyy"); //генерируем дату
                WriteLine($"{name}\t{date}"); // выводим в консоль
                file1.WriteLine($"{name}\t{date}");// пишем в файл
            }
            WriteLine("File has been written");
        }

        //прочитаем файл с ФИО и датой рождения и дополним датой поздравления
        public static void ReadWritePeopleListWithHBDate()
        {
            using var file1 = new StreamReader(_fileName1);  // исходный файл с ФИО и датой рождения
            using var file2 = new StreamWriter(_fileName2); // целевой файл с ФИО, датой рождения и датой поздравления
            string line; // строка из файла
            string name; // ФИО
            DateTime date; // дата
            while ((line = file1.ReadLine()) != null) // пока строка не null читаем файл
            {
                string[] tokens = line.Split('\t', StringSplitOptions.RemoveEmptyEntries);
                name = tokens[0]; // получаем ФИО
                date = DateTime.Parse(tokens[1]); // получаем дату
                WriteLine($"{name,20}\t{date.ToString("dd/MM/yyyy"),6}\t{date.AddDays(-7).ToString("dd/MM/yyyy"),6}"); // выводим в консоль
                file2.WriteLine($"{name,20}\t{date.ToString("dd/MM/yyyy"),6}\t{date.AddDays(-7).ToString("dd/MM/yyyy"),6}");// записываем в файл
            }
            WriteLine("File has been written");
        }
    }
}
