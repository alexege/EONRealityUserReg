using EONRealityUserReg.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using EONRealityUserReg.Models;


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
                
                //List<CheckboxModel> list_of_days = new List<CheckboxModel>();

                //CheckboxModel day1 = new CheckboxModel(1, "Day1", true);
                //CheckboxModel day2 = new CheckboxModel(2, "Day2", true);
                //CheckboxModel day3 = new CheckboxModel(3, "Day3", true);

                //list_of_days.Add(day1);
                //list_of_days.Add(day2);


                context.User.AddRange(
                    new User
                    {
                        Name = "Alexander Ege",
                        Email = "Alexander@Ege.com",
                        Gender = "M",
                        DateRegistered = DateTime.ParseExact("24/10/2019", "dd/MM/yyyy", null),
                        //Days =  list_of_days,
                        Days = "Day1, Day2",
                        Requests = "None"
                    },

                    new User
                    {
                        Name = "Stephen Kaatz",
                        Email = "Stephen@K.com",
                        Gender = "M",
                        DateRegistered = DateTime.ParseExact("24/04/2019", "dd/MM/yyyy", null),
                        Days = "Day2, Day3",
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
                ); ;
                context.SaveChanges();
            }
        }
    }
}
