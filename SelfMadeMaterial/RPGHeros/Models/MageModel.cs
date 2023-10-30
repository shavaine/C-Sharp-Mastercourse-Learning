using System;
using RPGHeros.Enums;
using RPGHeros.Interfaces;

namespace RPGHeros.Models
{
    public class MageModel : Hero, IStaff
    {
        public MageModel()
        {
            HealthStat = 90;
            AttackStat = 125;
            DefenceStat = 100;
        }

        public Weapons Staff { get; set; } = Weapons.Staff;

        public override void Attack()
        {
            Console.WriteLine($"{Name} summones lightning stike!");
        }
    }
}
