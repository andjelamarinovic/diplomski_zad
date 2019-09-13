using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public partial class Test
    {
        public int TestId { get; set; }
        [Display(Name = "Vrsta testiranja: ")]
        public int VrstaTestaId { get; set; }
        public int TestiranjeId { get; set; }
        public int NormaId { get; set; }
        [Display(Name = "Rezultat testiranja: ")]
        public decimal? TestRezultat { get; set; }
        public decimal? Ocjena { get; set; }

       
        public Testiranje Testiranje { get; set; }
        public VrstaTesta VrstaTesta { get; set; }
        public Norma Norma { get; set; }
    }
}
