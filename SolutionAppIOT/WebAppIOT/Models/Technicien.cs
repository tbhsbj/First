using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace WebAppIOT.Models
{
    public class Technicien
    {
   
        public int technicienID { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string cin { get; set; }
        public ICollection<System> system { get; set; }


    }
}
