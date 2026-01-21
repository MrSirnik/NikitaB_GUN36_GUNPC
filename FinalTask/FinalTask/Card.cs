using System;

namespace FinalTask
{
    public struct Card
    {

        public readonly EnumSuits suits;
        public readonly EnumNominal nominal;

        public Card(EnumSuits suits, EnumNominal nominal)
        {
            this.suits = suits;
            this.nominal = nominal;
        }
        public void String()
        {
            Console.WriteLine(suits); 
            Console.WriteLine(nominal); 
        }
    }
}