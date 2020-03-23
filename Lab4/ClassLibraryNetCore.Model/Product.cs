using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public double Price { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
