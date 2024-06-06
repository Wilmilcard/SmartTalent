using Microsoft.EntityFrameworkCore;
using SmartTalent.Domain.Models;
using SmartTalent.Domain.Seed;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SmartTalent.Domain.DB
{
    public class SmartTalentContext : DbContext
    {
        public SmartTalentContext(DbContextOptions<SmartTalentContext> options) : base(options) { }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<DocType> DocTypes { get; set; }
        public DbSet<Favorites> favorites { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonBooking> PersonBookings { get; set; }
        public DbSet<RolType> RolTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
