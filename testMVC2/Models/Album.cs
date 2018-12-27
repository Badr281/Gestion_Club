using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testMVC2.Models
{
    public class Album
    {
        [Required(ErrorMessage="Obligatoire.")]
        [Display(Name="Le titre")]
        public string titre { get; set; }

        [Required(ErrorMessage = "Obligatoire.")]
        public int prix { get; set; }

        [Required(ErrorMessage = "Obligatoire.")]
        public string categorie { get; set; }
    }
}