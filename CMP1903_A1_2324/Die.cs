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
        private int _CurrentDie;
        public int CurrentDie
        {
            get { return _CurrentDie }
            private set { _CurrentDie = value }
        }

        //Method
        public Die()
        {
            CurrentDie = 0;
        }
        public int rolls()
        {
            CurrentDie = Next(1,7);
            return _CurrentDie
        }

    }
}
