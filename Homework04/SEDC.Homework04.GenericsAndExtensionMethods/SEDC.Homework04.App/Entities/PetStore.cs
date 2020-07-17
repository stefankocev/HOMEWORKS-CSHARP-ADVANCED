using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Homework04.App.Entities
{
    public class PetStore<T> where T : Pet
    {
        private List<T> ListOfPets;
        public PetStore()
        {
            ListOfPets = new List<T>();
        }
        public void InsertPet(T pet)
        {
            ListOfPets.Add(pet);
        }
        public void PrintAll()
        {
            foreach (T pet in ListOfPets)
            {
                pet.PrintInfo();
            }
        }
        public void BuyPet(string name)
        {
            var foundPet = ListOfPets.FirstOrDefault(petName => name == petName.Name);
            if(foundPet != null)
            {
                Console.WriteLine($"You have successfully bought {foundPet.Name}. Say hello to your {foundPet.Type}");
                ListOfPets.Remove(foundPet);
            }else
                Console.WriteLine("There is no pet with that name!");
        }
    }
}
