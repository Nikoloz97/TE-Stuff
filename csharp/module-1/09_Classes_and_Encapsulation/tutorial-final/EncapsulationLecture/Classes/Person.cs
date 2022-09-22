using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture.Classes
{
    public class Person
    {
        // get set = makes something a property of the class
        // if no get set = called a field ("behind the scenes") - avoid this (bad practice) 
        public string Name { get; set; }
        // get {} = using operations to determine the property
        // Below = derived property (uses birthyear property as well)
        public int Age {
            get

            {
                int currentYear = DateTime.Now.Year;
                return currentYear - birthYear;
            }
                }
        private int birthYear { get; set; }
        public double Height { get; set; }

        private string SSN { get; set; }

        // Below = "Constructor". Syntax = public <Class Name>()
        public Person(int yearOfBirth)
        {
            birthYear = yearOfBirth;
        }
    }
}
