///* Programmer: Benjamin Moody
///* Date: 9/19/21
///* Comments: This program will convert kilometers to miles


using System;

namespace Tech_Assignment_3___KM_to_Miles_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a numeric value for the increment value for kilometers thats bewteen 10 and 25");
            // This asks the user to input a value of the increment value for kilometers
            try
            {
                string input = Console.ReadLine();
                //This stores the user input temporarily

                float KMS = float.Parse(input);
                //This stores kms a a floating variable

                Console.WriteLine("Your Increament Value is" + " "+ KMS);
                //This tells the user their specific Increament value

                //This determines if the increament value is between 10 and 25 and decides weather to proceed
                if (KMS >= 10 && (KMS <= 25))
                {
                    Console.WriteLine("Executing a while loop");
                    Console.WriteLine("This loop will iterate by increments of" + " " + KMS.ToString() + " " + "Untill 200 is reached");

                    //This creates a loop that starts at 0 and increaments by the stored value KMS and ends when I is equal to 0
                    for (float i = 0; i <= 200; i += KMS)
                    {
                        Console.WriteLine("Kilometers");
                        //Creates the kilometers heading
                        Console.WriteLine(i);
                        //Writes the distance in kilometers
                        Console.WriteLine("Miles");
                        //Writes a kilometers in Miles heading
                        Console.WriteLine(i * .621371);
                        //Converts kilometers into miles

                    }
                }
                //Else loop that will execute if the value is not between 10 and 25
                else
                {
                    Console.WriteLine("Enter a value beteen 10 and 25");
                }
            }
            //Catch block to account for bad data inputs
            catch
            {
                Console.WriteLine("Please enter a numeric value");
                Console.WriteLine("Please do not enter non numeric values");
                Console.WriteLine("Press any key to close the debug prompt");
            }//End of the catch
            }
        }
    }

