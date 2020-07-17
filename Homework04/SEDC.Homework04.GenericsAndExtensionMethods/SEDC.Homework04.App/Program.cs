using SEDC.Homework04.App.Entities;
using System;

namespace SEDC.Homework04.App
{
    class Program
    {
        public static PetStore<Pet> PetStore = new PetStore<Pet>();
        static void Main(string[] args)
        {
            PetStore.InsertPet(new Cat() { Name = "Cat1" , Type = Enum.Type.Cat, Age = 2, Lazy = true, LifesLeft = 9 });
            PetStore.InsertPet(new Cat() { Name = "Cat2", Type = Enum.Type.Cat, Age = 4, Lazy = false, LifesLeft = 4 });

            PetStore.InsertPet(new Dog() { Name = "Dog1", Type = Enum.Type.Dog, Age = 2, GoodBoi = true, FavoriteFood = "snacks" });
            PetStore.InsertPet(new Dog() { Name = "Dog2", Type = Enum.Type.Dog, Age = 4, GoodBoi = false, FavoriteFood = "Dog's food" });

            PetStore.InsertPet(new Fish() { Name = "Fish1", Type = Enum.Type.Fish, Age = 2, Color = "Gold" , Size = "Small" });
            PetStore.InsertPet(new Fish() { Name = "Fish2", Type = Enum.Type.Fish, Age = 4, Color = "Black", Size = "Medium" });

            PetStore.BuyPet("Jackie");
            PetStore.BuyPet("Cat2");

            PetStore.BuyPet("Roman");
            PetStore.BuyPet("Dog1");

            PetStore.PrintAll();
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
