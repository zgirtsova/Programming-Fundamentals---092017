using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Sale> salesList = ReadSales();
            SortedDictionary<string, decimal> salesDict = FillSalesDict(salesList);
            PrintSalesDict(salesDict);
        }

        static void PrintSalesDict(SortedDictionary<string, decimal> salesDict)
        {
            Console.WriteLine(string.Join("\r\n", salesDict.Select(s => $"{s.Key} -> {s.Value:f2}")));                       
        }

        static SortedDictionary<string, decimal> FillSalesDict(List<Sale> salesList)
        {
            var saleDict = new SortedDictionary<string, decimal>();
            for (int i = 0; i < salesList.Count; i++)
            {
                string town = salesList[i].Town;
                if (saleDict.ContainsKey(town))
                {
                    saleDict[town] += salesList[i].Price * salesList[i].Quantity;
                }
                else
                {
                    saleDict[town] = salesList[i].Price * salesList[i].Quantity;
                }
            }
            return saleDict;
        }

        static List<Sale> ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            var sales = new List<Sale>();
            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();
                sales.Add(new Sale());
                sales[i].Town = input[0];
                sales[i].Product = input[1];
                sales[i].Price = decimal.Parse(input[2]);
                sales[i].Quantity = decimal.Parse(input[3]);
            }
            return sales;
        }
    }
}
