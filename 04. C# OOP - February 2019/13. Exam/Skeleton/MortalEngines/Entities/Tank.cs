namespace MortalEngines.Entities
{
    using System;
    using Contracts;

    public class Tank : BaseMachine, ITank
    {
        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, 100)
        {
            this.DefenseMode = true;
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
            else
            {
                this.DefenseMode = true;
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            string s = Environment.NewLine + base.ToString() +
                       " *Defense: ";
            if (!this.DefenseMode) s += "ON";
            else s += "OFF";
            return s;
        }
    }
}
