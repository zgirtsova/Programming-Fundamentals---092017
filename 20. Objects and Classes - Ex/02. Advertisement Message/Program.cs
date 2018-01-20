using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = GetPhrases();
            string[] events = GetEvents();
            string[] authors = GetAuthors();
            string[] cities = GetCities();

            Random rnd = new Random();
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int pI = rnd.Next(0, phrases.Length);
                int eI = rnd.Next(0, events.Length);
                int aI = rnd.Next(0, authors.Length);
                int cI = rnd.Next(0, cities.Length);
                Console.WriteLine($"{phrases[pI]} {events[eI]} {authors[aI]} - {cities[cI]}.");
            }
        }

        static string[] GetCities()
        {
            string[] ci = new string[5];
            ci[0] = "Burgas";
            ci[1] = "Sofia";
            ci[2] = "Plovdiv";
            ci[3] = "Varna";
            ci[4] = "Ruse";
            return ci;
        }
        static string[] GetAuthors()
        {
            string[] au = new string[8];
            au[0] = "Diana";
            au[1] = "Petya";
            au[2] = "Stella";
            au[3] = "Elena";
            au[4] = "Katya";
            au[5] = "Iva";
            au[6] = "Annie";
            au[7] = "Eva";

            return au;
        }
        static string[] GetEvents()
        {
            string[] ev = new string[6];
            ev[0] = "Now I feel good.";
            ev[1] = "I have succeeded with this product.";
            ev[2] = "Makes miracles. I am happy of the results!";
            ev[3] = "I cannot believe but now I feel awesome.";
            ev[4] = "Try it yourself, I am very satisfied.";
            ev[5] = "I feel great!";

            return ev;
        }
        static string[] GetPhrases()
        {
            string[] ph = new string[6];
            ph[0] = "Excellent product.";
            ph[1] = "Such a great product.";
            ph[2] = "I always use that product.";
            ph[3] = "Best product of its category.";
            ph[4] = "Exceptional product.";
            ph[5] = "I can’t live without this product.";

            return ph;
        }
    }
}
