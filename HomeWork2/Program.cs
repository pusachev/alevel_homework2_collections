using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Hello World!");
        }
    }

    static class Menu
    {
        static void Add()
        {
            Console.WriteLine("Please enter horse name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter horse pedigree");
            string pedigree = Console.ReadLine();

            

        }

        static void Remove()
        {

        }

        static void View()
        {

        }

        private static int GetIntData(string question)
        {
            int age;

            do
            {
                Console.WriteLine(question);

            } while (!int.TryParse(Console.ReadLine(), out age));

            return age;
        }

        
    }
}
