using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protection_civile.Models
{
    public class Demande
    {
        public int Id { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public int tel { get; set; }
        public string numcin { get; set; }
        public string nomentreprise { get; set; }
        public string adresse { get; set; }
        public string activite { get; set; }

        public string type { get; set; }
        public string categorie { get; set; }
        public DateTime Date { get; set; }
        public string numdemande { get; set; }
        public string numrecu { get; set; }
        public virtual ICollection<RapportInitial> RapportInitials { get; set; }
        public virtual RapportFinal RapportFinal { get; set; } 
        public virtual Attestation Attestation { get; set; }
        public virtual Paiement Paiment { get; set; }




    }
}
