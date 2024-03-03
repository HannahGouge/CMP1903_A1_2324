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
            Game g1 = new Game()
            d1, d2, d3, total = g1.Test();
            if (d1 + d2 + d3 == total)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Condole.WriteLine("Test Failed");
            }

            Die d4 = new Die()
            Die d5 = new Die()
            Die d6 = new Die()
            Die d7 = new Die()

        }
    }
}
