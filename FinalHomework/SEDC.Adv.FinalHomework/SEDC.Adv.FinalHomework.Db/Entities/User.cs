using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Statistics { get; set; }

        public override string PrintInfo()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}
