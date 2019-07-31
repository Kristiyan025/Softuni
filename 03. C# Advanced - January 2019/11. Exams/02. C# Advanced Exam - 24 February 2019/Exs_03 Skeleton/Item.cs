namespace Heroes
{
    public class Item
    {

        public Item(int strength, int ability, int intelligence)
        {
            this.Strength = strength;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }

        public int Strength { get; set; }

        public int Ability { get; set; }

        public int Intelligence { get; set; }

        override public string ToString()
        {
            return "Item:" + '\n' +
                $"  * Strength: {this.Strength}" + '\n' +
                $"  * Ability: {this.Ability}" + '\n' +
                $"  * Intelligence: {this.Intelligence}";
        }

    }
}
