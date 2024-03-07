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

        public void CheckDieNumber()
        {
            Die die = new Die(); // created die object
            Game game = new Game(); // created game object
            int roll = die.Roll(); // called die method 
            int dieTotal = game.AddDieRolls(); // called game method

            Debug.Assert(roll < 7 && roll > 0, $"The Roll {roll} Is Outside Of Desired Range 1-6."); // checks to see roll is in range 1-6
            Debug.Assert(dieTotal < 19 && dieTotal > 2, $"The Die Total {dieTotal} Is Out Of Desired Range 3-18"); // checks dice total is in range 3-18
            Debug.Assert(roll is int, "The Roll Type Is Not Of Desired Type Int"); // checks roll is an integer
            Debug.Assert(dieTotal is int, "The Die Total Is Not Of Desired Type Int"); // checks die total is an integer



        }

    }
}