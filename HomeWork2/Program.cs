using System;
using HourseDatabaseLiblary;

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
        public static Horse Add()
        {
            Console.WriteLine("Please enter horse name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter horse pedigree");
            string pedigree = Console.ReadLine();

            int age = GetIntData("Please enter age: ");
            int victory = GetIntData("Please enter count of victory: ");
            int lose = GetIntData("Please enter lose; ");


            return new Horse(name, pedigree, victory, lose);

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
