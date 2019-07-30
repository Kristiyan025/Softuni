using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_02_Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string startArticle = Console.ReadLine();
            string[] properties = startArticle.Split(',').ToArray();
            var article = new Article(properties[0], properties[1].Remove(0,1), 
                                      properties[2].Remove(0,1));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandParts = command.Split(':').ToArray();
                string commandType = commandParts[0];
                string commandNewValue = commandParts[1].Remove(0, 1);
                switch (commandType)
                {
                    case "Edit":
                        article.Edit(commandNewValue);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(commandNewValue);
                        break;
                    case "Rename":
                        article.Rename(commandNewValue);
                        break;
                }
            }
            Console.WriteLine(article.ToString());

        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newName)
        {
            this.Title = newName;
        }

        public override string ToString()
        {
           return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
