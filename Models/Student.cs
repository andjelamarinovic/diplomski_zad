using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportApp.Models
{
    public partial class Student
    {
        public Student()
        {
            Testiranje = new HashSet<Testiranje>();
        }

        public int StudentId { get; set; }
        public int SpolId { get; set; }
        [Display(Name = "Ime ispitanika: ")]
        public string Ime { get; set; }
        [Display(Name = "Prezime ispitanika: ")]
        public string Prezime { get; set; }
        [Display(Name = "Šifra ispitanika: ")]
        public int? SifraStudent { get; set; }
        [Display(Name = "Datum rođenja: ")]
        [DataType(DataType.Date)]
        public DateTime? StudentDatum { get; set; }
        [Display(Name = "Mjesto rođenja: ")]
        public string StudentMjesto { get; set; }
        [Display(Name = "Datum rođenja majke: ")]
        [DataType(DataType.Date)]
        public DateTime? GodinaMajka { get; set; }
        [Display(Name = "Datum rođenja oca: ")]
        [DataType(DataType.Date)]
        public DateTime? GodinaOtac { get; set; }
        [Display(Name = "Bavljenje sportom majke [Da/Ne] :")]
        public string SportMajka { get; set; }
        [Display(Name = "Bavljenje sportom oca [Da/Ne] :")]
        public string SportOtac { get; set; }
        [Display(Name = "Kojim se sportom najviše bavila majka: ")]
        public string KojiSportMajka { get; set; }
        [Display(Name = "Kojim se sportom najviše bavio otac: ")]
        public string KojiSportOtac { get; set; }
        [Display(Name = "Bavljenje sportom ispitanika [Da/Ne] :")]
        public string SportStudent { get; set; }
        [Display(Name = "Kojim se sportom bavio ispitanik: ")]
        public string KojiSportStudent { get; set; }
        [Display(Name = "Koliko godina se bavio sportom:")]
        public int? Trajanje { get; set; }
        [Display(Name = "Jeli se ispitanik bavio istovremeno s više sportova [Da/Ne] :")]
        public string Istovremeno { get; set; }
 

        public Spol Spol { get; set; }
        public ICollection<Testiranje> Testiranje { get; set; }
    }
}
