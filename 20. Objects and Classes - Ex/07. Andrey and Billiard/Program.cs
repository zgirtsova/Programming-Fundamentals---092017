using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> entities = ReadEntities();
            List<Customer> cust = new List<Customer>();
            string line = Console.ReadLine();

            while (line != "end of clients")
            {
                var input = line.Split(new char[] { '-', ',' });
                if (entities.ContainsKey(input[1]))
                {
                    var item = cust.FirstOrDefault(o => o.Name == input[0]);
                    if (item != null)
                    {
                        cust.Where(o => o.Name == input[0]).ToList().
                            ForEach(o => { o.ShopList[input[1]] = double.Parse(input[2]);
                                o.Bill += entities[input[1]] * double.Parse(input[2]);
                            });
                    }
                    else
                    {
                        AddCustomers(entities, cust, input);
                    }
                }
                line = Console.ReadLine();
            }
            PrintCustomers(cust);
        }

        static void PrintCustomers(List<Customer> cust)
        {
            cust = cust.OrderBy(x => x.Name).ToList();
            double totalBill = 0;
            foreach (Customer cu in cust)
            {
                Console.WriteLine(cu.Name);
                foreach (KeyValuePair<string, double> item in cu.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {cu.Bill:F2}");
                totalBill += cu.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        static void AddCustomers(Dictionary<string, double> entities, List<Customer> cust, string[] input)
        {
            cust.Add(new Customer
            {
                Name = input[0],
                ShopList = new Dictionary<string, double>()
                        { { input[1], double.Parse(input[2])} },
                Bill = entities[input[1]] * double.Parse(input[2])

            });
        }

        static Dictionary<string, double> ReadEntities()
        {
            int n = int.Parse(Console.ReadLine());
            var entities = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                entities[input[0]] = double.Parse(input[1]);
            }
            return entities;
        }
    }
}
