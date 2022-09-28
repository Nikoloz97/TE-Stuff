
namespace Lecture.Farming
{
    class Pig : FarmAnimal, ISellable
    {
        public decimal Price { get; }

        public Pig() : base("Pig", "oink")
        {
            Price = 60;
        }
    }
}
