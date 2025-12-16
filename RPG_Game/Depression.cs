namespace RPG_Game
{
    public class Depression : Enemy
    {
        public Depression() : base("Депресія", 4, 3, 30)
        {
            AddLoot(new HealthPotion());
        }

        public override void Attack(Character target)
        {
            var damage = Strength;
            Console.WriteLine($"{Name} б'є кинджалом і завдає {damage}");
            target.TakeDamage(damage);
        }
    }
}
                                   