/*
 * (C) IES San Vicente 2020
 *
 * Calculates the average of a set of marks, until the user types “end”.
 */

using System;

public class Average
{
    public static void Main()
    {
        double markSum = 0, mark, markCount = 0, averageMark;
        string markText;

        Console.Write("Insert a mark: ");
        markText = Console.ReadLine();
        
        while (markText != "end")
        {
            mark = Convert.ToDouble(markText);
            markCount++;
            markSum += mark;

            Console.Write("Insert a mark: ");
            markText = Console.ReadLine();
        }

        if (markCount != 0)
        {
            averageMark = markSum / markCount;
            Console.WriteLine("The average is {0}.", averageMark);
        }
    }
}
