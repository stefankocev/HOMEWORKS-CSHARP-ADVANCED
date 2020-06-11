using SEDC.Homework04.App.Entities;
using System;

namespace SEDC.Homework04.App
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog1 = new Dog() { Id = 4, Name = "Boo", Color = null };
            Dog dog2 = new Dog() { Id = 4, Name = "Angie", Color = "white" };
            Dog dog3 = new Dog() { Id = -5, Name = "Mickey", Color = "black" };
            bool dog1Validation = dog1.Validate(dog1.Id, dog1.Name, dog1.Color);
            bool dog2Validation = dog2.Validate(dog2.Id, dog2.Name, dog2.Color);
            bool dog3Validation = dog3.Validate(dog3.Id, dog3.Name, dog3.Color);
                if (dog1Validation)
                {
                    DogShelter.ListOfDogs.Add(dog1);
                }
                if (dog2Validation)
                {
                    DogShelter.ListOfDogs.Add(dog2);
                }
            if (dog3Validation)
            {
                DogShelter.ListOfDogs.Add(dog3);
            }
            Console.WriteLine(DogShelter.PrintAll(DogShelter.ListOfDogs));
            Console.ReadLine();
        }
   
}
}
