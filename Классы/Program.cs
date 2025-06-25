namespace Классы
{
    class Unit
    {
        public string Name { get; }
        private float _health;
        public float Health
        {
            get { return _health; }
        }
        public Interval DamageInterval { get; }
        public float Armor { get; }

        public Unit() : this("Unknown Unit") { }

        public Unit(string name) : this(name, 0, 5) { }

        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            _health = 100f;
            DamageInterval = new Interval(minDamage, maxDamage);
            Armor = 0.6f;
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(float value)
        {
            _health = Health - value * Armor;
            if (Health <= 0f) { return true; }
            else { return false; }
        }
    }

    class Weapon
    {
        public string Name { get; }
        public Interval DamageInterval { get; private set; }
        public float Durability { get; }

        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
            DamageInterval = new Interval(1, 10);
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            DamageInterval = new Interval(minDamage, maxDamage);
        }

        public int GetDamage()
        {
            return DamageInterval.Get();
        }
    }

    struct Room
    {
        public Unit Unit { get; }
        public Weapon Weapon { get; }

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }

    struct Interval
    {
        private Random random;
        public int minValue;
        public int maxValue;

        public Interval(int minValue, int maxValue)
        {
            random = new Random();

            if (minValue > maxValue)
            {
                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
                Console.WriteLine("Данные некорректны: minValue > maxValue. Значения поменяны местами.");
            }

            if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Данные некорректны: maxValue < 0. Установлено значение 0.");
            }

            if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("Данные некорректны: minValue < 0. Установлено значение 0.");
            }

            if (maxValue == minValue)
            {
                maxValue = maxValue + 10;
                Console.WriteLine("Данные некорректны: minValue == maxValue. Максимальное значение увеличено на 10.");
            }

            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public int Min() => minValue;
        public int Max() => maxValue;

        public int Get()
        {
            return random.Next(minValue, maxValue + 1);
        }
    }

    class Dungeon
    {
        private Room[] rooms;

        public Dungeon()
        {
            rooms = new Room[]
            {
                new Room(new Unit("Воин"), new Weapon("Меч", 5, 15)),
                new Room(new Unit("Лучник", 1, 10), new Weapon("Лук", 3, 12)),
                new Room(new Unit("Маг"), new Weapon("Посох", 8, 20)),
                new Room(new Unit("Разбойник", 2, 8), new Weapon("Кинжалы", 4, 6))
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];
                Console.WriteLine($"Комната {i + 1}:");
                Console.WriteLine($"Юнит: {room.Unit.Name}, Здоровье: {room.Unit.Health}, Броня: {room.Unit.Armor}");
                Console.WriteLine($"Оружие: {room.Weapon.Name}, Прочность: {room.Weapon.Durability}");
                Console.WriteLine($"Урон оружия: {room.Weapon.DamageInterval.Min()}-{room.Weapon.DamageInterval.Max()}");
                Console.WriteLine("---");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon();
            dungeon.ShowRooms();
        }
    }
}