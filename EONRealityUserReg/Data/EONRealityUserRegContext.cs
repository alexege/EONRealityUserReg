using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EONRealityUserReg.Models;

namespace EONRealityUserReg.Data
{
    public class EONRealityUserRegContext : DbContext
    {
        public EONRealityUserRegContext (DbContextOptions<EONRealityUserRegContext> options)
            : base(options)
        {
        }

        public DbSet<EONRealityUserReg.Models.User> User { get; set; }
    }
}
