namespace Классы
{
    class Unit
    {
        public string Name;
        private float _Health;
        public int Damage;
        public float Armor;
        public void Character_name(string name = "Unknown Unit")
        {
            Name = name;
            _Health = 100f;
            Damage = 5;
            Armor = 0.6f;
        }
        public float GetRealHealth()
        {
            
            return _Health * (1f + Armor);
        }
        public bool SetDamage( float value )
        {
            _Health = _Health - value * Armor;
            if (_Health <= 0f) { return true; }
            else { return false; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}