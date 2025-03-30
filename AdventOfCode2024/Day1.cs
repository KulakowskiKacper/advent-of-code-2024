using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class Day1Part1
    {
        DayOneFileData fileData = new();
        //Read pairs of data into string array. Every index is "12345   12345"
        // string[] values = FileData.fileData;
        // //Create Lists to hold parsed data
        // protected List<int> valuesLeft = new();
        // protected List<int> valuesRight = new();
        //Parse data with Split() method. String we are spliting is "   ", string on the left goes to list values1, string on the right goes to list values2
        public Day1Part1()
        {
            DisplayResult();
        }

        //Declare variables to hold calculated distance, actual minimal value from list values1 and values2
        int distance = 0;
        int minValue1;
        int minValue2;
        // protected virtual void ParseData()
        // {
        //     foreach(var value in values)
        //     {
        //         valuesLeft.Add(Convert.ToInt32(value.Split("   ", StringSplitOptions.None)[0]));
        //         valuesRight.Add(Convert.ToInt32(value.Split("   ", StringSplitOptions.None)[1]));
        //     }
        // }

        protected virtual void CalculateDistance()
        {
            //Start loop, which goes until list is empty
            while(fileData.valuesLeft.Count > 0)
            {
                //Assign minimal values of both lists to respective variable
                minValue1 = fileData.valuesLeft.Min();
                minValue2 = fileData.valuesRight.Min();
                //Calculate absolute value of subtraction of both values. Absolute, because may happen that value2 is higher than value1, which would go to negative number
                distance += Math.Abs(minValue1 - minValue2);
                //Remove calculated values from both of Lists
                fileData.valuesLeft.Remove(fileData.valuesLeft.Min());
                fileData.valuesRight.Remove(fileData.valuesRight.Min());
            }
        }
        protected virtual void DisplayResult()
        {
            //ParseData();
            CalculateDistance();
            Console.WriteLine(distance);
        }
    }
}