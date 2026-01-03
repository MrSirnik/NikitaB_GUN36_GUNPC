using System;

public class WrongDiceNumberException : Exception
{

	public WrongDiceNumberException()
	{

	}

    public override readonly string ToString()
	{
		return "Для ошибки на непопадание в диапазон";
    }
}
