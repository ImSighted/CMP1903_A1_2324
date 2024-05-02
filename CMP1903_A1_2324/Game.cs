using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */
        private Die _die1 = new Die(); // Creates 5 die objects
        private Die _die2 = new Die();
        private Die _die3 = new Die();
        private Die _die4 = new Die();
        private Die _die5 = new Die();


        public void Choice()
        {
            Console.WriteLine("Would You Like To Reroll All Or Reroll Remaining Die (1 or 2)");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                ThreeOrMoreMethod();

            }
            if (choice == "2")
            {
                ThreeOrMoreMethod();
            }
            
        }

        //Methods
        public int RollTwoDie()
        {
            bool round = true;
            int dieRoll1 = _die1.Roll(); // rolls all 3 die objects
            int dieRoll2 = _die2.Roll();
            if (dieRoll1 == 7)
            {
                round = false;
            }
            if (dieRoll2 == 7)
            {
                round = false;
            }
            int dieTotal = dieRoll1 + dieRoll2; // totals die rolls
            if (dieRoll1 == dieRoll2)
            {
                dieTotal = dieTotal * 2;
               
            }
            Console.WriteLine(dieTotal);
            return dieTotal; // returns dieTotal

        }

        public int ThreeOrMoreMethod()
        {

            int dieTotal = 0; // initialises variables needed
            bool turn = true;
            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;






            int dieRoll1 = _die1.Roll(); // rolls 5 die
            int dieRoll2 = _die2.Roll();
            int dieRoll3 = _die3.Roll();
            int dieRoll4 = _die4.Roll();
            int dieRoll5 = _die5.Roll();
            int[] rolls = { dieRoll1, dieRoll2, dieRoll3, dieRoll4, dieRoll5 }; // array of rolls
            for (int i = 0; i < rolls.Length; i++) // loops array to check what the die rolled
            {
                if (i == 1)
                {
                    one += 1;
                }
                if (i == 2)
                {
                    two += 1;
                }
                if (i == 3)
                {
                    three += 1;
                }
                if (i == 4)
                {
                    four += 1;
                }
                if (i == 5)
                {
                    five += 1;
                }
                if (i == 6)
                {
                    six += 1;
                }
            }
            int[] numbers = { one, two, three, four, five, six }; // array of what numbers were rolled
            foreach (int number in numbers)
            {
                if (number < 3)
                    turn = false; // either two of a kind or no matches
                Choice();
            }
            foreach (int number in numbers)
            {
                if (number >= 3) // no reroll aloud if 3 of a kind or more are rolled
                    turn = true;
            }

            for (int i = 0; i < numbers.Length; i++) // loops array to set all that are not 2 to 0 to allow for die reroll
            {
                if (numbers[i] != 2)
                {
                    numbers[i] = 0; // sets the number to 0 
                }

            } 
           




            foreach (int number in numbers) // loops array to check for any potential score in either 3,4 or 5 of a kind
            {
                if (number == 3)
                {
                    dieTotal += 3;
                    
                }
                if (number == 4)
                {
                    dieTotal += 6;
                }

                if (number == 5)
                {
                    dieTotal += 12;
                }
            }
            





            dieRoll1 = _die1.Roll(); // rolls 3 die again 
            dieRoll2 = _die2.Roll();
            dieRoll3 = _die3.Roll();
            int[] rolls2 = { dieRoll1, dieRoll2, dieRoll3 }; // array of rolls
            for (int i = 0; i < rolls2.Length; i++)
            {
                if (i == 1) ;
                {
                    one += 1;
                }
                if (i == 2) ;
                {
                    two += 1;
                }
                if (i == 3) ;
                {
                    three += 1;
                }
                if (i == 4) ;
                {
                    four += 1;
                }
                if (i == 5) ;
                {
                    five += 1;
                }
                if (i == 6) ;
                {
                    six += 1;
                }
            }

            foreach (int number in numbers)
            {
                if (number == 3)
                {
                    dieTotal += 3;
                }

            }
            foreach (int number in numbers)
            {
                if (number == 4)
                {
                    dieTotal += 6;
                }

            }
            foreach (int number in numbers)
            {
                if (number == 5)
                {
                    dieTotal += 12;
                }

            }




            return dieTotal; // returns dieTotal

        }




        public class SevensOut
        {
            public void Sevens()
            { 
                Game game = new Game();
            
                game.RollTwoDie(); // calls method
            }



        }

        public class ThreeOrMore
        {
            public void Three()
            { 
                Game game = new Game(); // creates game object
            
                game.ThreeOrMoreMethod(); // calls method
            }


        }






    }
}
