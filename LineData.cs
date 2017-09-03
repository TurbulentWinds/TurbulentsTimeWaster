using System;
using System.IO;

namespace Turbulent_s_Time_Waster
{
    public static class LineData
    {
        public static string LoadDataFromLine(int lineNumber)
        {

            const string f = "gamedata.txt";

            using (StreamReader r = new StreamReader(f))
            {
                var lines = File.ReadAllLines(f);
                return Convert.ToString(lines[lineNumber]);
            }
        }

        public static int NumberOfLines()
        {
            const string f = "gamedata.txt";

            using (StreamReader r = new StreamReader(f))
            {
                var lines = File.ReadAllLines(f);
                return lines.Length;
            }
        }
    }
}


