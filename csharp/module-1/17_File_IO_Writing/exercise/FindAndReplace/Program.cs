using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{
            Console.WriteLine("What is the search word?");
            string searchWord = Console.ReadLine();

            Console.WriteLine("What is the replacement word?");
            string replaceWord = Console.ReadLine(); 
            
            Console.WriteLine("What is the source file path?");
            string sourceFilePath = Console.ReadLine(); 
            
            Console.WriteLine("What is the destination file path?");
            string destFilePath = Console.ReadLine();

            if (File.Exists(sourceFilePath))
            {
                try
                {

                }
                catch (IOException ex)
                {
                    Console.WriteLine("File path does not exist");
                    Console.WriteLine(ex.Message);
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(sourceFilePath))
                {
                    using (StreamWriter sw = new StreamWriter(destFilePath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string fixedLine = line.Replace(searchWord, replaceWord);

                            sw.WriteLine(fixedLine);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Invalid destination file");
                Console.WriteLine(ex.Message);
            }




        }
    }
}
