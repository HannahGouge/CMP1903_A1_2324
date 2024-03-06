using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Testing()
        {
            Game g1 = new Game() // Creates an instance of the Game class
            d1, d2, d3, total = g1.Test(); // Calls the Test method from the Game class
            Debug.Assert(d1 + d2 + d3 = total, "Game Test Passed") // Checks wether total is calculated correctly

            Die d4 = new Die() // Creates 3 instances of the Die class
            Die d5 = new Die()
            Die d6 = new Die()
            Die d7 = new Die()

            Debug.Assert(1 <= d4.rolls <= 6, "Dice 1 Test Pass") // Checks to see if the die values are between 1 and 6 (inclusive)
            Debug.Assert(1 <= d5.rolls <= 6, "Dice 2 Test Pass")
            Debug.Assert(1 <= d6.rolls <= 6, "Dice 3 Test Pass")
        }
    }
}
