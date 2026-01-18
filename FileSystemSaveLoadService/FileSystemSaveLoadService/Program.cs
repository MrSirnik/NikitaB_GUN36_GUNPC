using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileSystemSaveLoadService;

namespace Program
{
    class Program
    {
        static void Main()
        {
            //Blackjack blackjack = new Blackjack(3);

            //blackjack.PlayGame();

            TheDiceGame theDiceGame = new TheDiceGame(3, 1 , 6);

            theDiceGame.PlayGame();
        }
    }
}

