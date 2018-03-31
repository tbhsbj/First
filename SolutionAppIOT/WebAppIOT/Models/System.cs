using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppIOT.Models
{
    public class System
    {   
        public int systemID { get; set; }
        public string nom { get; set; }
        public string adressIP { get; set; }
        public Double longitude { get; set; }
        public Double latitude { get; set; }
       // public ICollection<Technicien> technicien { get; set; }
        public ICollection<User> users { get; set; }



    }
}
