using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSI2132.Models
{
    public class Room
    {
        public int Id { get; set; }
        public String Location { get; set; }
        public Double Price { get; set; }
        public String Amenities { get; set; }
        public String Capacity { get; set; }
        public String View { get; set; }
        public Boolean Extendible { get; set; }
        public Boolean Damages { get; set; }
        public int HotelId { get; set; }
    }
}
