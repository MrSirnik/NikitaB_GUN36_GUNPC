using System;

public struct Card 
{

    readonly EnumSuits suits;
    readonly EnumNominal nominal; 

    public Card(EnumSuits suits, EnumNominal nominal)
    {
        this.suits = suits;
        this.nominal = nominal;
    }
}
