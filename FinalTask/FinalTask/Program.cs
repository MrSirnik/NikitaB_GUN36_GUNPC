using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalTask
{
    class Program
    {
        static void Main()
        {
            //Blackjack blackjack = new Blackjack(3);

            //blackjack.PlayGame();

            Casino casino = new Casino();
            casino.StartGame();

            //TheDiceGame theDiceGame = new TheDiceGame(3, 1, 6);

            //theDiceGame.PlayGame();
        }
    }
}

