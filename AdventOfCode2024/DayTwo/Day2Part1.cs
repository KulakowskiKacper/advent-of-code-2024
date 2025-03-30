using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AdventOfCode2024.DayTwo
{
    public class Day2Part1
    {
        //variables to hold data
        readonly Day2FileData day2FileData = new();
        int safety = 0;
        readonly List<int> values = new();

        public Day2Part1()
        {
            DisplaySafety();
        }

        private void CalculateSafety()
        {
            //foreach loop to iterate through data
            foreach(var value in day2FileData.fileData)
            {
                //clear list at start of every iteration
                values.Clear();
                //fill list with data of current iteration
                for(int i = 0; i < value.Split(" ", StringSplitOptions.None).Length; i++)
                {
                    values.Add(Convert.ToInt32(value.Split(" ")[i]));
                }

                //New list to hold data in ascending order
                List<int> valuesAsc = values.OrderBy(x => x).ToList();
                
                //List to hold data in descending order
                List<int> valuesDesc = values.OrderByDescending(x => x).ToList();
                //Boolean variables to check if current data is correct
                bool isGood = false;
                bool isAscending = true;

                //If-else block to check if data is set in ascending or descending order
                if (values.SequenceEqual(valuesAsc)) isAscending = true;
                else isAscending = false;

                //Checking if raw data is in correct order
                if (isAscending && values.SequenceEqual(valuesAsc)) isGood = true;
                else if (!isAscending && values.SequenceEqual(valuesDesc)) isGood = true;
                else isGood = false;

                //Checking if difference between any indexes is greater than 4 or equal to 0
                for(int i = 0; i < values.Count - 1; i++)
                {
                    if (Math.Abs(values[i] - values[i + 1]) > 3) isGood = false;
                    if (values[i] == values[i + 1]) isGood = false;

                }
                //If everyting passes, safety increases by 1
                if (isGood)
                {
                    safety++;
                }
            }
        }

        private void DisplaySafety()
        {
            CalculateSafety();
            System.Console.WriteLine(safety);
        }
    }
}