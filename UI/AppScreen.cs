using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HotelManagement.UI
{
    internal class AppScreen
    {
        public static void Welcome()
        {
            Console.WriteLine("----Welcome to Hoang Gia Hotel----");
            Console.WriteLine("\n Press Login in account");
            Utility.PressEnterToContinue();
        }
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("------Hoang Gia Hotel------");
            Console.WriteLine("1.Customer Management");
            Console.WriteLine("2.Room Management");
            Console.WriteLine("3.Registration Management-Room Rental");
            Console.WriteLine("4.Service Management");
            Console.WriteLine("5.Logout");
        }
        public static int ProcessMenuOption()
        {
            int selectedNumber = 0;
            while (selectedNumber < 1 || selectedNumber > 6)
            {
                string numberInput = Utility.GetUserInput("Input option");
                try
                {
                    selectedNumber = Int32.Parse(numberInput);
                    continue;
                }
                catch (FormatException e)
                {
                    Utility.Alertify("Invalid input. " + e.Message, false);
                }
                DisplayMenu();
            }



            return selectedNumber;
        }
        public static void Customer()
        {
            Console.Clear();
            Console.WriteLine("\n Please input Customer ID Card:");
            int IdKH = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Please input Customer Name:");
            string NameKH = Console.ReadLine();
            Console.WriteLine("\n Please input Customer Gender:");
            string SexKH = Console.ReadLine();
            Console.WriteLine("\n Please input Customer Address:");
            string AddKH = Console.ReadLine();
            Console.WriteLine("\n Please input Customer Phone Number:");
            int SDTKH = Convert.ToInt32(Console.ReadLine());
            Console.Clear() ;
            Console.WriteLine("Please check again customer information");

            Utility.PressEnterToContinue();
            Console.WriteLine($"\n Customer ID Card:               " + IdKH);
            Console.WriteLine($"\n Customer Name:                  " + NameKH);
            Console.WriteLine($"\n Customer Gender:                " + SexKH);
            Console.WriteLine($"\n Customer Address:               " + AddKH);
            Console.WriteLine($"\n Customer Phone Number:          " + SDTKH);
        }
        public static void DisplayMenu1()
        {
            Console.Clear();
            Console.WriteLine("------Hoang Gia Hotel------");
            Console.WriteLine("1.Customer Management");
            Console.WriteLine("2.Room Management");
            Console.WriteLine("3.Registration Management-Room Rental");
            Console.WriteLine("4.Service Management");
            Console.WriteLine("5.Logout");
        }
    }
}
