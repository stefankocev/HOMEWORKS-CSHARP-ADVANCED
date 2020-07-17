using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework04.App.Entities
{
    public class Cat : Pet
    {
        public bool Lazy { get; set; }
        public int LifesLeft { get; set; }
        public override void PrintInfo()
        {
                Console.WriteLine($"Name : {Name} Age : {Age} Type : {Type} Laziness : {Lazy} LifesLeft: {LifesLeft}");
        }
    }
}
