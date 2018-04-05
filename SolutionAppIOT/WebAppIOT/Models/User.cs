﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppIOT.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string login { get; set; }
        public string pwd { get; set; }
        public DateTime Lastlogin { get; set; }
        public int SystemID { get; set; }
        public virtual System System { get; set; }
        public virtual ICollection<Chambre> Chambres { get; set; }

    }
}
