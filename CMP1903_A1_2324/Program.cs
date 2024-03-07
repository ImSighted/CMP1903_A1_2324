using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        public static void Main(string[] args)
        {


            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Game game = new Game(); // creates game oject
            Testing testing = new Testing(); // creates test object

            
            
            Console.WriteLine("Welcome To The Dice Roll Application"); // welcomes user
            int dieTotal = game.AddDieRolls();// calls method
            testing.CheckDieNumber(); // calls testing method
            Console.WriteLine($"The Total Of The 3 Dice Rolls Are {dieTotal}"); // prints dieTotal
            Console.WriteLine("Would You Like To Continue Rolling? (y or n)");
            string answer = Console.ReadLine(); // creates answer variable

            if (answer == "y") // loops program if y is presssed
            {
               
                Main(args); // calls method 
            }
            
            







        }
    }
}

