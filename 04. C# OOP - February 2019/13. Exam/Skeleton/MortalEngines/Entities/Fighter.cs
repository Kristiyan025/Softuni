namespace MortalEngines.Entities
{
    using System;
    using Contracts;

    public class Fighter : BaseMachine, IFighter
    {
        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, 200)
        {
            this.AggressiveMode = true;
        }

        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            if (this.AggressiveMode)
            {
                this.AggressiveMode = false;
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
            else
            {
                this.AggressiveMode = true;
                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
        }

        public override string ToString()
        {
            string s = Environment.NewLine + base.ToString() +
                       " *Aggressive: ";
            if (!this.AggressiveMode) s += "ON";
            else s += "OFF";
            return s;
        }
    }
}
