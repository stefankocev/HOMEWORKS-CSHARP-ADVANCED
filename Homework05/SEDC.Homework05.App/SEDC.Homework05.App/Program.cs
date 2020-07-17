using SEDC.Homework05.App.DB;
using System;
using System.Linq;

namespace SEDC.Homework05.App
{
    class Program
    {
        static void Main(string[] args)
        {


            var personStartsWithROrderedByAge = DataBase.people.Where(man => man.FirstName.StartsWith("R"))
                                                               .GroupBy(person => person.Age)
                                                               .OrderByDescending(x => x.Key).ToList();
    

            var allBrownDogsAndOlderThan3Years = DataBase.dogs.Where(dog => dog.Color == "Brown" && dog.Age > 3)
                                                              .GroupBy(dog => dog.Age)
                                                              .OrderBy(x => x.Key).ToList();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
