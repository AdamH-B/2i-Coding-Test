// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

//  iterate in multiples of a until x, then in multiples of a+1 until 2x,then in multiples of a+2 until 3x.
//  e.g. multiples of 5 until 50, then 6 until 100, then 7 until 150. 

namespace Draft
{
class Program
    {
        static void Main(string[] args)
        {
            // initialise inputs as Ints 
            int aValue;
            int xValue;
            // store user input
            string userInput;
            // read user input
            Console.Write("Enter an integer value to serve as a - ");
            userInput = Console.ReadLine();
            // converts string input to integer type
            aValue = Convert.ToInt32(userInput);
            //same logic but for the x value
            Console.Write("Enter an integer value to serve as x - ");
            userInput = Console.ReadLine();
            // converts string input to integer type
            xValue = Convert.ToInt32(userInput);

            // until x, iterate through multiples of a  
            for (int counter = aValue; counter <= xValue; counter++)
            {
                if (counter % aValue == 0)
                {
                    // if multiple of a, print value
                    Console.WriteLine("The value of a is now " + counter);
                }
            }
            Console.WriteLine("The value of x is now " + xValue);

            // increase a by +1
            aValue = aValue + 1;

            Console.WriteLine("The value of a has changed to " + aValue);

            //store the original x value before it is changed
            int originalX = xValue;
            // x equals original x times 2
            xValue = xValue * 2;
   
            Console.WriteLine("The value of x has changed to " + xValue);

            // upon reaching x, exit loop and enter next one
            // and then until 2x is reached, iterate through multiples of a+1 
            for (int counter = aValue; counter <= xValue; counter++)
            {
                // if multiple of a+1, print value
                if (counter % aValue == 0) 
                {
                    
                    Console.WriteLine("The value of a is now " + counter);
                }

            }

            // increase a by +1
            aValue = aValue + 1;

            Console.WriteLine("The value of a has changed to " + aValue);

            // x equals original x times 3
            xValue = originalX * 3;
            // used to be xValue = originalX * 3;

            Console.WriteLine("The value of x has changed to " + xValue);

            // until 3x is reached, iterate through multiples of a +2
            for (int counter = aValue; counter <= xValue; counter++)
            {
                if (counter % aValue == 0)
                {
                    // if multiple of a+2, print value
                    Console.WriteLine("The value of a is now " + counter);
                }

            }
       
            // program is completed and all iterations for multiples of a up to x,
            // a+1 up to 2x, and a+2 up to 3x are printed.
            Console.WriteLine("The program has finished running.");
         
        }
    }

}

// At first I assumed from the prompt that the values for a and x were going to be given and won't change, but then I thought that means to run something different you would have to change the program.
// Therefore, I decided to handle user input as well. This means the code is easily usable for more than one specific set of values. It meant I had to refactor my code to use different variable names throughout.
// I did assume however that the program should only handle Integer values, no arrays of Ints etc.
// I assumed that you don't want a and x read from a file as this wasn't specified in the challenge prompt given.
// I assume you would like to see the values of outputs throughout the program to ensure my logic works.

// Visual code is a little funny I had to press ctrl f5 before my console window was showing up. 
// Please press ctrl f5 before / after running the first time if the output isn't showing in a console window.
// Alternatively, try Window > Reset Window Layout OR View > Output Window to toggle it on or off.