using System;

namespace FileSystemSaveLoadService
{
    public struct Card
    {

        readonly EnumSuits suits;
        readonly EnumNominal nominal;

        public Card(EnumSuits suits, EnumNominal nominal)
        {
            this.suits = suits;
            this.nominal = nominal;
        }
        public void ToString()
        {
            Console.WriteLine(suits); 
            Console.WriteLine(nominal); 
        }
    }
}