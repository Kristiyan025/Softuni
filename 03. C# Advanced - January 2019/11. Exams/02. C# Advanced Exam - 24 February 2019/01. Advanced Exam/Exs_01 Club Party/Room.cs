namespace Exs_01_Club_Party
{
    using System.Collections.Generic;

    public class Room
    {

        public Room(char hall)
        {
            this.Hall = hall;
            this.Reservations = new List<int>();
        }

        public char Hall { get; set; }

        public List<int> Reservations { get; set; }

    }
}
