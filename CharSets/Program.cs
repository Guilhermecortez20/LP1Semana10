using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<char> allChars = new HashSet<char>();

            foreach (string file in args)
            {
                if (File.Exists(file))
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            allChars.Add(line[0]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Ficheiro '{file}' não encontrado.");
                }
            }

            List<char> sortedChars = allChars.ToList();
            sortedChars.Sort();

            foreach (char c in sortedChars)
            {
                Console.WriteLine(c);
            }
        }
    }
}
