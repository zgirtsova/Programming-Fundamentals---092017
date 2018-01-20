using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(':');
            var playersDictValues = new Dictionary<string, int>();
            var playersDictCards = new Dictionary<string, string>();
            var powerP = PowerDictionary(); // mapping of powers
            var multipliers = MultiplyDict(); // mapping of multipliers
            
            while (input[0] != "JOKER")
            {
                string player = input[0];
                if (playersDictValues.ContainsKey(player))
                {
                    // int rowValue = SumCardsRow(playersDictValues, powerP, player, input[1],multipliers);
                    playersDictValues[player] = 0;
                    playersDictCards[player] += input[1] + " ";
                }
                else
                {
                    playersDictValues[player] = 0;
                    playersDictCards[player] = input[1] + " ";
                }
                input = Console.ReadLine().Split(':');
            }
            foreach (var pl in playersDictCards)
            {
                int rowValue = SumCardsRow(playersDictValues, powerP, pl.Key, pl.Value, multipliers);
                playersDictValues[pl.Key] += rowValue;
            }
            
            Console.WriteLine(string.Join("\r\n", playersDictValues.
                Select(x => x.Key + ": " + x.Value)));
        }

        static Dictionary<string, int> MultiplyDict()
        {
            var multipliers = "C D H S".Split(' ');
            var multipDict = multipliers.ToDictionary(x => x, x => 0);
            for (int i = 0; i < multipliers.Length; i++)
            {
                multipDict[multipliers[i]] = i + 1;
            }
            return multipDict;
        }

        static int SumCardsRow(Dictionary<string, int> dict,
            Dictionary<string, int> powerP, string player, string v,
            Dictionary<string, int> multipliers)
        {
            var cards = v.Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();                        
            int totalValue = 0;
            for (int i = 0; i < cards.Count; i++)
            {
                int cardValue = 0;
                if (cards[i].Length == 2)
                {
                    int power = powerP[cards[i][0].ToString()];
                    int multiply = multipliers[cards[i][1].ToString()];
                    cardValue = power * multiply;
                    totalValue += cardValue;
                }
                else
                {
                    int power = 10;
                    int multiply = multipliers[cards[i][2].ToString()];
                    cardValue = power * multiply;
                    totalValue += cardValue;
                }
            }
            return totalValue;
        }

        static Dictionary<string, int> PowerDictionary() 
        {
            var power = "2 3 4 5 6 7 8 9 10 J Q K A".Split(' ');
            var powerP = power.ToDictionary(x => x, x => 0);
            for (int i = 0, value = 2; i<power.Length; i++, value++)
            {
                powerP[power[i]] = value;
            }
            return powerP;
        }
    }
}
