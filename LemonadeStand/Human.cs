using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Human : Player
    {
        public override void  SetName()
        {
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            if (playerName.Length < 3)
            {
                Console.WriteLine("That is not your name.  Let's try this again.");
                SetName();
            }
        }

    }
}
