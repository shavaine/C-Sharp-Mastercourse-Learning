using System;
using RPGHeros.Enums;

namespace RPGHeros.Interfaces
{
    public class WarriorModel : Hero, ISword
    {
        public WarriorModel()
        {
            HealthStat = 105;
            AttackStat = 110;
            DefenceStat = 115;
        }

        public Weapons Sword { get; set; } = Weapons.Sword;

        public override void Attack()
        {
            Console.WriteLine($"{Name} slashes with sword!");
            Console.WriteLine($"{AttackStat}");
        }
    }
}
