using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exs_03_Articles_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string startArticle = Console.ReadLine();
                string[] properties = startArticle.Split(',').ToArray();
                articles.Add(new Article(properties[0], properties[1].Remove(0, 1),
                                          properties[2].Remove(0, 1)));
            }
            string input = Console.ReadLine();
            switch (input)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;
            }
            foreach (var article in articles)
            {
                Console.WriteLine(article.ToString());
            }

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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
