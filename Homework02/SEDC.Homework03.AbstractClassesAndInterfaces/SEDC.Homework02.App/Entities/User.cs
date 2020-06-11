using SEDC.Homework02.App.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework02.App.Entities
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
