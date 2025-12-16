using System.Reflection.Emit;
using System.Xml.Linq;

namespace RPG_Game
{
    public class Weapon : Item, IEquippable
    {
        public int Damage { get; protected set; } 
        public Weapon(string name, string description, int damage) : base(name, description)
        {
            Damage = damage;
        }

        public void Equip(Player player)
        {
            Console.WriteLine($"{Name} екіпіровано! (+{Damage} до атаки)");
        }
         
        public void Unequip(Player player)
        {
            Console.WriteLine($"{Name} знято.");
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} екіпірує {Name}!");
            Equip(player);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
                                   