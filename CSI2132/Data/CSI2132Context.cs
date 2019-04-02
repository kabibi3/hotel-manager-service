using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSI2132.Models;

namespace CSI2132.Models
{
    public class CSI2132Context : DbContext
    {
        public CSI2132Context (DbContextOptions<CSI2132Context> options)
            : base(options)
        {
        }

        public DbSet<CSI2132.Models.Hotel> Hotel { get; set; }

        public DbSet<CSI2132.Models.Room> Room { get; set; }
    }
}
