namespace RPG_Game
{
    public class Player : Character, ISpellCaster

    {
        private int _mana;
        private int _maxMana;
        private int _expirience;
        private int _level;
        private IEquippable _equippableWeapon;
        private List<Item> _inventory;


        public int Mana
        {
            get => _mana;
            private set => _mana = Math.Max(0, Math.Min(value, _maxMana));
        }

        public int MaxMana
        {
            get => _maxMana;
            private set => _maxMana = value;
        }

        public int Expirience
        {
            get => _expirience;
            private set => _expirience = value;
        }

        public int Level
        {
            get => _level;
            private set => _level = value;
        }

        public IReadOnlyList<Item> Inventory => _inventory.AsReadOnly();


        public Player(string name, int strength) : base(name, 100, strength)
        {
            _maxMana = 50;
            _mana = _maxMana;
            _level = 1;
            _expirience = 0;
            _inventory = new List<Item>();
        }

      
        public override void Attack(Character target)
        {
            var rand = new Random();
            var damage = isCritical ? baseDamage * 2 : baseDamage;

            if (_equippableWeapon != null && _equippableWeapon is Weapon weapon)
            {
                baseDamage += weapon.Damage;
            }

            var isCritical = rand.Next(100) < 20;
            var damge = isCritical ? baseDamage * 2 : baseDamage;

            if (isCritical)
            {
                Console.WriteLine($"Критичний удар! {Name} завдає {damage} пошкодженнь {target.Name}! ");
            }
            else
            {
                  Console.WriteLine($"{Name} атакує {target.Name} і завдає {damage} пошкоджень!}");
            }

            target.TakeDamage(int amount);
        }

        public void CastSpell(Character target)
        {
            throw new NotImplementedException();
        }

        public void RestoreMana(int amount)
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
                                   