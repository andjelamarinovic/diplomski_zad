using System;
using System.Collections.Generic;

namespace SportApp.Models
{
    public partial class Spol
    {
        public Spol()
        {
            Norma = new HashSet<Norma>();
            Student = new HashSet<Student>();
        }

        public int SpolId { get; set; }
        public string NazivSpola { get; set; }

        public ICollection<Norma> Norma { get; set; }
        public ICollection<Student> Student { get; set; }
    }
}
