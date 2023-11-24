using System;

namespace FarmSystem.Test1
{
    public class Sheep : Animal
    {
        public Sheep()
        {
            NoOfLegs = 4;
        }

        public override void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }
        
        public override void Run()
        {
            Console.WriteLine("Sheep is running");
        }

        public override void Walk()
        {
            Console.WriteLine("Sheep is walking");
        }
    }

}