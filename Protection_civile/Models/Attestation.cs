using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Protection_civile.Models
{
    public class Attestation
    {
        public int Id { get; set; }
        [Display(Name = "عدد شهادة الوقاية")]
        public int numatt { get; set; }
        [Display(Name = "التاريخ")]
        public DateTime DateN { get; set; }
        public int DemandeId { get; set; }
        public virtual Demande demande { get; set; }
      
    }
}
