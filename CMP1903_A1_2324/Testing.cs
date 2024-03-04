using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; // added to allow for use of Debug.Assert
namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        public void Check_Dice_Number()
        {
            Die die = new Die(); // created die object
            Game game = new Game(); // created game object
            int roll = die.Roll(); // called die method 
            int die_total = game.Add_Die_Rolls(); // called game method
            Debug.Assert(roll < 7 && roll > 0, "Roll Outside Of Desired Range."); // checks to see roll is in range 1-6
            Debug.Assert(die_total < 19 && die_total > 2, "Dice Total Out Of Desired Range"); // checks dice total is in range 3-18
            Debug.Assert(roll is int, "Roll Is Of Undesired Type"); // checks roll is an integer
            Debug.Assert(die_total is int, "Dice Total Is Of Undesired Type"); // checks die total is an integer



        }

    }
}