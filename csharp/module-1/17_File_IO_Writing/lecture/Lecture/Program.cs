using System;
using Lecture.Aids;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {

            WritingTextFiles.WritingAFile();
            BinaryImageManipulator.ReadFileIn();
            Console.Write("Press enter to finish");
            Console.ReadLine();

            PerformanceDemo.SlowPerformance();
            PerformanceDemo.FastPerformance();
        }
    }
}
