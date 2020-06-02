using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<PhotoDTO> Photos { get; set; }
    }
}
