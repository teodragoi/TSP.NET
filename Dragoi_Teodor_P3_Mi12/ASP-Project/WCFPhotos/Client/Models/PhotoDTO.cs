using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Models
{
    public class PhotoDTO
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Event { get; set; }
        public string PhotoUrl { get; set; }
        public string Date { get; set; }

        public List<PersonDTO> People { get; set; }
    }
}
