namespace Visits.Domain.VisitAggregate
{
    using System.Linq;
    using System.Threading.Tasks;
    using System;
using System.Collections.Generic;
using System.Text;
    using Visits.Domain.SeedWork;

    public class Doctor : Entity
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Doctor (int id, string Name, string Surname) : base(id)
        {
            this.Id = id;
           this.Name = Name;
            this.Surname = Surname;

        }

    }
}
