using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2024.DayTwo
{
    public class Day2FileData
    {
        //variable to hold data sets as "x y z a b c"
        public List<string> fileData = File.ReadAllLines("C:\\Users\\Kacper\\Desktop\\C#\\AdventOfCode2024\\DataFiles\\DayTwoData.txt").ToList();
    }
}