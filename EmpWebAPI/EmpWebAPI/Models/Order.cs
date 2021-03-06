﻿using System;
using System.Collections.Generic;

namespace EmpWebAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        public long OrderId { get; set; }
        public string OrderNo { get; set; }
        public int? CustomerId { get; set; }
        public string Pmmethod { get; set; }
        public decimal? Gtotal { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderItems> OrderItems { get; set; }
    }
}
