namespace RPGHeros.Interfaces
{
    public abstract class Hero
    {
        public string Name { get; set; }
        protected int HealthStat { get; set; }
        protected int AttackStat { get; set; }
        protected int DefenceStat { get; set; }

        public abstract void Attack();

        public string ViewStats()
        {
            return $"Health:{HealthStat}, Attack:{AttackStat}, Defence:{DefenceStat}";
        }
    }
}
