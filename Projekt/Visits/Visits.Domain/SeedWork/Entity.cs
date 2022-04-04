namespace Visits.Domain.SeedWork
{

    using System;
using System.Collections.Generic;
using System.Text;


    public abstract class Entity
    {
        public int Id { get; protected set; }

        public Entity(int id)
        {
            Id = id;
        }
    }
}

