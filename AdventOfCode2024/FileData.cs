using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class FileData
    {
        public FileData()
        {
            ParseData();
        }
        public string[] fileData = File.ReadAllLines("C:\\Users\\Kacper\\Desktop\\C#\\AdventOfCode2024\\DayOneData.txt");

        public List<int> valuesLeft = new();
        public List<int> valuesRight = new();

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