namespace PlayersAndMonsters.Core
{
    using System;
    using Contracts;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private ManagerController manager;
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.manager = new ManagerController();
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string input = reader.ReadLine();
                if (input == "Exit")
                {
                    break;
                }

                var parts = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                string s = string.Empty;
                switch (command)
                {
                    case "AddPlayer":
                        s += this.manager.AddPlayer(parts[1], parts[2]);
                        break;
                    case "AddCard":
                        s += this.manager.AddCard(parts[1], parts[2]);
                        break;
                    case "AddPlayerCard":
                        s += this.manager.AddPlayerCard(parts[1], parts[2]);
                        break;
                    case "Fight":
                        s += this.manager.Fight(parts[1], parts[2]);
                        break;
                    case "Report":
                        s += this.manager.Report();
                        break;
                }

                writer.WriteLine(s);
            }
        }
    }
}
