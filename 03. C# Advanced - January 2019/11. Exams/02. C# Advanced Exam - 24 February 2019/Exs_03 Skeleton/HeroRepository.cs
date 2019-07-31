namespace Heroes
{
    using System.Collections.Generic;
    using System.Linq;

    public class HeroRepository
    {

        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count { get => this.data.Count; }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            int index = this.data.IndexOf(this.data.First(x => x.Name == name));
            this.data.RemoveAt(index);
            //return this.Count;
        }

        public Hero GetHeroWithHighestStrength()
        {
            return this.data.First(x => x.Item.Strength == this.data.Max(y => y.Item.Strength));
        }

        public Hero GetHeroWithHighestAbility()
        {
            return this.data.First(x => x.Item.Ability == this.data.Max(y => y.Item.Ability));
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            return this.data.First(x => x.Item.Intelligence == this.data.Max(y => y.Item.Intelligence));
        }

        public override string ToString()
        {
            string all = "";
            for (int i = 0; i < this.Count; i++)
            {
                all += this.data[i].ToString();
                if (i != this.Count - 1)
                {
                    all += '\n';
                }
            }
            return all;
        }

    }
}
