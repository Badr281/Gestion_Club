using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testMVC2.Models
{
    public class adherent_paye
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string _sport { get; set; }
        public byte _payer { get; set; }
    }
}