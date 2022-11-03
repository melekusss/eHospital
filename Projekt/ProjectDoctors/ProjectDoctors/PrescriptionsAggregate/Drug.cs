namespace Prescriptions.Domain.PrescriptionsAggregate
{
    using Prescriptions.Domain.SeedWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Drug : Entity
    {
        public string DrugName { get; private set; }

        public Drug(int DrugId, string drugName) : base(DrugId)
        {
            DrugName = drugName;
        }
    }
}
