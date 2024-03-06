using System;
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
        private int _CurrentDie; // Creates a new properties

        //Method
        public Die() // Constructor
        {
            _CurrentDie = 0;
        }
        public int roll()
        {
            Random rnd = new Random(); // Creates a new instace of the Random method
            _CurrentDie = rnd.Next(1, 7); // Randomises a number between 1 and 7 (exclusively ie 1-6)
            return _CurrentDie;
        }

    }
}
