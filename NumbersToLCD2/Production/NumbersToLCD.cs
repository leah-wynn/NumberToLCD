using System;
using System.Linq;
using System.Collections.Generic;



public class NumbersToLCD
{
    public NumbersToLCD()
    {

    }

    public string ToLCD(int number)
    {
        var numberLookup = new Dictionary<string, string[]> {
            {"1", new[] {"   ", "  |", "  |" }},
            {"2", new[] {" _ ", " _|", "|_ "}}
        };
        var newLine = "\n";
        var lineOne = "";
		var lineTwo = "";
        var lineThree = "";

            var digitArray = number.ToString().ToCharArray();
        foreach (char digit in digitArray)
				{
            lineOne += numberLookup[digit.ToString()][0];
                lineTwo += numberLookup[digit.ToString()][1];
				lineThree += numberLookup[digit.ToString()][2];
				}
        return lineOne + newLine + lineTwo + newLine + lineThree;
    }
}