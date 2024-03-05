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
        private int _CurrentDie; // Variable called _CurrentDie
        public int CurrentDie // Getter and setter methods for _CurrentDie
        {
            get { return _CurrentDie }
            private set { _CurrentDie = value }
        }

        //Method
        public Die() // Constructor
        {
            CurrentDie = 0;
        }
        public int rolls() // Rolls method
        {
            random random = new random(); // Created a instance of the random class
            CurrentDie = random.Next(1,7); // Generates a random number between 1 and 6 (inclusively)
            return _CurrentDie
        }

    }
}
