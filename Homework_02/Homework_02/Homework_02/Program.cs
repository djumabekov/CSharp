global using static System.Console;

namespace DemoNS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Problem 01
                Прочитав набор вещественных чисел из файла numbers_in.txt (можно сформировать вручную), 
                выведите на консоль минимальное, максимальное и среднее их значение. 
                Сформируйте файл numbers_out.txt данных чисел, с исключенными минимальными и максимальными 
                (учесть случай, когда их несколько).
                 */
                WriteLine("\n====================Problem 01====================\n");
                Homework_02.Problem_01.WriteNumbersToTextFile(); //сформируем файл с вещественными числам
                Homework_02.Problem_01.ReadWriteNumbersInOut(); //прочитаем файл с вещественными числами, вычислим мин., макс. и среднее значение и запишем их в другой файл


                /*
                ДОПОЛНИТЕЛЬНО:
                Problem 02
                Программно сформируйте файл in.txt, содержащий строчки с фамилией, именем, отчеством и датой рождения друзей 
                (с помощью метода DateTime), разделенные символом табуляции '\t'.
                Программно прочитав сформированный файл, выведите на консоль и в файл out.txt аналогичные строки с добавлением 
                поля поздравления с датой на неделю ранее.
                 */
                WriteLine("\n====================Problem 02====================\n");
                Homework_02.Problem_02.WritePeopleListWithHBDate();
                Homework_02.Problem_02.ReadWritePeopleListWithHBDate();

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