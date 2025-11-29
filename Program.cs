using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int weeks = int.Parse(Console.ReadLine());
        int laps = int.Parse(Console.ReadLine());

        int[][] lapTimes = new int[weeks][];
        for (int i = 0; i < weeks; i++)
        {
            lapTimes[i] = Console.ReadLine()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToArray();
        }

        // PRE-condition check
        bool invalid = weeks < 1 || weeks > 10
                       || laps < 1 || laps > 10
                       || lapTimes.Any(week => week.Any(t => t < 30 || t > 60));

        if (invalid)
        {
            Console.WriteLine("Invalid");
            return;
        }

        // Decision-All Pattern
        bool isImproving = true;
        for (int i = 1; i < weeks; i++)
        {
            int previousTotal = lapTimes[i - 1].Sum();
            int currentTotal = lapTimes[i].Sum();

            if (!(currentTotal < previousTotal))
            {
                isImproving = false;
                break;
            }
        }

        Console.WriteLine(isImproving.ToString().ToLower());
    }
}
