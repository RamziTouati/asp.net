using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Protection_civile.Models
{
    public class Citoyen
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nom Obligatoire")]
        [StringLength(30, MinimumLength = 3)]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Prénom Obligatoire")]
        [StringLength(30, MinimumLength = 3)]
        public string Prenom { get; set; }
        [Display(Name = "Date De Naissance")]
        public DateTime DateNaissance {get; set; }
        
    }
}
