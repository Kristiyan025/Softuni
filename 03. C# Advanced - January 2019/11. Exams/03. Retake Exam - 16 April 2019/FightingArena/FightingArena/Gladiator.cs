namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; }

        public Stat Stat { get; }

        public Weapon Weapon { get; }

        public int GetWeaponPower()
        {
            int sum = 0;
            sum += this.Weapon.Size;
            sum += this.Weapon.Solidity;
            sum += this.Weapon.Sharpness;
            return sum;
        }

        public int GetStatPower()
        {
            int sum = 0;
            sum += this.Stat.Strength;
            sum += this.Stat.Flexibility;
            sum += this.Stat.Agility;
            sum += this.Stat.Skills;
            sum += this.Stat.Intelligence;
            return sum;
        }

        public int GetTotalPower()
        {
            int sum = 0;
            sum += this.GetStatPower();
            sum += this.GetWeaponPower();
            return sum;
        }

        public override string ToString()
        {
            string s = string.Empty;
            s += $"{this.Name} - {this.GetTotalPower()}\n";
            s += $"  Weapon Power: {this.GetWeaponPower()}\n";
            s += $"  Stat Power: {this.GetStatPower()}";
            return s;
        }

    }
}
