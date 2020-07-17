using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework04.App.Entities
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }
        public string FavoriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name : {Name} Age : {Age} Type : {Type} GoodBoi : {GoodBoi} FavoriteFood : {FavoriteFood}");
        }
    }
}
