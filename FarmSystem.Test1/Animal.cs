using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    /// <summary>
    /// A base class for an animal
    /// </summary>
    public abstract class Animal
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int NoOfLegs { get; set; }
        
        public Animal(int noOfLegs)
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = noOfLegs;
            // generate name from current class
            Name = GetType().Name;
        }

        public abstract void Talk();
        public abstract void Run();
    }
}
