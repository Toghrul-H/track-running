using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int stnum = int.Parse(Console.ReadLine());
        int[] geton = new int[stnum];
        int[] getoff = new int[stnum];

        // Read input rows
        for (int i = 0; i < stnum; i++)
        {
            string[] row = Console.ReadLine().Split(" ");
            geton[i] = int.Parse(row[0]);
            getoff[i] = int.Parse(row[1]);
        }

        // PRE-condition check
        bool invalid = stnum < 1 || stnum > 100
                       || geton.Any(x => x < 0 || x > 50)
                       || getoff.Any(x => x < 0 || x > 50);

        if (invalid)
        {
            Console.WriteLine("Invalid");
            return;
        }

        // LINQ calculations
        int sumpsngr = getoff.Sum();
        int index = Array.IndexOf(geton, geton.Max()) + 1;

        // Output
        Console.WriteLine(sumpsngr);
        Console.WriteLine(index);
    }
}
