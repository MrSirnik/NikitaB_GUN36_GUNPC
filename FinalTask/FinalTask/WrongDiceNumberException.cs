using System;

namespace FinalTask
{
	public class WrongDiceNumberException : Exception
	{

		public WrongDiceNumberException()
		{

		}

		public override string ToString()
		{
			return "Для ошибки на непопадание в диапазон";
		}
	}
}

