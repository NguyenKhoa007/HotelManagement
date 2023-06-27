using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class Room
    {

        public int ID_Room { get; set; }
        public string TypeRoom { get; set; }
        public string State { get; set; }
         public decimal Price { get; set; }
    }
}
