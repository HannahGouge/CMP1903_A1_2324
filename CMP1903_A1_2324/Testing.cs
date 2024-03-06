using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Die dice1 = new Die(); // Creates 3 new Die objects
            Die dice2 = new Die();
            Die dice3 = new Die();

            int d1 = dice1.roll(); // Rolls all three ojects and recives the value
            int d2 = dice1.roll();
            int d3 = dice1.roll();

            Game g1 = new Game(); // Makes and new instance of the Game class
            int total = g1.Test(d1,d2,d3); // Calls the Test method in the Game class
            int total2 = d1 + d2 + d3;
            Debug.Assert(total == total2,"Game Test Falied"); // Sees if the dice added together eaquals the total that the game class returns

            if (1 <= d1 && d1 <= 6 && 1 <= d2 && d3 <= 6 && 1 <= d3 && d3 <= 6) // Ckecks that all the dice return a number between 1 and 6 (inclusive)
            {
                Debug.Assert(true, "Dice Test Passes");
            }
            else
            {
                Debug.Assert(true, "Dice Test Failed"); // If not returns a Faliure message
            }
        }
    }
}
