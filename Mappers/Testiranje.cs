using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SportApp.Models.ViewModel;

namespace SportApp.Models
{
    public partial class Testiranje
    {
        public static implicit operator Testiranje(TestiranjeViewModel vm)
        {
            return new Testiranje
            {
                StudentId = vm.StudentId,
                RazredId = vm.RazredId,
                DatumTest = vm.DatumTesta,
                Test = (ICollection<Test>)vm.TestsRezultati
            };
        }
    }
}
