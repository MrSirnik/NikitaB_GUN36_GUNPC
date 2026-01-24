using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static FinalTask.CasinoGameBase;

namespace FinalTask
{
    internal class Casino : IGame
    {
        private static FileInfo _fileInfo = new FileInfo("Save");
        private string way = _fileInfo.DirectoryName;
        private string nik;
        private int balancePlayer;
        private int bet;

        public void StartGame()
        {
            way = Directory.GetParent(way).ToString();
            way = Directory.GetParent(way).ToString();
            way = Directory.GetParent(way).ToString();

            Console.WriteLine("Здравствуйте!");
            Console.Write("Введите ваш ник: ");
            nik = Console.ReadLine();

            FileSystemSaveLoadService savingPlayer
                = new FileSystemSaveLoadService(way + $"\\{nik}.txt");

            Console.Clear();
            Console.WriteLine($"Профиль {nik} открыт");
            balancePlayer = Convert.ToInt32(savingPlayer.LoadData(savingPlayer.way));
            Console.WriteLine($"Ваш баланс " + balancePlayer);

            while (true)
            {
                Console.WriteLine("Введите игру\nBlackjack - 1\nThe dice game - 2");
                switch (Console.ReadLine())
                {
                    case "1":
                        bet = Bets(balancePlayer);
                        Blackjack blackjack = new Blackjack(3);
                        blackjack.OnWin += OnWin;
                        blackjack.OnLoose += OnLoose;
                        blackjack.PlayGame();

                        break;
                    case "2":
                        bet = Bets(balancePlayer);
                        //Сделать выбор параметров для TheDiceGame
                        TheDiceGame theDiceGame = new TheDiceGame(3, 1, 6);
                        theDiceGame.OnWin += OnWin;
                        theDiceGame.OnLoose += OnLoose;
                        theDiceGame.PlayGame();
                        
                        break;
                    default:
                        Console.WriteLine("Вы ввели что-то неправильно!");
                        continue;
                }
                break;
            }
            savingPlayer.SaveData(balancePlayer.ToString(), savingPlayer.way);

            if(balancePlayer == 0)
            {
                Console.WriteLine("No money? Kicked!");
            }
            else
            {
                Console.WriteLine("Досвидания! Спасибо за игру!");
            }
        }

        private void OnWin(string message)
        {
            balancePlayer += bet;
        }
        private void OnLoose(string message)
        {
            balancePlayer -= bet;
        }

        private int Bets(int maxBet)
        {
            int bet;

            while (true)
            {
                Console.Write("Сделайте ставку: ");

                bet = Convert.ToInt32(Console.ReadLine());
                if (bet > maxBet || bet < 0)
                {
                    Console.WriteLine("У вас недостаточно денег");
                    continue;
                }
                else
                {
                    return bet;
                }
            }

        }


    }
}
