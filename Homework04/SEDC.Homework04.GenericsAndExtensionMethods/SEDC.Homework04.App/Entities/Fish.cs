using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework04.App.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Name : {Name} Age : {Age} Type : {Type} Color : {Color} Size: {Size}");
        }
    }
}
