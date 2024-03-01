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
        private int _Total = 0;
        private int _d1 = 0;
        private int _d2 = 0;
        private int _d3 = 0;
        public int Total
        {
            get { return _Total}
            set { _Total = value}
        }
        public int d1
        {
            get { return _d1}
            set { _d1 = value}
        }
        public int d2
        {
            get { return _d2}
            set { _d2 = value}
        }
        public int d3
        {
            get { return _d3}
            set { _d3 = value}
        }
        //Methods
        public Game()
        {
            Total = 0;
            d1 = int Game.CreateDice();
            d2 = int Game.CreateDice();
            d3 = int Game.CreateDice();
            return Total
        }

        private int CreateDice()
        {
            Die d = new Die();
            Total += d.rolls();
            return d
        }

        public int Test()
        {
            return d1, d2, d3, Total
        }
    }
}
