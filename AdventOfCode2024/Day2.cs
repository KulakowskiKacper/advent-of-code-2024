using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class Day2
    {
        readonly FileData fileData = new();
        private int similarityScore = 0;

        public Day2()
        {
            DisplayResult();
        }

        private void CalculateSimilarityScore()
        {
            int count = 0;
            foreach(var valueLeft in fileData.valuesLeft)
            {
                count = 0;
                foreach(var valueRight in fileData.valuesRight)
                {
                    if (valueLeft == valueRight) count++;
                }
                similarityScore += count * valueLeft;
            }
        }

        private void DisplayResult()
        {
            CalculateSimilarityScore();
            System.Console.WriteLine(similarityScore);
        }
    }
}