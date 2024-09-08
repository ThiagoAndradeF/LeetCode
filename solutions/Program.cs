using System;
using leetcode.Quests;
namespace leetcode;

class Program
{
    static void Main(string[] args)
    {
        var resultTwoSums = TwoSum.Calculate([2,5,5,11],10);
        foreach (var result in resultTwoSums)
        {
            Console.WriteLine(result);
        }
    }
}

