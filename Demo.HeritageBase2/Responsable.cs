using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.HeritageBase2
{
    class Responsable : Employe
    {
        public List<Employe> EmployesSurveilles { get; set; }

        public override void SePresenter()
        {
            base.SePresenter();
            Console.WriteLine($"Je supervise {EmployesSurveilles.Count} employé(s).");
        }
    }
}
