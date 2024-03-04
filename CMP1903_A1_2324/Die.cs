﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        public int die_num { get; set; } // establishes get and set for die_num
        static Random rnd = new Random(); // makes a new random object for the class, outside 'Roll()' method to allow for different random per roll
        //Method
        public int Roll()
        {
            // creates random
            int die_num = rnd.Next(1, 7); // generates random number between 1-6
            return die_num; // returns random the random number between 1-6

        }

    }
}
