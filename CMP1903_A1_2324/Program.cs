using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Game g1 = new Game();
            int Result = g1.RunGame();
            Console.WriteLine($"The total of all 3 dice is " + Result);
            Testing t1 = new Testing();
        }
    }
}
