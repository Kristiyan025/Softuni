using System;
using MortalEngines.Core;

namespace MortalEngines
{
    public class StartUp
    {
        public static void Main()
        {
            /*
            var manager = new MachinesManager();

            Console.WriteLine(manager.HirePilot("Angel"));
            Console.WriteLine(manager.HirePilot("Angel"));
            Console.WriteLine();

            Console.WriteLine(manager.PilotReport("K"));
            Console.WriteLine();

            Console.WriteLine(manager.MachineReport("L"));
            Console.WriteLine();

            Console.WriteLine(manager.ManufactureTank("A",12,50));
            Console.WriteLine(manager.ManufactureTank("T",12,50));
            Console.WriteLine(manager.ManufactureTank("A",12,23));
            Console.WriteLine();

            Console.WriteLine(manager.ToggleTankDefenseMode("A"));
            Console.WriteLine(manager.ToggleTankDefenseMode("D"));
            Console.WriteLine();

            Console.WriteLine(manager.ManufactureFighter("P", 170, 50));
            Console.WriteLine(manager.ManufactureFighter("F", 360, 50));
            Console.WriteLine(manager.ManufactureFighter("P", 12, 50));
            Console.WriteLine();

            Console.WriteLine(manager.ToggleFighterAggressiveMode("P"));
            Console.WriteLine(manager.ToggleFighterAggressiveMode("M"));
            Console.WriteLine();

            Console.WriteLine(manager.EngageMachine("Nqkoi", "Neshto"));
            Console.WriteLine(manager.EngageMachine("Angel", "Neshto"));
            Console.WriteLine(manager.EngageMachine("Angel", "P"));
            Console.WriteLine(manager.EngageMachine("Angel", "P"));
            Console.WriteLine();

            //machines: A P
            Console.WriteLine(manager.AttackMachines("Q", "A"));
            Console.WriteLine(manager.AttackMachines("A", "Q"));
            Console.WriteLine(manager.AttackMachines("P", "A"));
            Console.WriteLine(manager.AttackMachines("F", "P"));
            Console.WriteLine(manager.AttackMachines("A", "T"));
            Console.WriteLine(manager.AttackMachines("T", "P"));
            Console.WriteLine();
            */
            var engine = new Engine();
            engine.Run();

        }
    }
}