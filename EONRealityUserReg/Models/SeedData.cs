using EONRealityUserReg.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EONRealityUserReg.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EONRealityUserRegContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EONRealityUserRegContext>>()))
            {
                // Look for any Users.
                if (context.User.Any())
                {
                    Console.WriteLine("DB has been seeded");
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        Name = "Alexander Ege",
                        Email = "Alexander@Ege.com",
                        Gender = "M",
                        DateRegistered = DateTime.ParseExact("24/10/2019", "dd/MM/yyyy", null),
                        Days = "Day1, Day2",
                        Requests = "None"
                    },

                    new User
                    {
                        Name = "Stephen Kaatz",
                        Email = "Stephen@K.com",
                        Gender = "M",
                        DateRegistered = DateTime.ParseExact("24/04/2019", "dd/MM/yyyy", null),
                        Days = "Day1, Day2, Day3",
                        Requests = "Private Room"
                    },

                    new User
                    {
                        Name = "Jane Doe",
                        Email = "JaneDoe@gmail.com",
                        Gender = "F",
                        DateRegistered = DateTime.ParseExact("21/10/2019", "dd/MM/yyyy", null),
                        Days = "Day1",
                        Requests = "Bringing a plus one."

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
