using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        public event EventHandler AnimalsReleased;
        public List<Animal> animals { get; set; } = new List<Animal>();
        //TEST 1
        public void Enter(object animal)
        {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities            
            animals.Add(animal as Animal);
            Console.WriteLine($"{animal.GetType().Name} has entered the farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach (var animal in animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (var animal in animals)
            {
                IMilkableAnimal milkableAnimal = animal as IMilkableAnimal;
                if (milkableAnimal != null)
                {
                    milkableAnimal.ProduceMilk();
                }
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} has left the farm");
            }
            animals.Clear();
            OnReleaseAllAnimals(EventArgs.Empty);
        }

        protected virtual void OnReleaseAllAnimals(EventArgs e)
        {
            AnimalsReleased?.Invoke(this, e);
        }

    }
}