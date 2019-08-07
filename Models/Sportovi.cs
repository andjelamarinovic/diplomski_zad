using System;
using System.Collections.Generic;

namespace SportApp.Models
{
    public partial class Sportovi
    {
        public Sportovi()
        {
            OcjeneSporta = new HashSet<OcjeneSporta>();
        }

        public int SportId { get; set; }
        public string SportIme { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<OcjeneSporta> OcjeneSporta { get; set; }
    }
}
