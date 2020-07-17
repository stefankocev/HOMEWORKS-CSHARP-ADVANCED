using System;
using System.Collections.Generic;
using System.Text;
using Type = SEDC.Homework04.App.Enum.Type;

namespace SEDC.Homework04.App.Entities
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public Type Type { get; set; }
        public int Age { get; set; }
        public abstract void PrintInfo();

    }
}
