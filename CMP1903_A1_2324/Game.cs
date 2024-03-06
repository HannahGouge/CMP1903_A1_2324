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
        private int _Total = 0;
        private int _d1 = 0;
        private int _d2 = 0;
        private int _d3 = 0;
        public int Total { get; set; }
        public int d1 { get; set; }
        public int d2 { get; set; }
        public int d3 { get; set; }
       
        //Methods
        public Game()
        {
            Total = 0;
        }
        public int RunGame()
        {
            d1 = CreateDice();
            d2 = CreateDice();
            d3 = CreateDice();
            _Total = AddDice(d1, d2, d3);
            return _Total;
        }

        private int CreateDice()
        {
            Die d = new Die();
            int dice = d.roll();
            return dice;
        }
        private int AddDice(int d1, int d2, int d3)
        {
            _Total = d1 + d2 + d3;
            return _Total;
        }
        public int Test(int d1, int d2, int d3)
        {
            _Total = AddDice(d1, d2, d3);
            return _Total;
        }
    }
}
