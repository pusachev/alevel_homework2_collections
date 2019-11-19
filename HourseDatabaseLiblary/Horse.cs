using System;

namespace HourseDatabaseLiblary
{
    public class Horse
    {
        public string Pedigree { get; private set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int Victory { get; private set; }

        public int Lose { get; private set; }

        public int NumberOfRuns { get; private set; }

        public Horse(string name, string pedigree, int age, int victory, int lose)
        {
            Pedigree = pedigree;
            Name = name;
            Age = age;
            Victory = victory;
            Lose = lose;
        }


    }
}
