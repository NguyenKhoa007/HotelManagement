using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.UI
{
    internal class Utility
    {
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\n Press Enter to continue...");
            Console.ReadLine();
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }
        public static void Alertify(string msg, bool success)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
