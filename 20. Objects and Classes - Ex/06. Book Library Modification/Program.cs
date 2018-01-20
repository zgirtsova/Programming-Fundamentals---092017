using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
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
        static void Main(string[] args) // 83/100
            // Проблема беше, че ако подаде системата същото име на книгата,
            // трябва да бъде презаписана датата! Няма го в условието, 
            //но по този начи проработи при мен.
        {
            int n = int.Parse(Console.ReadLine());
            var library = new Library()
            {
                Name = "Zoya",
                ListBooks = new List<Book> { }, // to do - read a book
            };

            for (int i = 0; i < n; i++)
            {
                Book book = ReadBookProp();
                library.ListBooks.Add(book);
            }

            var releaseDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            PrintBooks(library, releaseDate);

        }
        static Book ReadBookProp()
        {
            var input = Console.ReadLine().Split(' ');
            var book = new Book()
            {
                Title = input[0],
                Author = input[1],
                Publisher = input[2],
                ReleaseDate = DateTime.ParseExact(input[3], "d.M.yyyy", CultureInfo.InvariantCulture),
                ISBN = input[4],
                Price = double.Parse(input[5])
            };

            return book;
        }
        private static void PrintBooks(Library library, DateTime releaseDate)
        {
            List<Book> ordered = library.ListBooks.Where(g => g.ReleaseDate >= releaseDate)
                .OrderBy(p => p.ReleaseDate).ThenBy(x => x.Title).ToList();

            Console.WriteLine(string.Join("\r\n",
                ordered.Select(x => x.Title + $" -> {x.ReleaseDate:dd.MM.yyyy}")));

        }
    }
}
