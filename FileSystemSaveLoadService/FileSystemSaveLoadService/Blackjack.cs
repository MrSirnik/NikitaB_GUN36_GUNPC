using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace FileSystemSaveLoadService
{
    internal class Blackjack : CasinoGameBase
    {
        private static Random rng = new Random();

        public List<Card> cards = new List<Card>();
        private Queue<Card> _deck = new Queue<Card>();//колода карт

        public Blackjack(int number_of_cards)
        {

        }

        public void Shuffle()
        {
            List<Card> cards = new List<Card>(this.cards);

            int n = cards.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }

            _deck = new Queue<Card>(cards);
        }

        public override void PlayGame()
        {
            Shuffle();

            List<Card> cards_player = new List<Card>();
            List<Card> cards_PC = new List<Card>();

            cards_player.Add(_deck.Dequeue());
            cards_player.Add(_deck.Dequeue());

            cards_PC.Add(_deck.Dequeue());
            cards_PC.Add(_deck.Dequeue());

            while (true)
            {
                ListOutput(cards_player, nameof(cards_player));

                Console.WriteLine("Взять ещё карту: Y/N");
                string stop_game = Console.ReadLine().ToString().ToLower();
                Console.Clear();

                if (stop_game == "y")
                {
                    cards_player.Add(_deck.Dequeue());

                    cards_PC.Add(_deck.Dequeue());

                }
                else if (stop_game == "n")
                {
                    //остановка игры и подчет карт
                    Console.WriteLine("Очки игрока: ");
                    Console.WriteLine(CountingCards(cards_player));
                    Console.WriteLine("Очки компьютера: ");
                    Console.WriteLine(CountingCards(cards_PC));

                    break;
                }
                else
                {
                    continue;
                }
            }

            while (true)
            {
                if (ComparingPoints(CountingCards(cards_player), CountingCards(cards_PC)) == "issue by card")
                {
                    Console.WriteLine("Одинаковое количество очков");

                    cards_player.Add(_deck.Dequeue());
                    cards_PC.Add(_deck.Dequeue());

                    ListOutput(cards_player, nameof(cards_player));

                }
                else
                {
                    break;
                }
            }
            

        }

        public string ComparingPoints( int points_player, int points_PC)
        {
            if ((points_player == 21 && points_PC != 21) || (points_player > points_PC && points_player < 21))
            {
                OnWinInvoke();
                
                return "player win";
            }
            else if ((points_PC == 21 && points_player != 21) || (points_PC > points_player && points_PC < 21))
            {
                OnLooseInvoke();

                return "PC win";
            }
            else if ((points_PC == 21 && points_player == 21) || (points_PC > 21 && points_player > 21))
            {
                OnDrawInvoke();

                return "draw";
            }
            else
            {
                return "issue by card";
            }

        }

        public int CountingCards(List<Card> list)
        {
            int sum = 0;
            int aces = 0;

            foreach (var item in list)
            {
                switch (item.nominal)
                {
                    case EnumNominal.Six:
                        {
                            sum = sum + 6;
                            break;
                        }
                    case EnumNominal.Seven:
                        {
                            sum = sum + 7;
                            break;
                        }
                    case EnumNominal.Eight:
                        {
                            sum = sum + 8;
                            break;
                        }
                    case EnumNominal.Nine:
                        {
                            sum = sum + 9;
                            break;
                        }
                    case EnumNominal.Ten:
                        {
                            sum = sum + 10;
                            break;
                        }
                    case EnumNominal.Jack:
                        {
                            sum = sum + 10;
                            break;
                        }
                    case EnumNominal.Queen:
                        {
                            sum = sum + 10;
                            break;
                        }
                    case EnumNominal.King:
                        {
                            sum = sum + 10;
                            break;
                        }
                    case EnumNominal.Ace:
                        {
                            aces++;
                            break;
                        }
                }
            }

            for (int i = aces; aces > 0; i++)
            {
                if (sum + 11 <= 21)
                {
                    sum += 11;

                    aces--;
                }
                else
                {
                    sum++;

                    aces--;
                }
            }

            return sum;
        }

        public void ListOutput(List<Card> list, string name)
        {
            Console.WriteLine("Вывод списка - " + name);

            foreach (Card item in list)
            {
                Console.Write(item.suits.ToString() + "  ");
                Console.WriteLine(item.nominal.ToString());
            }
            Console.WriteLine();
        }

        protected override void FactoryMethod()
        {
            Array allEnumNominal = Enum.GetValues(typeof(EnumNominal));
            Array allEnumSuits = Enum.GetValues(typeof(EnumSuits));

            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    cards.Add(new Card((EnumSuits)allEnumSuits.GetValue(j),
                        (EnumNominal)allEnumNominal.GetValue(i)));
                }
            }
        }
    }
}
