using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> frequences = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < frequences.Count; i++)
            {
                Console.Beep((int)frequences[i], 1000);

            }

            List<string> notes = new List<string>();
            string neutrals = "";
            string sharps = "";
            double sumNeutrals = 0.0;
            double sumSharps = 0.0;

            for (int i = 0; i < frequences.Count; i++)
            {
                if (frequences[i] == 261.63)
                {
                    notes.Add("C");
                    sumNeutrals += frequences[i];
                }
                else if (frequences[i] == 277.18)
                {
                    notes.Add("C#");
                    sumSharps += frequences[i];
                }
                else if (frequences[i] == 293.66)
                {
                    notes.Add("D");
                    sumNeutrals += frequences[i];
                }
                else if (frequences[i] == 311.13)
                {
                    notes.Add("D#");
                    sumSharps += frequences[i];
                }
                else if (frequences[i] == 329.63)
                {
                    notes.Add("E");
                    sumNeutrals += frequences[i];
                }
                else if (frequences[i] == 349.23)
                {
                    notes.Add("F");
                    sumNeutrals += frequences[i];
                }
                else if (frequences[i] == 369.99)
                {
                    notes.Add("F#");
                    sumSharps += frequences[i];
                }
                else if (frequences[i] == 392.00)
                {
                    notes.Add("G");
                    sumNeutrals += frequences[i];
                }
                else if (frequences[i] == 415.30)
                {
                    notes.Add("G#");
                    sumSharps += frequences[i];
                }
                else if (frequences[i] == 440.00)
                {
                    notes.Add("A");
                    sumNeutrals += frequences[i];
                }
                else if (frequences[i] == 466.16)
                {
                    notes.Add("A#");
                    sumSharps += frequences[i];
                }
                else if (frequences[i] == 493.88)
                {
                    notes.Add("B");
                    sumNeutrals += frequences[i];
                }

            }
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Contains("#"))
                {
                    sharps += notes[i] + ", ";
                }
                else
                {
                    neutrals += notes[i] + ", ";
                }
            }
            Console.WriteLine("Notes: " + string.Join(" ", notes));
            Console.WriteLine("Naturals: " + neutrals.TrimEnd().Trim(','));
            Console.WriteLine("Sharps: " + sharps.TrimEnd().Trim(','));
            Console.WriteLine("Naturals sum: " + sumNeutrals);
            Console.WriteLine("Sharps sum: " + sumSharps);

        }
    }
}
    
