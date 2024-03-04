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
            int die_total = game.Add_Die_Rolls(); // calls method
            Console.WriteLine($"The Total Of The 3 Dice Rolls Are {die_total}"); // prints die total
            testing.Check_Dice_Number(); // calls testing method
            Console.ReadLine(); // allows user to quit window by pressing enter








        }
    }
}
