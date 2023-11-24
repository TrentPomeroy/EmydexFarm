using System;

namespace FarmSystem.Test1
{
    public abstract class Animal
    {
        public Animal()
        {
            Id  = Guid.NewGuid().ToString();
        }

        protected string Id { get; set; }

        protected int NoOfLegs { get; set; }

        public abstract void Talk();

        public abstract void Walk();

        public abstract void Run();
    }
}
