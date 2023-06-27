using HotelManagement.Constant;
using HotelManagement.UI;

namespace HotelManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int selectedAppMenu = (int)AppMenu.Logout;

            AppScreen.Welcome();
            
            while (selectedAppMenu > 0 && selectedAppMenu < 6)
            {
                AppScreen.DisplayMenu();
                selectedAppMenu = AppScreen.ProcessMenuOption();
                switch (selectedAppMenu)
                {
                    case (int)AppMenu.CustomerManagement:
                        AppScreen.Customer();
                        Utility.PressEnterToContinue();

                        break;
                    case (int)AppMenu.RoomManagement:
                        break;
                    case (int)AppMenu.RegistrationManagement:
                        break;
                    case (int)AppMenu.ServiceManagement:
                        break;
                    case (int)AppMenu.Logout:
                        break;

                }
            }
        }
    }
}