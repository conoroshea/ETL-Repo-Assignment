using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow  : Animal, IMilkableAnimal, IWalkableAnimal
    {
        public Cow(int noOfLegs): base(noOfLegs){}

        public override void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

        public override void Run()
        {
            Console.WriteLine("Cow is running");
        }
    }
}