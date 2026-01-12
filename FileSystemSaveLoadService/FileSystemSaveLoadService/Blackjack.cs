using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace FileSystemSaveLoadService
{
    internal class Blackjack: CasinoGameBase
    {
        public List<Card> cards = new List<Card>();
        private Queue<Card> _deck = new Queue<Card>();//колода карт

        public Blackjack(int number_of_cards)
        {

        }

        private void Shuffle()
        {

        }

        public override void PlayGame()
        {

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
