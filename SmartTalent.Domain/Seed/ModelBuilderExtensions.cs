using Bogus.Extensions.Sweden;
using Microsoft.EntityFrameworkCore;
using SmartTalent.Domain.Models;
using SmartTalent.Domain.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogus.DataSets.Name;

namespace SmartTalent.Domain.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var random = new Random();
            var _CratedBy = "ApiNet";
            var _CreatedAt = DateTime.UtcNow.AddHours(-5);
            var id = 1;
            var startYear = new DateTime(2024, 1, 1);

            #region RolType
            modelBuilder.Entity<RolType>().HasData(
                new RolType
                {
                    RolTypeId = 1,
                    Name = "Administrador",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new RolType
                {
                    RolTypeId = 2,
                    Name = "Cliente",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

            #region RoomType
            modelBuilder.Entity<RoomType>().HasData(
                new RoomType
                {
                    RoomTypeId = 1,
                    Name = "Basica",
                    ValuePerNight = 45000,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new RoomType
                {
                    RoomTypeId = 2,
                    Name = "Premium",
                    ValuePerNight = 90000,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new RoomType
                {
                    RoomTypeId = 3,
                    Name = "Deluxe",
                    ValuePerNight = 150000,
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

            #region DocType
            modelBuilder.Entity<DocType>().HasData(
                new DocType
                {
                    DocTypeId = 1,
                    Name = "Cedula Ciudadania",
                    type = "C.C.",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new DocType
                {
                    DocTypeId = 2,
                    Name = "Pasaporte",
                    type = "PP",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new DocType
                {
                    DocTypeId = 3,
                    Name = "Tarjeta Identidad",
                    type = "T.I.",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new DocType
                {
                    DocTypeId = 4,
                    Name = "NIT",
                    type = "NIT",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new DocType
                {
                    DocTypeId = 5,
                    Name = "Cedula Extranjeria",
                    type = "C.E.",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

            #region City
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    CityId = 1,
                    Name = "Bogota D.C.",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new City
                {
                    CityId = 2,
                    Name = "Medellin",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new City
                {
                    CityId = 3,
                    Name = "Pereira",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new City
                {
                    CityId = 4,
                    Name = "Barranquilla",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                },
                new City
                {
                    CityId = 5,
                    Name = "Ibague",
                    CreatedAt = _CreatedAt,
                    CreatedBy = _CratedBy
                });
            #endregion

            #region Hotel
            id = 1;
            var fakerHotel = new Bogus.Faker<Hotel>()
                .RuleFor(x => x.HotelId, f => id++)
                .RuleFor(x => x.Name, f => $"Hotel {f.Address.StreetName()}")
                .RuleFor(x => x.Availability, f => f.Random.Bool())
                .RuleFor(x => x.CityId, f => f.Random.Number(1,5))
                .RuleFor(x => x.CreatedAt, _CreatedAt)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var h in fakerHotel.Generate(25))
                modelBuilder.Entity<Hotel>().HasData(h);
            #endregion

            #region Room
            id = 1;
            string st = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var fakerRoom = new Bogus.Faker<Room>()
                .RuleFor(x => x.RoomId, f => id++)
                .RuleFor(x => x.RoomNumber, f => $"{st.Substring(random.Next(1,26),1).ToUpper()}{random.Next(99)}")
                .RuleFor(x => x.Availability, f => f.Random.Bool())
                .RuleFor(x => x.MaxGuest, f => f.Random.Number(1, 4))
                .RuleFor(x => x.HotelId, f => f.Random.Number(1, 25))
                .RuleFor(x => x.RoomTypeId, f => f.Random.Number(1, 3))
                .RuleFor(x => x.CreatedAt, _CreatedAt)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var r in fakerRoom.Generate(100))
                modelBuilder.Entity<Room>().HasData(r);
            #endregion

            #region Person
            id = 1;
            var fakerPerson = new Bogus.Faker<Person>()
                .RuleFor(x => x.PersonId, f => id++)
                .RuleFor(x => x.FirstName, f => f.Person.FirstName)
                .RuleFor(x => x.LastName, f => f.Person.LastName)
                .RuleFor(x => x.Birth, f => f.Person.DateOfBirth)
                .RuleFor(x => x.Gender, f => (char)random.Next('F', 'M'))
                .RuleFor(x => x.Document, f => f.Person.Personnummer())
                .RuleFor(x => x.Email, f => f.Person.Email)
                .RuleFor(x => x.Phone, f => f.Person.Phone)
                .RuleFor(x => x.EmergencyContact, f => f.Name.FindName())
                .RuleFor(x => x.EmergencyPhone, f => f.Person.Phone)
                .RuleFor(x => x.DocTypeId, f => f.Random.Number(1, 5))
                .RuleFor(x => x.RolTypeId, f => 2)
                .RuleFor(x => x.CreatedAt, _CreatedAt)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var p in fakerPerson.Generate(100))
                modelBuilder.Entity<Person>().HasData(p);
            #endregion

            #region Favorites
            id = 1;
            var fakerFavorite = new Bogus.Faker<Favorites>()
                .RuleFor(x => x.FavoritesId, f => id++)
                .RuleFor(x => x.RoomId, f => f.Random.Number(1, 100))
                .RuleFor(x => x.PersonId, f => f.Random.Number(1, 100))
                .RuleFor(x => x.CreatedAt, _CreatedAt)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var f in fakerFavorite.Generate(100))
                modelBuilder.Entity<Favorites>().HasData(f);
            #endregion

            #region Booking
            id = 1;
            var fakerBooking = new Bogus.Faker<Booking>()
                .RuleFor(x => x.BookingId, f => id++)
                .RuleFor(x => x.Code, f => f.Finance.Bic().ToUpper().Substring(1,6))
                .RuleFor(x => x.StarDate, f => startYear.AddDays(random.Next(1, 365)))
                .RuleFor(x => x.EndDate, (f, x) => x.StarDate.AddDays(random.Next(2, 10)))
                .RuleFor(x => x.Availability, f => f.Random.Bool())
                .RuleFor(x => x.TotalGuest, f => random.Next(1,4))
                .RuleFor(x => x.RoomId, f => f.Random.Number(1, 100))
                .RuleFor(x => x.PersonId, f => f.Random.Number(1, 100))
                .RuleFor(x => x.CreatedAt, _CreatedAt)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var b in fakerBooking.Generate(100))
                modelBuilder.Entity<Booking>().HasData(b);
            #endregion

            #region PersonBooking
            id = 1;
            var fakerPersonBooking = new Bogus.Faker<PersonBooking>()
                .RuleFor(x => x.PersonBookingId, f => id++)
                .RuleFor(x => x.BookingId, f => f.Random.Number(1, 100))
                .RuleFor(x => x.PersonId, f => f.Random.Number(1, 100))
                .RuleFor(x => x.CreatedAt, _CreatedAt)
                .RuleFor(x => x.CreatedBy, _CratedBy);

            foreach (var pb in fakerPersonBooking.Generate(250))
                modelBuilder.Entity<PersonBooking>().HasData(pb);
            #endregion

            #region Admins System
            modelBuilder.Entity<User>().HasData(
              new User
              {
                  UserId = 1,
                  Username = "ADMIN",
                  PasswordHash = Encrypt.MD5("1234"),
                  AccessFailCount = 0,
                  IsAdmin = true,
                  IsActive = true,
                  CreatedAt = _CreatedAt,
                  CreatedBy = _CratedBy
              },
              new User
              {
                  UserId = 2,
                  Username = "SMART",
                  PasswordHash = Encrypt.MD5("1234"),
                  AccessFailCount = 0,
                  IsAdmin = false,
                  IsActive = true,
                  CreatedAt = _CreatedAt,
                  CreatedBy = _CratedBy
              });

            modelBuilder.Entity<Person>().HasData(
              new Person
              {
                  PersonId = 101,
                  FirstName = "Administrador",
                  LastName = "Sistema",
                  Birth = _CreatedAt.AddYears(-20),
                  DocTypeId = 1,
                  Document = "1010101010",
                  Email = "admin@email.com",
                  EmergencyContact = "N/A",
                  EmergencyPhone = "N/A",
                  Gender = 'M',
                  Phone = "10101010101",
                  RolTypeId = 1,
                  UserId = 1,
                  CreatedAt = _CreatedAt,
                  CreatedBy = _CratedBy
              },
              new Person
              {
                  PersonId = 102,
                  FirstName = "Smart",
                  LastName = "Talent",
                  Birth = _CreatedAt.AddYears(-35).AddMonths(-6).AddDays(-35),
                  DocTypeId = 3,
                  Document = "102102120102",
                  Email = "smart@email.com",
                  EmergencyContact = "N/A",
                  EmergencyPhone = "N/A",
                  Gender = 'F',
                  Phone = "102102102102",
                  RolTypeId = 2,
                  UserId = 2,
                  CreatedAt = _CreatedAt,
                  CreatedBy = _CratedBy
              });
            #endregion
        }
    }
}
