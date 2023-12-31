﻿using System.Collections.Generic;

namespace CRM_Bl.Model
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Check> Checks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
