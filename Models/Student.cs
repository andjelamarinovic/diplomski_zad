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
        public DateTime? StudentDatum { get; set; }
        [Display(Name = "Mjesto rođenja: ")]
        public string StudentMjesto { get; set; }
        [Display(Name = "Datum rođenja majke: ")]
        public DateTime? GodinaMajka { get; set; }
        [Display(Name = "Datum rođenja oca: ")]
        public DateTime? GodinaOtac { get; set; }
        [Display(Name = "Bavljenje sportom majke: ")]
        public string SportMajka { get; set; }
        [Display(Name = "Bavljenje sportom oca: ")]
        public string SportOtac { get; set; }
        [Display(Name = "Kojim se sportom najviše bavila majka: ")]
        public string KojiSportMajka { get; set; }
        [Display(Name = "Kojim se sportom najviše bavio otac: ")]
        public string KojiSportOtac { get; set; }
        [Display(Name = "Bavljenje sportom ispitanika: ")]
        public bool? SportStudent { get; set; }
        [Display(Name = "Kojim se sportom bavio ispitanik: ")]
        public string KojiSportStudent { get; set; }
        [Display(Name = "Koliko dugo se bavio sportom:")]
        public int? Trajanje { get; set; }
        [Display(Name = "Jeli se ispitanik bavio istovremeno s više sportova: ")]
        public bool? Istovremeno { get; set; }

        public Spol Spol { get; set; }
        public ICollection<Testiranje> Testiranje { get; set; }
    }
}
