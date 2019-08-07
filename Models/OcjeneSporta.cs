using System;
using System.Collections.Generic;

namespace SportApp.Models
{
    public partial class OcjeneSporta
    {
        public int OcjenaSportaId { get; set; }
        public int TestiranjeId { get; set; }
        public int SportId { get; set; }
        public int? Ocjena { get; set; }

        public Sportovi Sport { get; set; }
        public Testiranje Testiranje { get; set; }
    }
}
