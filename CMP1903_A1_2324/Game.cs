using System;
using System.Collections.Generic;
using System.Linq;
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
        private int _Total = 0; // Creates _Total local variable
        private int _d1 = 0; // Creates _d1 local variable
        private int _d2 = 0; // Creates _d2 local variable
        private int _d3 = 0; // Creates _d3 local variable
        public int Total // Getter and setter for _Total
        {
            get { return _Total}
            set { _Total = value}
        }
        public int d1 // Getter and setter for _d1
        {
            get { return _d1}
            set { _d1 = value}
        }
        public int d2 // Getter and setter for _d2
        {
            get { return _d2}
            set { _d2 = value}
        }
        public int d3 // Getter and setter for _d3
        {
            get { return _d3}
            set { _d3 = value}
        }
        //Methods
        public Game() // Constructor
        {
            Total = 0;
        }
        public int RunGame() // RunGame method
        {
            d1 = int Game.CreateDice(); // Calls the CreateDice method for all three dice
            d2 = int Game.CreateDice();
            d3 = int Game.CreateDice();
            return Total
        }

        private int CreateDice() // CreateDice method
        {
            Die d = new Die(); // Creates a new dice object
            Total += d.rolls(); // Adds the dice value to the total
            return d
        }

        public int Test() // Test method
        {
            return d1, d2, d3, Total // Returns all the values of the Game class
        }
    }
}
