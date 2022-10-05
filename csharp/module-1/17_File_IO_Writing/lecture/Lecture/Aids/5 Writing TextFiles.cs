using System;
using System.IO;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "output.txt";
            string fullPath = Path.Combine(directory, fileName);

            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    sw.WriteLine("This is the start of my first file!");

                    sw.Write("Hello ");
                    sw.Write("World ");

                    sw.WriteLine("Tech Elevator!");
                }

            }
            catch (IOException ex)
            {

                Console.WriteLine("Something went wrong writing output.txt"); 
            }


            // After the using statement ends, file has now been written
            // and closed for further writing
        }
    }
}
