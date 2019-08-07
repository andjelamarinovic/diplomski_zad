using System;
using System.Collections.Generic;

namespace SportApp.Models
{
    public partial class Test
    {
        public int TestId { get; set; }
        public int VrstaTestaId { get; set; }
        public int NormaId { get; set; }
        public int TestiranjeId { get; set; }
        public decimal? TestRezultat { get; set; }
        public decimal? Ocjena { get; set; }

        public Norma Norma { get; set; }
        public Testiranje Testiranje { get; set; }
        public VrstaTesta VrstaTesta { get; set; }
    }
}
