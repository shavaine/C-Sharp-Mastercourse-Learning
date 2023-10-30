using System;
using RPGHeros.Enums;
using RPGHeros.Interfaces;

namespace RPGHeros.Models
{
    public class ArcherModel : Hero, IBow
    {
        public ArcherModel()
        {
            HealthStat = 110;
            AttackStat = 110;
            DefenceStat = 105;
        }

        public Weapons Bow { get; set; } = Weapons.Bow;

        public override void Attack()
        {
            Console.WriteLine($"{Name} shoots bow and hits!");
        }
    }
}
