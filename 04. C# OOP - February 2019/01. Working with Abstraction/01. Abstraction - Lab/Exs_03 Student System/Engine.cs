namespace Exs_03_Student_System
{

    public class Engine
    {

        private StudentSystem studentSystem;
        private CommandParser parser;
        private InputReader reader;
        private OutputWriter writer;

        public Engine()
        {
            this.studentSystem = new StudentSystem();
            this.parser = new CommandParser();
            this.reader = new InputReader();
            this.writer = new OutputWriter();
        }

        public bool Execute(Command command)
        {
            switch (command.Type)
            {
                case "Create":
                    var student = parser.GetStudent(command.Arguments);
                    studentSystem.Add(student);
                    return true;
                case "Show":
                    string name = command.Arguments[0];
                    writer.PrintOutput(studentSystem.Show(name));
                    return true;
                case "Exit":

                    break;
            }
            return false;
        } 
        public void Run()
        {
            while (true)
            {
                string input = reader.GetInput();
                var command = parser.GetCommand(input);
                if (!this.Execute(command)) return;
            }
        }

    }
}
