using System;
using System.Collections.Generic;

namespace SportApp.Models
{
    public partial class Testiranje
    {
        public Testiranje()
        {
            OcjeneSporta = new HashSet<OcjeneSporta>();
            Test = new HashSet<Test>();
        }

        public int TestiranjeId { get; set; }
        public int StudentId { get; set; }
        public int RazredId { get; set; }
        public DateTime? DatumTest { get; set; }

        public Razred Razred { get; set; }
        public Student Student { get; set; }
        public ICollection<OcjeneSporta> OcjeneSporta { get; set; }
        public ICollection<Test> Test { get; set; }
    }
}
