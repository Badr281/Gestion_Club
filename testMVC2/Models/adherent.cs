//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testMVC2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class adherent
    {
        public adherent()
        {
            this.abonnements = new HashSet<abonnement>();
        }
    
        public int id { get; set; }
        [Required(ErrorMessage=("Obligatoire"))]
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string tel { get; set; }
    
        public virtual ICollection<abonnement> abonnements { get; set; }
    }
}