﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protection_civile.Models
{
    public class RapportInitial
    {
        public int Id { get; set; }

        public DateTime DateN { get; set; }
        public string description { get; set; }
        public int DemandeId { get; set; }
        public virtual Demande demande { get; set; }

    }
}
