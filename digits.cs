/*
 * (c) IES San Vicente 2020
 *
 * Calculates how many numbers of 1, 2, 3 or more digits are
 * entered by the user until he/she types “end”.
 */

using System;

class Digits
{
    static void Main()
    {
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, moreDigits = 0;

        Console.Write("Insert a number: ");
        string numberText = Console.ReadLine();

        while (numberText != "end")
        {
            int number = Convert.ToInt32(numberText);
            if (number != 0)
            {
                if (number / 10 == 0)
                    oneDigit++;
                else
                    if (number / 100 == 0)
                        twoDigits++;
                    else
                        if (number / 1000 == 0)
                            threeDigits++;
                        else
                            moreDigits++;
            }

            numberText = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
            oneDigit, twoDigits, threeDigits, moreDigits);
    }
}

