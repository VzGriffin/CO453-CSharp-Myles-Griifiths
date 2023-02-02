using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {

        public DistanceConverter()
        {

        }

        public void Run()
        {
            //step 1 Input to me
            Console.WriteLine("Please enter the number of Miles");
            string input = Console.ReadLine();
            int miles = Convert.ToInt32(input);
            Console.WriteLine("Miles entered is: " + miles);


            //step 2 - Converting Miles to feet
            const int MILES_TO_FEET = 5280;
            int feet = miles * MILES_TO_FEET;

            //step 3 Output Converted to feet

            Console.WriteLine(miles + " miles is " + feet + " feet ");
            


        }
    }
}
