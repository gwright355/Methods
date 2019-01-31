// Glenn Wright
// assignment: methods 
// Ism 4300

using System;

namespace Methods
{
    class Program
    {


        static void Main(string[] args)
        {

            try
            {
                //User must enter name
                Console.WriteLine("Please enter your name: ");

                // Used to read user input
                input(Console.ReadLine());

            }// end of try
            catch
            {
                //If user enters invalid data
                Console.WriteLine("Please enter valid data");

                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            }// end of catch

            

            
    }
        //Method for displaying user name.
          static void input(string name)
        {
            Console.WriteLine("Hello " + name);
            Console.ReadKey(true);
        }

    }
}
