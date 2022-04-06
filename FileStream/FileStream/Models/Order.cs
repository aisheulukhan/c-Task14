using System;
using System.Collections.Generic;
using System.Text;

namespace FileStream.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
