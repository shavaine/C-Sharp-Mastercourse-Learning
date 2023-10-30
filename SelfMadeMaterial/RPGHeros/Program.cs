using System.Collections.Generic;
using RPGHeros.Interfaces;
using RPGHeros.Models;

namespace RPGHeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WarriorModel John = new WarriorModel { Name = "John" };
            MageModel Tabetha = new MageModel { Name = "Tabetha" };
            ArcherModel Leon = new ArcherModel { Name = "Leon" };

            Party Guild = new Party { Companions = new List<Hero> { John, Tabetha, Leon } };
            John.Attack();
            Guild.ListParty();
            Guild.ListPartyStats();
        }
    }
}
