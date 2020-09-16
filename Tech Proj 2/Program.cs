using System;
using System.Linq.Expressions;

namespace Tech_Proj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.Write("Enter an integer value between 1 and 25 to execute an iterative statement: ");

            try
            {
                // gather data from the user input
                string input = Console.ReadLine();
                // variable used to peform carious iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);

                if ((value_of_input > 0) && (value_of_input <= 12))
                {
                    Console.WriteLine("executing a for loop!");
                    Console.WriteLine("The for loop will iterate " + value_of_input.ToString() + "times. ");
                    //For loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("you have entered #. This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // pause and wait for user to press key
                    Console.ReadKey(true);
                }
                else if ((value_of_input > 13) && (value_of_input <= 25))
                {
                    Console.WriteLine("executing a while loop!");
                    Console.WriteLine("The while loop will iterate " + value_of_input.ToString() + "times. ");
                    //For loop
                    while (value_of_input > 0)
                    {
                        Console.WriteLine("The value of the iterative variable is: " + value_of_input.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    // pause and wait for user to press key
                    Console.ReadKey(true);
                }
                }
                catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again...");
                Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
            
                


                
            }
        }
    }
}
