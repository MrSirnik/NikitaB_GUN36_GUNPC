using System;

public struct Dice
{
    public int number
    {
        get
        {
            Random rn = new Random();
            return rn.Next(_min, _max + 1 );
        }
    };

    private int _min;
    private int _max;

    public Dice( int min, int max )
    {
        if (min < 1 || min > int.MaxValue)
        {
            //исключение
            Console.WriteLine($"Некорректное значение: {min}." +
                $" Допустимый диапазон: от {1} до {int.MaxValue}");
        }

        else if (max < 1 || max > int.MaxValue)
        {
            //исключение
            Console.WriteLine($"Некорректное значение: {max}." +
                $" Допустимый диапазон: от {1} до {int.MaxValue}");
        }

        else
        {
            _min = min;
            _max = max;
        }
    }

    public override readonly string ToString()
    {
        return $"Dice({_min}-{_max}): {number}";
    }
}
