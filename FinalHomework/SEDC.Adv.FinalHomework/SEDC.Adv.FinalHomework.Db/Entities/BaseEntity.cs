using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.FinalHomework.Db.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string PrintInfo();
    }
}
