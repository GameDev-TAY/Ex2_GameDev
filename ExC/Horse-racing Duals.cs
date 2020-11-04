using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<int> numberOfHorses = new List<int>();
        //get all strength in to list
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            numberOfHorses.Add(pi);
        }
        List<int> orderedHorses = numberOfHorses.OrderByDescending(j => j).ToList(); 

        int smallestStrengthDiff = int.MaxValue;

        for (int i = 1; i < orderedHorses.Count; i++)
        {
            //Checks close pairs. If a smaller difference is found update.
            if (orderedHorses[i - 1] - orderedHorses[i] < smallestStrengthDiff)
            {
                smallestStrengthDiff = orderedHorses[i - 1] - orderedHorses[i];
            }
        }

        Console.WriteLine(smallestStrengthDiff);
        Console.ReadLine();
    }
}