namespace MortalEngines.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;

        public BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Machine name cannot be null or empty.");
                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get => this.pilot;
            set
            {
                if (value is null)
                    throw new NullReferenceException("Pilot cannot be null.");
                this.pilot = value;
            }

        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets { get; protected set; }

        public void Attack(IMachine target)
        {
            if (target is null)
                throw new NullReferenceException("Target cannot be null");

            target.HealthPoints -= (this.AttackPoints - target.DefensePoints);
            if (target.HealthPoints < 0) target.HealthPoints = 0;
            this.Targets.Add(target.Name);
        }

        public override string ToString()
        {
            string s =  $"- {this.Name}\n" +
                        $" *Type: {this.GetType().Name}\n" +
                        $" *Health: {this.HealthPoints:F2}\n" +
                        $" *Attack: {this.AttackPoints:F2}\n" +
                        $" *Defense: {this.DefensePoints:F2}\n" +
                         " *Targets: ";
            var targets = this.Targets.ToList();
            if (targets.Count != 0)
                s += string.Join(",", targets);
            else
                s += "None";

            return s;
        }
    }
}
