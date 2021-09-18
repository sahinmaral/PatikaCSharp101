using System;

namespace OOPInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird sequel = new Bird();
            sequel.Fly();
            sequel.Feed();

            SeedyFlower seedyFlower = new SeedyFlower();
            seedyFlower.ReproductionBySeed();
            seedyFlower.Photosynthesis();
            
            
        }
    }
}