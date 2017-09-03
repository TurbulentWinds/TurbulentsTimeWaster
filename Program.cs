using System;
using System.Windows.Forms;

namespace Turbulent_s_Time_Waster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************\n*  Turbulent's Time Waster 1.0 *\n********************************");

            while (true)
            {
                if (!Functions.WriteOrderToConsole())
                {

                    bool loop = true;

                    while (loop)
                    {
                        var result = MessageBox.Show("Time Not Wasted", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                        if (result == DialogResult.No)
                        {
                            loop = false;
                        }
                    }
                }
            }
        }
    }
}

