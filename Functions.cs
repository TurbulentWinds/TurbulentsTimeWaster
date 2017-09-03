using System;

namespace Turbulent_s_Time_Waster
{

    public static class Functions
    {
        public static bool WriteOrderToConsole()
        {
            string possibleCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Random r = new Random();
            string keyToPress = possibleCharacters.Substring(r.Next(0, possibleCharacters.Length), 1);
            string textToDisplay = LineData.LoadDataFromLine(r.Next(0, LineData.NumberOfLines()));

            Console.WriteLine("\n\nPress " + keyToPress + " " + textToDisplay);

            if (ReadNextKey() == keyToPress)
                return true;
            else
                return false;

        }

        public static string ReadNextKey()
        {
            return Console.ReadKey().Key.ToString().ToUpper();
        }
    }
}


