namespace RPG_Game
{
    public interface IEquippable
    {
        string Name { get; }
        void Equip();
        void Unequip();
    }
    public abstract class Character
    {
        private string _name;
        private int _health;
        private int _maxHealth;
        private int _strenght;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
                                   