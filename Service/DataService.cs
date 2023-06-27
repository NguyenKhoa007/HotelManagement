using HotelManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Service
{
    public class DataService : IDataService
    {
        public List<Customer> CustomerList { get; set; }
        public List<Room> RoomList { get; set; }
        public DataService() { 
            InitlizeData();
        }
        void InitlizeData()
        {
            RoomList = new List<Room>
            {
                new Room()
                {
                    ID_Room = 1,TypeRoom="SingleRoom",State="Default",Price =300
                },
                new Room()
                {
                    ID_Room = 2,TypeRoom="DoubleRoom",State="Default",Price =600
                },
                new Room()
                {
                    ID_Room = 3,TypeRoom="DeluxRoom",State="Default",Price =1000
                }
            };

    }
    }
    
   
    
}
