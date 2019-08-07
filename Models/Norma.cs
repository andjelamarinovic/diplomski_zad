using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Models
{
    public partial class Norma
    {
        public Norma()
        {
            Test = new HashSet<Test>();
        }

        public int NormaId { get; set; }
        [Display(Name = "Odaberite vrstu testiranja: ")]
        public int VrstaTestaId { get; set; }
        [Display(Name = "Odaberite spol ispitanika: ")]
        public int SpolId { get; set; }
        [Display(Name = "Odaberite razred ispitanika: ")]
        public int RazredId { get; set; }
        [Display(Name = "Rezultati testiranja - Ocjena: 1: ")]
        public decimal? Ocjena1 { get; set; }
        [Display(Name = "Rezultati testiranja - Ocjena: 2: ")]
        public decimal? Ocjena2 { get; set; }
        [Display(Name = "Rezultati testiranja - Ocjena: 3: ")]
        public decimal? Ocjena3 { get; set; }
        [Display(Name = "Rezultati testiranja - Ocjena: 4: ")]
        public decimal? Ocjena4 { get; set; }
        [Display(Name = "Rezultati testiranja - Ocjena: 5: ")]
        public decimal? Ocjena5 { get; set; }

        public Razred Razred { get; set; }
        public Spol Spol { get; set; }
        public VrstaTesta VrstaTesta { get; set; }
        public ICollection<Test> Test { get; set; }
    }
}
