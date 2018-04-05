using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppIOT.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppIOT.Models
{
    public class Technicien_System
    {
        public int ID { get; set; }
        public DateTime ReglageDate { get; set; }
        public string ReglageType { get; set; }

        public int SystemID { get; set; }
        public virtual System System { get; set; }
        public int TechnicienID { get; set; }
        public virtual Technicien Technicien { get; set; }

        

    }
}
