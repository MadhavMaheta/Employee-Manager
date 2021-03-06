﻿using System;
using System.Collections.Generic;

namespace EmpWebAPI.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int CustometId { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
