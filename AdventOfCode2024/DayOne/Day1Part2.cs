using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class Day1Part2
    {
        readonly DayOneFileData fileData = new();
        //declare variable to hold output
        private int similarityScore = 0;

        public Day1Part2()
        {
            DisplayResult();
        }

        private void CalculateSimilarityScore()
        {
            //Variable to hold count of apperances of left number in right list
            int count = 0;
            foreach(var valueLeft in fileData.valuesLeft)
            {
                //Zero the count after every iteration of left list
                count = 0;
                foreach(var valueRight in fileData.valuesRight)
                {
                    //if left value is equal to right value, increase count by one
                    if (valueLeft == valueRight) count++;
                }
                //To similarity score add multiplication of count of value with itself
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