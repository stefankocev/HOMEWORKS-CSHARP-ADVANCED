using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework04.App.Entities
{
    public static class DogShelter
    {
        public static List<Dog> ListOfDogs { get; set; } = new List<Dog>();
        public static string PrintAll(List<Dog> dogs)
        {
            foreach (var dog in dogs)
            {
                return $"Id: {dog.Id}, Name: {dog.Name}, Color: {dog.Color}";
            }
            return string.Empty;
        }

    }
}
