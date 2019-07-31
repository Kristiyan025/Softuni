namespace MortalEngines.Core
{
    using System.Collections.Generic;
    using Entities.Contracts;
    using Entities;
    using System.Linq;
    using Common;
    using Contracts;

    public class MachinesManager : IMachinesManager
    {
        public MachinesManager()
        {
            this.Pilots = new List<IPilot>();
            this.Machines = new List<IMachine>();
        }

        public List<IPilot> Pilots { get; private set; }

        public List<IMachine> Machines { get; private set; }

        public string HirePilot(string name)
        {
            if (this.Pilots.Exists(x=>x.Name == name))
               return OutputMessages.PilotExists.Replace("{0}", name);

            this.Pilots.Add(new Pilot(name));
            return OutputMessages.PilotHired.Replace("{0}", name);
        }

        public string ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            if (this.Machines.Exists(x => x.Name == name))
                return OutputMessages.MachineExists.Replace("{0}", name);
            var machine = new Tank(name, attackPoints, defensePoints);
            machine.ToggleDefenseMode();
            Machines.Add(machine);
            return OutputMessages.TankManufactured
                    .Replace("{0}", name)
                    .Replace("{1:F2}", machine.AttackPoints.ToString("0.00"))
                    .Replace("{2:F2}", machine.DefensePoints.ToString("0.00"));
        }

        public string ManufactureFighter(string name, double attackPoints, double defensePoints)
        {
            if (this.Machines.Exists(x => x.Name == name))
                return OutputMessages.MachineExists.Replace("{0}", name);
            var machine = new Fighter(name, attackPoints, defensePoints);
            machine.ToggleAggressiveMode();
            Machines.Add(machine);
            return OutputMessages.FighterManufactured
                    .Replace("{0}", name)
                    .Replace("{1:F2}", machine.AttackPoints.ToString("0.00"))
                    .Replace("{2:F2}", machine.DefensePoints.ToString("0.00"))
                    .Replace("{3}", "ON");
        }

        public string EngageMachine(string selectedPilotName, string selectedMachineName)
        {
            var pilot = this.Pilots.FirstOrDefault(x => x.Name == selectedPilotName);
            if (pilot is null)
                return OutputMessages.PilotNotFound
                    .Replace("{0}", selectedPilotName);
            var machine = this.Machines.FirstOrDefault(x => x.Name == selectedMachineName);
            if (machine is null)
                return OutputMessages.MachineNotFound
                    .Replace("{0}", selectedMachineName);
            if (machine.Pilot != null)
                return OutputMessages.MachineHasPilotAlready
                    .Replace("{0}", selectedMachineName);
            pilot.AddMachine(machine);
            machine.Pilot = pilot;
            return OutputMessages.MachineEngaged
                    .Replace("{0}", pilot.Name)
                    .Replace("{1}", machine.Name);
        }

        public string AttackMachines(string attackingMachineName, string defendingMachineName)
        {
            var machine1 = this.Machines.FirstOrDefault(x => x.Name == attackingMachineName);
            if (machine1 is null)
                return OutputMessages.MachineNotFound
                    .Replace("{0}", attackingMachineName);
            var machine2 = this.Machines.FirstOrDefault(x => x.Name == defendingMachineName);
            if (machine2 is null)
                return OutputMessages.MachineNotFound
                    .Replace("{0}", defendingMachineName);

            if (machine1.HealthPoints == 0.0d)
                return OutputMessages.DeadMachineCannotAttack
                    .Replace("{0}", machine1.Name);
            if (machine2.HealthPoints == 0.0d)
                return OutputMessages.DeadMachineCannotAttack
                    .Replace("{0}", machine2.Name);

            machine1.Attack(machine2);
            return OutputMessages.AttackSuccessful
                .Replace("{0}", machine2.Name)
                .Replace("{1}", machine1.Name)
                .Replace("{2:F2}", machine2.HealthPoints.ToString("0.00"));
        }

        public string PilotReport(string pilotReporting)
        {
            var pilot =  this.Pilots.FirstOrDefault(x => x.Name == pilotReporting);
            if (pilot is null)
                return OutputMessages.PilotNotFound
                        .Replace("{0}", pilotReporting);
            return pilot.Report();
        }

        public string MachineReport(string machineName)
        {
            var machine = this.Machines.FirstOrDefault(x => x.Name == machineName);
            if (machine is null)
                return OutputMessages.MachineNotFound
                    .Replace("{0}", machineName);
            return machine.ToString();
        }

        public string ToggleFighterAggressiveMode(string fighterName)
        {
            var fighter = (Fighter)this.Machines.FirstOrDefault(x => x.Name == fighterName);
            if (fighter is null)
                return OutputMessages.MachineNotFound
                    .Replace("{0}", fighterName);
            fighter.ToggleAggressiveMode();
            return OutputMessages.FighterOperationSuccessful
                .Replace("{0}", fighterName);
        }

        public string ToggleTankDefenseMode(string tankName)
        {
            var tank = (Tank)this.Machines.FirstOrDefault(x => x.Name == tankName);
            if (tank is null)
                return OutputMessages.MachineNotFound
                    .Replace("{0}", tankName);
            tank.ToggleDefenseMode();
            return OutputMessages.TankOperationSuccessful
                .Replace("{0}", tankName);
        }
    }
}