using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace PFExam_2017_11_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal key = decimal.Parse(Console.ReadLine());
            decimal totalLoss = 0;
            List<string> sites = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var siteName = input[0];

                var siteVisits = decimal.Parse(input[1]);
                //Console.WriteLine(siteVisits);

                var siteCommercialPricePerVisit = decimal.Parse(input[2]);
                //Console.WriteLine(siteCommercialPricePerVisit);

                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                //Console.WriteLine(siteLoss);

                totalLoss += siteLoss;
                sites.Add(siteName);
            }
            Console.WriteLine(string.Join("\r\n", sites));
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            decimal securityToken = 1;
            for (int i = 0; i < sites.Count; i++)
            {
                securityToken =  securityToken * key;

            }
            Console.WriteLine("Security Token: "+ securityToken);
        }
        
    }
}
