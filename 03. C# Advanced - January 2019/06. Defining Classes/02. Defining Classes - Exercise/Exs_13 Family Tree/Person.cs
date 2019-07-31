namespace Exs_13_Family_Tree
{
    using System.Collections.Generic;
    
    public class Person
    {

        public Person(string data)
        {
            if(char.IsDigit(data[0]))
            {
                this.Birthday = data;
            }
            else
            {
                this.Name = data;
            }
        }

        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
        
        public string Name { get; set; }

        public string Birthday { get; set; }

    }
}
