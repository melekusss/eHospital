using Prescriptions.Domain.PrescriptionsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prescriptions.Tests
{
    class FakePrescriptionsRepository
    {
        public static Drug OneDrug { get; } = new Drug(3, "Ketoprofen");

        public static IList<Drug> ThreeDrugs { get; } = new List<Drug>()
        {
            new Drug (3, "Apap"),
            new Drug(4, "Paramantam"),
            new Drug(5, "Ozonozol")
        };


    }
}
