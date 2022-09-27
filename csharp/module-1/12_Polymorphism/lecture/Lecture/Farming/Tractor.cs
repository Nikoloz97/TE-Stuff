
namespace Lecture.Farming
{
    class Tractor : ISingable
    {
        public string Sound { get; }
        public string Name { get; }
        public Tractor()
        {
            Name = "Tractor";
            Sound = "Vroom";
        }
    }
}
