using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CSI2132.Models
{
    public static class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CSI2132Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CSI2132Context>>()))
            {
                if (context.Room.Any())
                {
                       //return;   // DB has been seeded
                }
                string[] chains = { "Best Western", "Holiday Inn", "Mariott", "Super 8", "Ramada", "Hilton" };
                string[] locations = { "Toronto", "Ottawa", "Vancouver", "New York" };
                for (int x = 1; x < 10; x++)
                {
                    context.Hotel.AddRange(
                    new Hotel
                    {
                        ParentChain = chains[x % chains.Length],
                        Location = locations[x % locations.Length],
                        Rating = 3,
                        NumberOfRooms = "150",
                        Address = "343 Trenton Dr.",
                        Email = "@gmail.com",
                        PhoneNumber = "555-555-5555"
                    }
                );
                }

                string[] amenities = { "Kitchen", "Internet", "TV","Pool","Gym" };
                string[] capacity = { "double","single" };
                string[] view = { "Mountain","City","Ocean" };
                /*for (int x = 1; x < 10; x++)
                {
                    context.Room.AddRange(
                    new Room
                    {
                        Price = Math.Round(x*Math.PI,2),
                        Amenities = amenities[x%amenities.Length],
                        Capacity = capacity[x%capacity.Length],
                        View = view[x%view.Length],
                        Extendible = false,
                        Damages = true,
                        Location = locations[x%locations.Length]
                    }
                );
                }*/
                context.SaveChanges();
            }
        }
    }
}