using System;
using System.Collections.Generic;

namespace RPGHeros.Interfaces
{
    public class Party
    {
        public List<Hero> Companions { get; set; }

        public void GroupAttack(List<Hero> companions)
        {
            foreach (var hero in companions)
            {
                hero.Attack();
            }
        }

        public void ListParty()
        {
            Console.WriteLine("Current Party:");
            foreach (var hero in Companions)
            {
                Console.WriteLine(hero.Name);
            }
        }

        public void ListPartyStats()
        {
            Console.WriteLine("Current Party Stats:");
            foreach (var hero in Companions)
            {
                Console.WriteLine(hero.Name);
                Console.WriteLine(hero.ViewStats());
                Console.WriteLine();
            }
        }
    }
}
