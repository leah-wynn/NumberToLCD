using System;
using System.Collections.Generic;

namespace NumbersToLCD2.Production
{
    public class NumbersToLCD
    {
        string number;
        Dictionary<string, string> LineConverter;
        Dictionary<string, Dictionary<string, string>> IntConverter;
        string[] numberArray;



        public NumbersToLCD(string number)
        {
            this.number = number;
             LineConverter = new Dictionary<string, string>();
            AddValuesToLineConverter();
            IntConverter = new Dictionary<string, Dictionary<string, string >>();
            AddValuesToIntConverter();
        }

        public string TranslateToLCD()
        {
            foreach (string value in ImputArray())
            {
                return IntConverter[value]["Line1"] + IntConverter[value]

            }
            if (number == "12")
            {
                return IntConverter["1"][0] + IntConverter["2"][0] + "\n"
                    + IntConverter["1"][1] + IntConverter["2"][1] + "\n"
                    + IntConverter["1"][2] + IntConverter["2"][2];
            }
            return IntConverter[number][0] + "\n" + IntConverter[number][1] + "\n" + IntConverter[number][2];
        }

        public string[] ImputArray()
        {
            numberArray = new string[10];
            numberArray = number.Split();
            return numberArray;
        }

        public void AddValuesToLineConverter()
        {
            LineConverter.Add("twoLine1", " _ ");
            LineConverter.Add("twoLine2", " _|");
            LineConverter.Add("twoLine3", "|_ ");
            LineConverter.Add("threeLine1", " _ ");
            LineConverter.Add("threeLine2", " _|");
            LineConverter.Add("threeLine3", " _|");

        }
        public void AddValuesToIntConverter()
        {
            //refactoring to this new structure
            IntConverter.Add("1", new Dictionary<string, string>()
            {
                { "Line1", "   " }, {"Line2", "  |"}, {"Line2", "  |"}
            });
            //older structure
            IntConverter.Add("2", new string[] { LineConverter["twoLine1"], LineConverter["twoLine2"], LineConverter["twoLine3"] });
            IntConverter.Add("3", new string[] { LineConverter["threeLine1"], LineConverter["threeLine2"], LineConverter["threeLine3"] });
        }
  
    }
}
