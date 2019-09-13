using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportApp.Models.ViewModel
{
    public class TestiranjeViewModel
    { 
        public int StudentId { get; set; }
        public int RazredId { get; set; }
        [Display(Name="Ime studenta")]
        public string StudentName { get; set; }
        [Display(Name="Datum testiranja")]
        public DateTime? DatumTesta { get; set; }
        public IEnumerable<TestRezultat> TestsRezultati {get; set;}
        public TestiranjeViewModel()
        {
            TestsRezultati = new List<TestRezultat>();
        }
    }

    public class TestRezultat
    {
        public int VrstaTestaId { get; set; }
        [Display(Name="Vrsta Testa")]
        public string NazivTesta { get; set; }
        public decimal? Rezultat { get; set; }
    }
}
