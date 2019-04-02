using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI2132.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public String ParentChain { get; set; }
        public String Location { get; set; }
        public int Rating { get; set; }
        public String NumberOfRooms { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        
    }
}
