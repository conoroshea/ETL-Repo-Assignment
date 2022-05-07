using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private readonly Queue<Animal> _animals;
        public event EventHandler FarmEmptied;
        
        public EmydexFarmSystem()
        {
           _animals = new Queue<Animal>();
        }

        //TEST 1
        public void Enter(Animal animal) 
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities
            Console.WriteLine($"{animal.Name} has entered the farm");
            // add animal to the queue
            _animals.Enqueue(animal);
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            if (_animals.Any())
            {
                foreach (var animal in _animals)
                {
                    animal.Talk();
                }
            }
            else
            {
                Console.WriteLine("There are no animals in the farm");
            }

        }

        //TEST 3
        public void MilkAnimals()
        {
            // Get only the milkable animals
            foreach (var animal in _animals.Where(a => a is IMilkableAnimal).ToList())
            {
                //IMilkableAnimal milkableAnimal = animal as IMilkableAnimal;
                //milkableAnimal.ProduceMilk();
                Console.WriteLine($"{animal.Name} was milked!");
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (_animals.Any())
            {
                Animal animal = _animals.Dequeue();
                Console.WriteLine($"{animal.Name} has left the farm");
            }

            OnFarmEmptied();
        }

        protected virtual void OnFarmEmptied()
        {
            EventHandler handler = FarmEmptied;
            handler?.Invoke(this, EventArgs.Empty);
        }
    }
}