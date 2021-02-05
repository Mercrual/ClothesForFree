using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Ad
    {
        public int Id { get; set; }        
        public DateTime DateTimePub { get; set; }
        public string Description { get; set; }
        public string Photos { get; set; }
        public string Contacts { get; set; }
        public string City { get; set; }
        public User User { get; set; }
    }
}
