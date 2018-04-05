using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppIOT.Models
{
    public class Equipement
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String Gpio  { get; set; }
        public int value { get; set; }
        public virtual ICollection<Senario_Equipement> Senario_Equipements { get; set; }
        public int ChambreID { get; set; }
        public virtual Chambre Chambre { get; set; }
        
    }
}
