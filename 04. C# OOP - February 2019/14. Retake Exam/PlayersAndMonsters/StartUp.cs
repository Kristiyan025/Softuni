namespace PlayersAndMonsters
{
    using Core;
    using IO;

    public class StartUp
    {
        public static void Main(string[] args)
        {

            var engine = new Engine(new ConsoleReader(), new ConsoleWriter());
            engine.Run();

        }
    }
}