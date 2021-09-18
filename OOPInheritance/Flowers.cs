using System;

namespace OOPInheritance
{
    public class Flower:Living
    {
        public void Photosynthesis()
        {
            Console.WriteLine("Flower can photosynthesize");
        }
    }

    public class SeedyFlower:Flower
    {
        public void ReproductionBySeed()
        {
            Console.WriteLine("Seedy flower can reproduce by seed");
        }
    }
    
    public class SeedlessFlowers:Flower
    {
        public void ReproductionBySpore()
        {
            Console.WriteLine("Seedless flower can reproduce by spore");
        }
    }
}