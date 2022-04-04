namespace Visits.Domain.VisitAggregate
{
    using System.Linq;
    using System.Threading.Tasks;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Visits.Domain.SeedWork;

    public class Patient : Entity
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Patient(int id, string Name, string Surname) : base(id)
        {

            
           this.Name = Name;
           this.Surname = Surname;

        }

    }
}
