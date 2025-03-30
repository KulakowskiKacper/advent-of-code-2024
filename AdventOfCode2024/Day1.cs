using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class Day1
    {
        //Read pairs of data into string array. Every index is "12345   12345"
        string[] values = File.ReadAllLines("C:\\Users\\Kacper\\Desktop\\C#\\AdventOfCode2024\\DayOneData.txt");
        //Create Lists to hold parsed data
        List<int> values1 = new();
        List<int> values2 = new();
        //Parse data with Split() method. String we are spliting is "   ", string on the left goes to list values1, string on the right goes to list values2
        public Day1()
        {
            DisplayResult();
        }

        //Declare variables to hold calculated distance, actual minimal value from list values1 and values2
        int distance = 0;
        int minValue1;
        int minValue2;
        private void ParseData()
        {
            foreach(var value in values)
            {
                values1.Add(Convert.ToInt32(value.Split("   ", StringSplitOptions.None)[0]));
                values2.Add(Convert.ToInt32(value.Split("   ", StringSplitOptions.None)[1]));
            }
        }

        private void CalculateDistance()
        {
            //Start loop, which goes until list is empty
            while(values1.Count > 0)
            {
                //Assign minimal values of both lists to respective variable
                minValue1 = values1.Min();
                minValue2 = values2.Min();
                //Calculate absolute value of subtraction of both values. Absolute, because may happen that value2 is higher than value1, which would go to negative number
                distance += Math.Abs(minValue1 - minValue2);
                //Remove calculated values from both of Lists
                values1.Remove(values1.Min());
                values2.Remove(values2.Min());
            }
        }
        private void DisplayResult()
        {
            ParseData();
            CalculateDistance();
            Console.WriteLine(distance);
        }
    }
}