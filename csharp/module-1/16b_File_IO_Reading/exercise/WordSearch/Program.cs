using System;
using System.Collections.Generic;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path

            Console.Write("Enter the file path: ");
            string fullPath = Console.ReadLine();


            //2. Ask the user for the search string

            Console.Write("Enter the word you'd like to search: ");
            string theQuery = Console.ReadLine();
            Console.WriteLine("Do you want to be case-sensitive? Y/N");
            string choice = Console.ReadLine();



            //3. Open the file



            //4. Loop through each line in the file


            if (choice.ToUpper() == "N")
            {

                try
                {
                    int counter = 1;
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string lineUp = line.ToUpper();
                            string queryUpper = theQuery.ToUpper();

                            if (lineUp.Contains(queryUpper))
                            {
                                Console.WriteLine(counter + ") " + line);
                            }
                     
                            counter++;
                        }
                    }
                }
                
          
            catch (IOException ex)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(ex.Message);
            }
            }
            else if (choice.ToUpper() == "Y")
            {
                try
                {
                    int counter = 1;
                    using (StreamReader sr = new StreamReader(fullPath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (line.Contains(theQuery))
                            {
                                Console.WriteLine(counter + ") " + line);

                            }

                            counter++;


                        }

                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(ex.Message);
                }

                
            }
            }

         
            //5. If the line contains the search string, print it out along with its line number
        }
    }

