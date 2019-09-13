using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportApp.Models
{
    public partial class Testiranje
    {
        [Key]
        public int TestiranjeId { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Razred")]
        public int RazredId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DatumTest { get; set; }

        public Razred Razred { get; set; }
        public Student Student { get; set; }
        public ICollection<OcjeneSporta> OcjeneSporta { get; set; }
        public ICollection<Test> Test { get; set; }
    }
}
