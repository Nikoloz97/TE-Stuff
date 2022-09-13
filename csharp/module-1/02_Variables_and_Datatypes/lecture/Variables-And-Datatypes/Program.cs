using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIABLES & DATA TYPES */

            /*
            

		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */

            int numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */

            double half = 0.5;
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */

            string name = "TechElevator";
            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */


            byte seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */


            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */

            var pi = 3.1416;
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */

            var myName = "Nick";
            Console.WriteLine(myName);


            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */

            var mouseButtons = 5;
            Console.WriteLine(mouseButtons);


            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */

            var batteryLeft = 100;
            Console.WriteLine(batteryLeft);

            /* EXPRESSIONS */

            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */

            var difference = 121 - 27;
            Console.WriteLine(difference);


            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */

            decimal sum = (decimal)12.3 + (decimal)32.1;
            Console.WriteLine(sum);



            /*
            12. Create a string that holds your full name.
            */

            var fullName = "Nick Gotsy";
            Console.WriteLine(fullName);

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */

            var newString = "Hello, " + fullName;
            Console.WriteLine(newString);


            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */

            fullName = "Nick Gotsy Esquire";
            Console.WriteLine(fullName);

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */

            fullName += " PhD";


            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */

            var saw = "Saw";
            saw += 2;
            Console.WriteLine(saw);


            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */


            saw += 0;
            Console.WriteLine(saw);


            /*
            18. What is 4.4 divided by 2.2?
            */

            var result = 4.4 / 2.2;
            Console.WriteLine(result);


            /*
            19. What is 5.4 divided by 2?
            */

            var divide2 = 5.4 / 2;
            Console.WriteLine(divide2);


            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */


            double dividebytwo = 5 / 2;
            Console.WriteLine(dividebytwo);


            /*
            21. What is 5.0 divided by 2?
            */

            dividebytwo = (float)5 / 2;
            Console.WriteLine(dividebytwo);



            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */

            decimal bankBalance = 1234.56M;
            Console.WriteLine(bankBalance);

            Console.WriteLine("Double balance: " + (bankBalance * 2));

            /*
            23. If I divide 5 by 2, what's my remainder?
            */

            var remainder = 5 % 2;
            Console.WriteLine(remainder);

            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together.
                What is the result?
            */

            var firstVal = 3;
            var secondVal = 1_000_000;
            Console.WriteLine(firstVal * secondVal);


            /*
            25. Create a variable that holds a boolean called isDoneWithExercises and
            set it to false.
            */

            var isDonewithExercises = false;


            /*
            26. Now set isDoneWithExercise to true.
            */

            isDonewithExercises = true;

            Console.WriteLine("Are we done with exercises? " + isDonewithExercises);


            Console.ReadLine();
        }
    }
}
