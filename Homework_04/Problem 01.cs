using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork4
{
    /*
     Problem 01
    Создайте класс Student со свойствами  string IIN, string LastName, string FirstName, DateTime Birthday.
    Напишите конструкторы:
    public Student() {} // по умолчанию
    public Student(string iIN, string lastName, string firstName, DateTime birthday) {
    . . .
    Реализуйте метод
    public override string ToString() {
	    return $"{IIN} {LastName} {FirstName} {Birthday}";
    }

    Создайте два объекта Student
     - с помощью конструктора: var student1 = new Student("222222222222", "Ahmetov", "Abai", . . .
     - с помощью инициализатора: var student2 = new Student { IIN = "111111111111", LastName = "Ivanov", . . .
    Выведите их на консоль: WriteLine(student1), WriteLine(student2).

    Реализуйте свойство Rating (средняя оценка студента):
    private double _rating;
    public double Rating { 
      get {
	    .  . .
	    set {
      . . .

    В сеттере делайте проверку, что оценка лежит в интервале 0-12, в противном случае выбрасывайте исключение:
     throw new Exception("Неверное значения Rating!");
    В геттере записывайте в журнальный файл сообщение об имеющейся попытке прочитать (взять значение) Rating:
    using (var logFile = new StreamWriter("log.txt", append: true)) {
	    logFile.WriteLine($"Прочитано значение Rating ({_rating}) у студента {IIN}");
    }
    Продемонстрируйте работу геттера и сеттера.
     */
    public class Student
    {
        public string IIN { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }
        private double _rating;
        public double Rating
        {
            get {
                using (var logFile = new StreamWriter("log.txt", append: true))
                {
                    logFile.WriteLine($"Прочитано значение Rating ({_rating}) у студента {IIN}");
                }
                return _rating;
            } 
            set {
                if (value < 0 || value > 12)
                {
                    throw new Exception("\nНеверное значения Rating!");
                }
                else { _rating = value; }
                
            } 
        }
        public Student() { } // по умолчанию
        public Student(string IIN, string FirstName, string LastName, DateTime Birthday) {
            this.IIN = IIN;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
        }


        public override string ToString()
        {
            return $"{IIN} {LastName} {FirstName} {Birthday}";
        }
    }
}
