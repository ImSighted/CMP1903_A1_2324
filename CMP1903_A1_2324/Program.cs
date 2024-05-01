using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
          
            
            
            
            Console.WriteLine("Welcome To The Dice Game Application"); // welcomes user
            Console.WriteLine("Would You Like To Play 'Sevens Out' Or 'Three Or More' (1 or 2)");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                int SevensOutPlayer1 = game.RollTwoDie();
                int SevensOutPlayer2 = game.RollTwoDie();
                if (SevensOutPlayer1 > SevensOutPlayer2)
                {
                    Console.WriteLine("Player1 Wins");
                }
                if (SevensOutPlayer1 < SevensOutPlayer2)
                {
                    Console.WriteLine("Player2 Wins");
                }
                if (SevensOutPlayer1 == SevensOutPlayer2)
                {
                    Console.WriteLine("Draw");
                }

                
            }

            if (choice == "2")
            {
               int ThreeOrMore = game.ThreeOrMoreMethod();
            }


            testing.CheckDieNumber(); // calls testing method
            Console.WriteLine("Would You Like To Continue Playing (y or n)");
            string answer = Console.ReadLine(); // creates answer variable
                
            if (answer == "y") // loops program if y is presssed
            {
               
                Main(args); // calls method 
            }
            
            







        }
    }
}

