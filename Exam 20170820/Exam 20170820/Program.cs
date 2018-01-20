using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_20170820
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // participants

            double techTeamMoney = 0;
            double theoryTeamMoney = 0;
            double practicalTeamMoney = 0;

            for (int i = 0; i < n; i++)
            {
                double distanceInMeters = double.Parse(Console.ReadLine()) * 1600;
                double cargoInKg = double.Parse(Console.ReadLine()) * 1000;
                string team = Console.ReadLine();                             

                double participantEarnedMoney = (cargoInKg * 1.5) - (0.7 * distanceInMeters * 2.5);

                switch (team)
                {
                    case "Technical":
                        techTeamMoney += participantEarnedMoney;
                        break;
                    case "Theoretical":
                        theoryTeamMoney += participantEarnedMoney;
                        break;
                    case "Practical":
                        practicalTeamMoney += participantEarnedMoney;
                        break;

                    default:
                        break;
                }               

            }
            if (techTeamMoney > theoryTeamMoney && techTeamMoney > practicalTeamMoney)
            {
                Console.WriteLine($"The Technical Trainers win with ${techTeamMoney:F3}.");
            }
            else if (theoryTeamMoney > techTeamMoney && theoryTeamMoney > practicalTeamMoney)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theoryTeamMoney:F3}.");
            }
            else if (practicalTeamMoney > techTeamMoney && practicalTeamMoney > theoryTeamMoney)
            {
                Console.WriteLine($"The Practical Trainers win with ${practicalTeamMoney:F3}.");
            }
        }
    }
}
