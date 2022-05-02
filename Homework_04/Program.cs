global using static System.Console;


namespace DemoNS
{
    class DemoNS
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("\n====================Problem 01====================\n");
                /*
                 Problem 01
                 Создайте класс Student со свойствами  string IIN, string LastName, string FirstName, DateTime Birthday.
                 */
                var student1 = new Classwork4.Student("123456789", "Ivan", "Ivanov", DateTime.Today);
                var student2 = new Classwork4.Student { IIN = "123456789", FirstName = "Ivan", LastName="Ivanov", Birthday=DateTime.Today };
                Write($"\nstudent1 = {student1.ToString()}");
                Write($"\nstudent2 = {student2.ToString()}");
                student1.Rating = 10;
                double raiting1 = student1.Rating;
                Write($"\nstudent1.Rating = {raiting1}");

                student2.Rating = 10; //выше 12 или ниже 0 вызывает исключение
                double raiting2 = student2.Rating;
                Write($"\nstudent1.Rating = {raiting2}");

                WriteLine("\n====================Problem 02====================\n");
                /*
                Problem 02
                Создайте массив студентов:
                Student[] studentArr = new Student[100];
                Создайте 5 студентов и внесите их в первые элементы массива.
                Распечатайте построчно содержимое всех 100 элементов массива.
                Корректно обрабатывайте (предотвращайте) ошибки при распечатке!
                 */
                Classwork4.Problem_02.StudentsArr();

                WriteLine("\n====================Problem 03====================\n");
                /*   
                Problem 03
                Реализуйте два метода 
                void ArrInfo1(double[] arr, . . .)
                . .  ArrInfo2(double[] arr)
                позволяющие получить минимальное, максимальное и среднее значения массива с помощью:
                1) out - параметров
                2) tuple
                Продемонстрируйте работу на случайном массиве из 100_000_000 элементов.
                */
                Classwork4.Problem_03.CreateArray();
                Classwork4.Problem_03.PrintArrInfo();

                WriteLine("\n====================Problem 04====================\n");

                Classwork4.Problem_04.PointClass pC = new Classwork4.Problem_04.PointClass();
                Classwork4.Problem_04.PointStruct pS = new Classwork4.Problem_04.PointStruct();
                WriteLine($"pC.X = {pC.X}, pC.Y = {pC.Y}");
                WriteLine($"pS.X = {pS.X}, pS.Y = {pS.Y}");

                WriteLine("Метод, увеличивающий координаты p на x=10, y=5:");
                Classwork4.Problem_04.ChangePointClass(ref pC, 10, 5);
                Classwork4.Problem_04.ChangePointStruct(ref pS, 10, 5);
                WriteLine($"pC.X+x = {pC.X}, pC.Y+y = {pC.Y}");
                WriteLine($"pS.X+x = {pS.X}, pS.Y+y = {pS.Y}");

                WriteLine("Метод, создающий p с координатами x=3, y=4:");
                Classwork4.Problem_04.PointClass pC2 = new Classwork4.Problem_04.PointClass();
                Classwork4.Problem_04.PointStruct pS2 = new Classwork4.Problem_04.PointStruct();
                Classwork4.Problem_04.GetNewPointClass(out pC2, 3, 4);
                Classwork4.Problem_04.GetNewPointStruct(out pS2, 3, 4);
                WriteLine($"pC2.X = {pC2.X}, pC2.Y = {pC2.Y}");
                WriteLine($"pS2.X = {pS2.X}, pS2.Y = {pS2.Y}");

                WriteLine("\n====================Problems====================\n");
                /*
                Problems
                Для получения высокой оценки дополнительно предоставьте самостоятельно 
                решенные задачи повышенной сложности, в том числе, и с предыдущего занятия.
                
                Problem - createRandUniqueArray
                Напишите функцию 
                int *createRandUniqueArray(int size, bool randomSeed = false)
                возвращающую динамический массив заданного размера size, содержащий УНИКАЛЬНЫЕ случайные числа.
                При randomSeed == false функция должна возвращать каждый раз один и тот же массив, при randomSeed == true - разные.
                Напишите тестовую функцию
                bool isUnique(const int *arr, int size) 
                для проверки уникальности массива.
                Напишите функцию 
                int *createRandUniqueArray(int size, int int, int max, bool randomSeed = false)
                возвращающую динамический массив, содержащий УНИКАЛЬНЫЕ случайные числа в интервале [min, max) (min включается, max - нет).
                */

                Classwork4.Problems.Demo();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            WriteLine("\nEnd ...");
            ReadLine();
        }

    }
}