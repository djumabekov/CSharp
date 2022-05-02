global using static System.Console;

namespace DemoNS
{

    class DemoNS
    {
        static void Main(string[] args)
        {
            try
            {


                //Classwork05.Problem_01.Demo();
                //Classwork05.Problem_02.Demo();
                //Classwork05.Problem_03.Demo();
                Classwork05.Problem05.Demo();

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