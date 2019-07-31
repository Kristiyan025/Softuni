namespace MortalEngines.Core
{
    using System;
    using Contracts;

    public class Engine : IEngine
    {
        public void Run()
        {
            var manager = new MachinesManager();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Quit")
                {
                    break;
                }

                var commandParts = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string command = commandParts[0];
                string s = string.Empty;
                try
                {
                    switch (command)
                    {
                        case "HirePilot":
                            s = manager.HirePilot(commandParts[1]);
                            break;
                        case "PilotReport":
                            s = manager.PilotReport(commandParts[1]);
                            break;
                        case "ManufactureTank":
                            s = manager.ManufactureTank(commandParts[1], 
                                             double.Parse(commandParts[2]),
                                            double.Parse(commandParts[3]));
                            break;
                        case "ManufactureFighter":
                            s = manager.ManufactureFighter(commandParts[1],
                                                double.Parse(commandParts[2]),
                                               double.Parse(commandParts[3]));
                            break;
                        case "MachineReport":
                            s = manager.MachineReport(commandParts[1]);
                            break;
                        case "AggressiveMode":
                            s = manager.ToggleFighterAggressiveMode(commandParts[1]);
                            break;
                        case "DefenseMode":
                            s = manager.ToggleTankDefenseMode(commandParts[1]);
                            break;
                        case "Engage":
                            s = manager.EngageMachine(commandParts[1],
                                                      commandParts[2]);
                            break;
                        case "Attack":
                            s = manager.AttackMachines(commandParts[1],
                                                       commandParts[2]);
                            break;
                    }

                    Console.WriteLine(s);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

            }
        }
    }
}
