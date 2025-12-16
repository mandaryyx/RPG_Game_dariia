using System.Reflection.Emit;
using System.Xml.Linq;

namespace RPG_Game
{

    public class HealthPotion : Item
    {
        private int _healAmount;
        public HealthPotion() : base("Зілля здоров'я", "Відновлює 40 HP")
        {
            _healAmount = 40;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} використовує {Name}");
            player.Heal(_healAmount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
                                   