using System;

namespace OOPInheritance
{
    public class Animal:Living
    {
        public void Adaptation()
        {
            Console.WriteLine("Animals can adaptate");
        }
    }

    public class Reptile : Animal
    {
        public void MovingByCrawling()
        {
            Console.WriteLine("Reptiles can move by crawling");
        }
    }

    public class Bird:Animal
    {
        public void Fly()
        {
            Console.WriteLine("Birds can fly");
        }
    }
}