using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClassLibraryNetCore.Model
{
    public class Client
    {
        public Guid Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
