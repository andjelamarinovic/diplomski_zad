using System;
using System.Collections.Generic;

namespace SportApp.Models
{
    public partial class VrstaTesta
    {
        public VrstaTesta()
        {
            Norma = new HashSet<Norma>();
            Test = new HashSet<Test>();
        }

        public int VrstaTestaId { get; set; }
        public string NazivTesta { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<Norma> Norma { get; set; }
        public ICollection<Test> Test { get; set; }
    }
}
