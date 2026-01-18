using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemSaveLoadService
{
    internal class TheDiceGame : CasinoGameBase
    {
        private static Random rng = new Random();

        private int quantity;
        private int min;
        private int max;

        private Queue<int> dice_player = new Queue<int>();
        private Queue<int> dice_PC = new Queue<int>();

        public TheDiceGame(int quantity, int min, int max)
        {
            this.quantity = quantity;
            this.min = min;
            this.max = max;
        }

        public override void PlayGame()
        {
            int points_player = 0;
            int points_PC = 0;

            FactoryMethod();

            for (int i = 0; i < dice_player.Count; i++)
            {
                points_player += dice_player.Dequeue();
                points_PC += dice_PC.Dequeue();
            }

            Console.WriteLine($"У вас - {points_player} Points");
            Console.WriteLine($"У компьютера - {points_PC} Points");

            if(points_player > points_PC)
            {
                OnWinInvoke();
            }
            else if (points_PC > points_player)
            {
                OnLooseInvoke();
            }
            else
            {
                OnDrawInvoke();
            }

        }

        protected override void FactoryMethod()
        {
            List<int> dice_player = new List<int>();
            List<int> dice_PC = new List<int>();

            for (int i = 0; i < quantity; i++)
            {
                dice_player.Add(rng.Next(min, max + 1));
                dice_PC.Add(rng.Next(min, max + 1));
            }

            this.dice_player = new Queue<int>(dice_player);
            this.dice_PC = new Queue<int>(dice_PC);
        }
    }
}
