using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibraryNetCore.Model
{
    public class OrderDetails
    {
        public Guid Id { get; set; }

        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public double TotalValue { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
