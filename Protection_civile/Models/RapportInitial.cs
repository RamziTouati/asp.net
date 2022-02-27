using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Protection_civile.Models
{
    public class RapportInitial
    {
        public int Id { get; set; }
        [Display(Name = "عدد التقرير الاولي")]
        public int numri { get; set; }
        [Display(Name = "تاريخ الزيارة")]
        public DateTime Datev { get; set; }
        [Display(Name = "تاريخ التقرير")]
        public DateTime DateN { get; set; }
        [Display(Name = "التوصيات الوقائية")]
        public string description { get; set; }
        public int DemandeId { get; set; }
 
        public virtual Demande demande { get; set; }

    }
    
}
