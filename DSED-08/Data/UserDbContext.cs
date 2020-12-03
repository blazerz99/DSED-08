using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DSED_06_AdoptAPet.Models;

namespace DSED_06_AdoptAPet.Data
{
    public class UserDbContext : DbContext
    {
        //adding in the data tables im using
        public DbSet<User> User { get; set; }
        public DbSet<Dogs> Dogs { get; set; }
        public DbSet<Daycare> Daycare { get; set; }
        public DbSet<Appointment> Appointment { get; set; }

        // 2 constructor, one empty, other injects in DbContextOptions
        public UserDbContext(DbContextOptions<UserDbContext> options)
            : base(options)
        {

        }

        public UserDbContext()
        {

        }



    }
}
