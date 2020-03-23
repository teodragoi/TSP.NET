using System;

namespace ClassLibraryNetCore.Model
{
    public class Order
    {
        public Guid Id { get; set; }
        public Client Client { get; set; }
        public OrderDetails OrderDetails { get; set; }
    }
}
