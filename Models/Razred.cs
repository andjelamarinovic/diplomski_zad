using System;
using System.Collections.Generic;

namespace SportApp.Models
{
    public partial class Razred
    {
        public Razred()
        {
            Norma = new HashSet<Norma>();
            Testiranje = new HashSet<Testiranje>();
        }

        public int RazredId { get; set; }
        public int? BrojRazred { get; set; }
        public string Opis { get; set; }

        public ICollection<Norma> Norma { get; set; }
        public ICollection<Testiranje> Testiranje { get; set; }
    }
}
