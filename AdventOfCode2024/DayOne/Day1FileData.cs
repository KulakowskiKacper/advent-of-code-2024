using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class DayOneFileData
    {
        //Variable to hold data from file
        public string[] fileData = File.ReadAllLines("C:\\Users\\Kacper\\Desktop\\C#\\AdventOfCode2024\\DataFiles\\DayOneData.txt");
        //Lists to hold parsed data
        public List<int> valuesLeft = new();
        public List<int> valuesRight = new();
        public DayOneFileData()
        {
            ParseData();
        }

        //Parse data with Split() method. String we are spliting is "   ", string on the left goes to list values1, string on the right goes to list values2
        public void ParseData()
        {
            foreach(var value in fileData)
            {
                valuesLeft.Add(Convert.ToInt32(value.Split("   ", StringSplitOptions.None)[0]));
                valuesRight.Add(Convert.ToInt32(value.Split("   ", StringSplitOptions.None)[1]));
            }
        }
    }
}