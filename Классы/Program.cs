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
        public int Damage { get; }
        public float Armor { get; }
        public Unit() : this("Unknown Unit") { }
        public Unit(string name)
        {
            Name = name;
            _health = 100f;
            Damage = 5;
            Armor = 0.6f;
        }
        public float GetRealHealth()
        {
            
            return Health * (1f + Armor);
        }
        public bool SetDamage( float value )
        {
            _health = Health - value * Armor;
            if (Health <= 0f) { return true; }
            else { return false; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit unit1 = new Unit();
            Unit unit2 = new Unit("Hero");

            Console.WriteLine(unit1.Name);
            Console.WriteLine(unit2.Name);
        }
    }
}