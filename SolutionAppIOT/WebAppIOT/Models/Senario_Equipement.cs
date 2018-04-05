using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppIOT.Models
{
    public class Senario_Equipement

    {
        public int ID { get; set; }
        public int value { get; set; }
        public int SenarioID { get; set; }
        public virtual Senario Senario { get; set; }
        public int EquipementID { get; set; }
        public virtual Equipement Equipement { get; set; }
    }
}
