namespace RPG_Game
{
    public interface IEquippable
    {
        string Name { get; }
        void Equip(Player player);
        void Unequip(Player player);
    }

    public interface ISpellCaster
    {
        int Mana { get; }
        void CastSpell(Character target);
        void RestoreMana(int amount);
    }
    public class Player
    {

    }



    internal class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
                                   