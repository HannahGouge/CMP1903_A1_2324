using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        private int _Total; // Creates all needed properties
        private int _d1;
        private int _d2;
        private int _d3;

        //Methods
        public Game() // Constructor
        {
            _Total = 0;
            _d1 = 0;
            _d2 = 0;
            _d3 = 0;
        }
        public int RunGame() // Run Game method
        {
            _d1 = CreateDice(); // Calls the CreateDice method 3 times
            _d2 = CreateDice();
            _d3 = CreateDice();
            _Total = AddDice(_d1, _d2, _d3); // Calls the Adddice method
            return _Total;
        }

        private int CreateDice() // Creates a dice object and rolls it and returns the value
        {
            Die d = new Die();
            int dice = d.roll();
            return dice;
        }
        private int AddDice(int d1, int d2, int d3) // Adds the three dice together and returns the total
        {
            _Total = d1 + d2 + d3;
            return _Total;
        }
        public int Test(int d1, int d2, int d3) // Test method used to test both the dice class and the Game class
        {
            _Total = AddDice(d1, d2, d3); // Calls the Adddice method
            return _Total;
        }
    }
}
