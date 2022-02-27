using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Protection_civile.Models
{
    public class RapportFinal
    {
        public int Id { get; set; }
        [Display(Name = "عددالتقرير النهائي")]
        public int numrf { get; set; }
        [Display(Name = "التاريخ")]
        public DateTime DateN { get; set; }
        public int DemandeId { get; set; }
        public virtual Demande demande { get; set; }
    }
}
