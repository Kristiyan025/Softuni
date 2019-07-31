namespace FightingArena
{
    using System.Collections.Generic;
    using System.Linq;

    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public string Name { get; }

        private List<Gladiator> Gladiators
        {
            get => this.gladiators;
        }

        public int Count { get => this.gladiators.Count; }

        public void Add(Gladiator gladiator)
        {
            this.Gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            var gladiator = this.Gladiators.FirstOrDefault(x => x.Name == name);
            if (gladiator != null)
                this.Gladiators.Remove(gladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            int maxStat = this.Gladiators
                .Select(x => x.GetStatPower())
                .Max();
            var gladiator = this.Gladiators.FirstOrDefault(x => x.GetStatPower() == maxStat);
            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            int maxWeapon = this.Gladiators
                .Select(x => x.GetWeaponPower())
                .Max();
            var gladiator = this.Gladiators.FirstOrDefault(x => x.GetWeaponPower() == maxWeapon);
            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            int maxTotal = this.Gladiators
                .Select(x => x.GetTotalPower())
                .Max();
            var gladiator = this.Gladiators.FirstOrDefault(x => x.GetTotalPower() == maxTotal);
            return gladiator;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Count} gladiators are participating.";
        }
    }
}
