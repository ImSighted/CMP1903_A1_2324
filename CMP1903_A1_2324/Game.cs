using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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
        private Die _die1 = new Die(); // Creates 3 die objects
        private Die _die2 = new Die();
        private Die _die3 = new Die();




        //Methods
        public int AddDieRolls()
        {
            int dieRoll1 = _die1.Roll(); // rolls all 3 die objects
            int dieRoll2 = _die2.Roll();
            int dieRoll3 = _die3.Roll();
            int dieTotal = dieRoll1 + dieRoll2 + dieRoll3; // totals die rolls
            return dieTotal; // returns dieTotal
            
        }
    }
}
