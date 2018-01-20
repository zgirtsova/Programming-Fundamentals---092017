using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double differenceInPercent = GetPercentageDifference(lastPrice, currentPrice);
                bool isSignificantDifference = isDiff(differenceInPercent, treshold);

                string message = Get(currentPrice, lastPrice, differenceInPercent, isSignificantDifference);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string Get(double currentPrice, double last, double change, bool eitherTrueOrFalse)
        {
            string result = "";
            if (change == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!eitherTrueOrFalse)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, currentPrice, change * 100);
            }
            else if (eitherTrueOrFalse && (change > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, currentPrice, change * 100);
            }
            else if (eitherTrueOrFalse && (change < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, currentPrice, change * 100);
            return result;
        }
        private static bool isDiff(double treshold, double isDiff)
        {
            if (Math.Abs(treshold) >= isDiff)
            {
                return true;
            }
            return false;
        }
        private static double GetPercentageDifference(double lastPrice, double currentPrice)
        {
            double result = (currentPrice - lastPrice) / lastPrice;
            return result;
        }
    }
}
