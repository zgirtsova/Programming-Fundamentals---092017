using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var VenueSingerAndTotalMoney = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "End") break;
                string[] inputData = text.Trim().Split(' ').ToArray();

                //check if input is correct
                string[] checkData = text.Split(new char[] { ' ', '@' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputData.Length != checkData.Length) continue;

                int indexSign = 0;
                //Check where in the text is '@' sign
                indexSign = DefineIndexPosition(inputData, indexSign);

                //Check the Singer Name is valid
                if (indexSign <= 1 || indexSign >= 5) continue;
                if (inputData.Length - indexSign >= 5 || inputData.Length - indexSign < 2) continue;

                //Define Singer Name
                string singerName = DefineSingerName(inputData, indexSign);

                //Check the input data for values of ticketsPrice and ticketsCount
                int ticketsPrice;
                int ticketsCount;
                try
                {
                    //Define ticketsPrice
                    ticketsPrice = int.Parse(inputData[inputData.Length - 2]);

                    //Define ticketsCount
                    ticketsCount = int.Parse(inputData[inputData.Length - 1]);
                }
                catch
                {
                    continue;
                }

                //Define venue
                string venue = DefineVenue(checkData, indexSign);

                long currentAmountOfMoney = (long)ticketsPrice * ticketsCount;

                DefineTheDictionary(VenueSingerAndTotalMoney, singerName, venue, currentAmountOfMoney);
            }
            PrintTheDictionary(VenueSingerAndTotalMoney);
        }

        private static void DefineTheDictionary(Dictionary<string, Dictionary<string, long>> VenueSingerAndTotalMoney, string singerName, string venue, long currentAmountOfMoney)
        {
            if (VenueSingerAndTotalMoney.ContainsKey(venue))
            {
                Dictionary<string, long> CurrentVenue = VenueSingerAndTotalMoney[venue];
                if (CurrentVenue.ContainsKey(singerName))
                {
                    CurrentVenue[singerName] += currentAmountOfMoney;
                }
                else CurrentVenue[singerName] = currentAmountOfMoney;
            }
            else
            {
                Dictionary<string, long> newVenue = new Dictionary<string, long>();
                newVenue[singerName] = currentAmountOfMoney;
                VenueSingerAndTotalMoney.Add(venue, newVenue);
            }
        }

        private static void PrintTheDictionary(Dictionary<string, Dictionary<string, long>> VanueSignerAndTotalMoney)
        {
            foreach (var pair in VanueSignerAndTotalMoney)
            {
                Console.WriteLine(pair.Key);
                var OrderedSignerAndTotalMoney = pair.Value.OrderByDescending(i => i.Value);
                foreach (var value in OrderedSignerAndTotalMoney)
                {
                    Console.WriteLine($"#  {value.Key} -> {value.Value}");
                }
            }
        }

        private static string DefineVenue(string[] checkData, int indexSign)
        {
            string[] venues = new string[checkData.Length - indexSign];
            for (int i = indexSign - 1; i < checkData.Length - 2; i++)
            {
                venues[i - indexSign + 1] = checkData[i];
            }
            string venue = string.Join(" ", venues);
            return venue;
        }

        private static string DefineSingerName(string[] inputData, int indexSign)
        {
            string[] singerNameData = new string[indexSign - 1];
            for (int i = 0; i < indexSign - 1; i++)
            {
                singerNameData[i] = inputData[i];
            }
            string singerName = string.Join(" ", singerNameData);
            return singerName;
        }

        private static int DefineIndexPosition(string[] inputData, int indexSign)
        {
            foreach (var str in inputData)
            {
                indexSign++;
                if (str.Contains('@')) break;
            }

            return indexSign;
        }
    }
}
