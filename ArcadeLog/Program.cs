using System;
using System.Collections.Generic;
using System.IO;

namespace ArcadeLog
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Lê o ficheiro e cria os Scores
            List<Score> scores = new List<Score>();

            foreach (string line in File.ReadAllLines(args[0]))
            {
                string[] parts = line.Split(' ');

                string name = parts[0];
                int points = int.Parse(parts[1]);

                scores.Add(new Score(name, points));
            }

            // Ordena por Pontos
            scores.Sort();

            // Imprime e guarda ranking.txt
            List<string> ranking = new List<string>();

            foreach (Score score in scores)
            {
                Console.WriteLine(score);
                ranking.Add(score.ToString());
            }

            File.WriteAllLines("ranking.txt", ranking);

            Console.WriteLine("Ranking guardado em 'ranking.txt'.");

            // Ordena por Nome
            scores.Sort((a, b) => a.Name.CompareTo(b.Name));

            // Guarda alpha.txt
            List<string> alpha = new List<string>();

            foreach (Score score in scores)
            {
                alpha.Add(score.ToString());
            }

            File.WriteAllLines("alpha.txt", alpha);
        }
    }
}