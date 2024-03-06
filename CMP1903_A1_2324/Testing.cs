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
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();

            int d1 = dice1.roll();
            int d2 = dice1.roll();
            int d3 = dice1.roll();

            Game g1 = new Game();
            int total = g1.Test(d1,d2,d3);
            
        }
    }
}
