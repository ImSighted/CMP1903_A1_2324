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
        private Die die_1 = new Die(); // Creates 3 die objects
        private Die die_2 = new Die();
        private Die die_3 = new Die();




        //Methods
        public int Add_Die_Rolls()
        {
            int die_roll1 = die_1.Roll(); // rolls all 3 die objects
            int die_roll2 = die_2.Roll();
            int die_roll3 = die_3.Roll();

            int die_total = die_roll1 + die_roll2 + die_roll3; // totals die rolls
            return die_total; // returns die_total
        }
    }
}
