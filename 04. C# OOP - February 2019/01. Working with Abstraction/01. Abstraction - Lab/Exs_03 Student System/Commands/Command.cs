namespace Exs_03_Student_System
{
    public class Command
    {

        public Command(string type, string[] arguments)
        {
            this.Type = type;
            this.Arguments = arguments;
        }

        public string Type { get; set; }

        public string[] Arguments { get; set; }

    }
}
