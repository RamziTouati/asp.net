using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Protection_civile.Models
{
    public class Demande
    {
        public int Id { get; set; }

        [Display (Name = "الاسم")]
        public string nom { get; set; }
        [Display(Name = "اللقب")]
        public string prenom { get; set; }
        [Display(Name = "رقم الهاتف")]
        public int tel { get; set; }
        [Display(Name = "رقم ب.ت.و ")]
        public string numcin { get; set; }
        [Display(Name = "اسم المؤسسة")]
        public string nomentreprise { get; set; }
        [Display(Name = "العنوان")]
        public string adresse { get; set; }
        [Display(Name = "النشاط")]
        public string activite { get; set; }
        [Display(Name = "النوع")]

        public string type { get; set; }
        [Display(Name = "الصنف")]
        public string categorie { get; set; }
        [Display(Name = "التاريخ")]
        public DateTime Date { get; set; }
        [Display(Name = "رقم المطلب")]
        public string numdemande { get; set; }
        [Display(Name = "رقم الوصل")]
        public string numrecu { get; set; }
        public virtual ICollection<RapportInitial> RapportInitials { get; set; }
        public virtual RapportFinal RapportFinal { get; set; } 
        public virtual Attestation Attestation { get; set; }
        public virtual Paiement Paiment { get; set; }




    }
}
