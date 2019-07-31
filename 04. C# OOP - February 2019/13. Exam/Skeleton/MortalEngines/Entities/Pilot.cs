namespace MortalEngines.Entities
{
    using System;
    using System.Collections.Generic;
    using Contracts;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            machines = new List<IMachine>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Pilot name cannot be null or empty string.");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (machine is null)
                throw new NullReferenceException("Null machine cannot be added to the pilot.");
            this.machines.Add(machine);
        }

        public string Report()
        {
            string s = $"{this.name} - {this.machines.Count} machines\n";
            foreach (var machine in machines)
            {
                s += machine.ToString();
            }

            return s;
        }
    }
}
