using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> ListBooks { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var library = new Library()
            {
                Name = "Zoya",
                ListBooks = new List<Book> {}, // to do - read a book
            };

            for (int i = 0; i < n; i++)
            {
                Book book = ReadBookProp();
                library.ListBooks.Add(book);
            }
            PrintBooks(library);
        }
        static Book ReadBookProp()
        {
            var input = Console.ReadLine().Split(' ');
            var book = new Book()
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.ParseExact(input[3], "d.M.yyyy",CultureInfo.InvariantCulture),
                ISBN = input[4],
                Price = double.Parse(input[5])
            };

            return book;
        }
        private static void PrintBooks(Library library)
        {
            var ordered = library.ListBooks.GroupBy(x => x.Author)
              .Select(g => new
               {
                Author = g.Key,
                Prices = g.Sum(s => s.Price)
               })
              .OrderByDescending(x => x.Prices).ThenBy(x => x.Author).ToList();
            
            Console.WriteLine(string.Join("\r\n", 
                ordered.Select(x => x.Author + $" -> {x.Prices:f2}")));
            
        }
        // very good LINQ with Group by
    }
}
