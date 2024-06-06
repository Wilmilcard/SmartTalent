using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartTalent.Domain.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DocType",
                columns: table => new
                {
                    DocTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocType", x => x.DocTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RolType",
                columns: table => new
                {
                    RolTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolType", x => x.RolTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValuePerNight = table.Column<double>(type: "double", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.RoomTypeId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotel_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Birth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Gender = table.Column<string>(type: "varchar(1)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Document = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmergencyContact = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmergencyPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DocTypeId = table.Column<int>(type: "int", nullable: false),
                    RolTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Person_DocType_DocTypeId",
                        column: x => x.DocTypeId,
                        principalTable: "DocType",
                        principalColumn: "DocTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_RolType_RolTypeId",
                        column: x => x.RolTypeId,
                        principalTable: "RolType",
                        principalColumn: "RolTypeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoomNumber = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MaxGuest = table.Column<int>(type: "int", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Room_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Room_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "varchar(6)", maxLength: 6, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StarDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TotalGuest = table.Column<double>(type: "double", nullable: false),
                    BaseCost = table.Column<double>(type: "double", nullable: false),
                    Tax = table.Column<double>(type: "double", nullable: false),
                    Total = table.Column<double>(type: "double", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Booking_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    FavoritesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.FavoritesId);
                    table.ForeignKey(
                        name: "FK_Favorites_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favorites_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PersonBooking",
                columns: table => new
                {
                    PersonBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonBooking", x => x.PersonBookingId);
                    table.ForeignKey(
                        name: "FK_PersonBooking_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonBooking_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Bogota D.C.", null },
                    { 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Medellin", null },
                    { 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Pereira", null },
                    { 4, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Barranquilla", null },
                    { 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Ibague", null }
                });

            migrationBuilder.InsertData(
                table: "DocType",
                columns: new[] { "DocTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "type" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Cedula Ciudadania", null, "C.C." },
                    { 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Pasaporte", null, "PP" },
                    { 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Tarjeta Identidad", null, "T.I." },
                    { 4, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "NIT", null, "NIT" },
                    { 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Cedula Extranjeria", null, "C.E." }
                });

            migrationBuilder.InsertData(
                table: "RolType",
                columns: new[] { "RolTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Administrador", null },
                    { 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Cliente", null }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "RoomTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "ValuePerNight" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Basica", null, 45000.0 },
                    { 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Premium", null, 90000.0 },
                    { 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Deluxe", null, 150000.0 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelId", "Availability", "CityId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Jerde Hills", null },
                    { 2, true, 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Medhurst Flats", null },
                    { 3, true, 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Reilly Islands", null },
                    { 4, false, 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Lakin Ranch", null },
                    { 5, true, 4, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Eileen Centers", null },
                    { 6, false, 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Sylvan Branch", null },
                    { 7, false, 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Collier Courts", null },
                    { 8, false, 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Grady Fords", null },
                    { 9, true, 4, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Treutel Shoals", null },
                    { 10, true, 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Ana Port", null },
                    { 11, false, 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Alisa Summit", null },
                    { 12, true, 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Ebert Valleys", null },
                    { 13, false, 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Trenton Village", null },
                    { 14, true, 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Hills Passage", null },
                    { 15, false, 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Lesch Harbor", null },
                    { 16, false, 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Williamson Plaza", null },
                    { 17, false, 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Scot Shores", null },
                    { 18, false, 4, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Elna Heights", null },
                    { 19, true, 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel McLaughlin Pass", null },
                    { 20, true, 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Mona Pine", null },
                    { 21, false, 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Langworth Junction", null },
                    { 22, true, 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Price Shores", null },
                    { 23, false, 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Herman Mount", null },
                    { 24, true, 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Mandy Garden", null },
                    { 25, true, 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", "Hotel Waters Garden", null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Birth", "CreatedAt", "CreatedBy", "DocTypeId", "Document", "Email", "EmergencyContact", "EmergencyPhone", "FirstName", "Gender", "LastName", "Phone", "RolTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1969, 7, 9, 15, 24, 21, 42, DateTimeKind.Local).AddTicks(1988), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "196907090457", "Eduardo.Mante88@gmail.com", "Bogus.DataSets.Name", "(985) 249-4939", "Eduardo", "J", "Mante", "(985) 249-4939", 2, null },
                    { 2, new DateTime(1969, 2, 20, 11, 31, 2, 590, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "196902205944", "Krista78@gmail.com", "Bogus.DataSets.Name", "1-417-768-3109 x032", "Krista", "H", "Robel", "1-417-768-3109 x032", 2, null },
                    { 3, new DateTime(1978, 7, 11, 14, 53, 0, 947, DateTimeKind.Local).AddTicks(2439), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "197807119479", "Ricardo_Schiller74@hotmail.com", "Bogus.DataSets.Name", "859-574-5282 x88027", "Ricardo", "G", "Schiller", "859-574-5282 x88027", 2, null },
                    { 4, new DateTime(1956, 12, 22, 5, 18, 25, 62, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "195612220631", "Moses74@yahoo.com", "Bogus.DataSets.Name", "388-685-5257", "Moses", "L", "Hayes", "388-685-5257", 2, null },
                    { 5, new DateTime(1995, 11, 15, 2, 26, 45, 938, DateTimeKind.Local).AddTicks(8736), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "199511159312", "Donnie30@gmail.com", "Bogus.DataSets.Name", "685.637.0723 x57304", "Donnie", "K", "Runolfsson", "685.637.0723 x57304", 2, null },
                    { 6, new DateTime(1999, 1, 28, 5, 19, 50, 752, DateTimeKind.Local).AddTicks(1484), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "199901287566", "Anita.Hickle4@yahoo.com", "Bogus.DataSets.Name", "362.427.7985 x530", "Anita", "J", "Hickle", "362.427.7985 x530", 2, null },
                    { 7, new DateTime(1982, 5, 31, 11, 6, 21, 511, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "198205315164", "Kari32@hotmail.com", "Bogus.DataSets.Name", "1-659-704-1249 x9296", "Kari", "L", "Murazik", "1-659-704-1249 x9296", 2, null },
                    { 8, new DateTime(1992, 3, 3, 6, 49, 24, 385, DateTimeKind.Local).AddTicks(9759), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "199203033882", "Olive.Upton82@gmail.com", "Bogus.DataSets.Name", "765.826.3064 x843", "Olive", "G", "Upton", "765.826.3064 x843", 2, null },
                    { 9, new DateTime(2001, 4, 6, 8, 19, 7, 232, DateTimeKind.Local).AddTicks(1195), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "200104062336", "Laurence.Maggio1@hotmail.com", "Bogus.DataSets.Name", "1-831-940-1692 x8285", "Laurence", "L", "Maggio", "1-831-940-1692 x8285", 2, null },
                    { 10, new DateTime(1998, 5, 11, 15, 58, 9, 140, DateTimeKind.Local).AddTicks(7102), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "199805111466", "Stella36@gmail.com", "Bogus.DataSets.Name", "(208) 985-3690 x32683", "Stella", "G", "Klocko", "(208) 985-3690 x32683", 2, null },
                    { 11, new DateTime(1988, 8, 9, 17, 34, 19, 63, DateTimeKind.Local).AddTicks(3943), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "198808090628", "Terri_Towne@yahoo.com", "Bogus.DataSets.Name", "994.978.0637 x324", "Terri", "G", "Towne", "994.978.0637 x324", 2, null },
                    { 12, new DateTime(1957, 10, 17, 21, 59, 15, 760, DateTimeKind.Local).AddTicks(8530), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "195710177626", "Peggy34@gmail.com", "Bogus.DataSets.Name", "(501) 437-2794 x553", "Peggy", "G", "Crooks", "(501) 437-2794 x553", 2, null },
                    { 13, new DateTime(1992, 3, 25, 14, 35, 57, 455, DateTimeKind.Local).AddTicks(1964), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "199203254512", "Darryl_VonRueden87@yahoo.com", "Bogus.DataSets.Name", "699.261.4965 x6232", "Darryl", "H", "VonRueden", "699.261.4965 x6232", 2, null },
                    { 14, new DateTime(1969, 4, 6, 18, 38, 43, 970, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "196904069736", "Melvin_Rosenbaum51@yahoo.com", "Bogus.DataSets.Name", "493-447-0895 x61101", "Melvin", "G", "Rosenbaum", "493-447-0895 x61101", 2, null },
                    { 15, new DateTime(1976, 5, 29, 20, 2, 30, 374, DateTimeKind.Local).AddTicks(2928), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "197605293732", "Jan96@yahoo.com", "Bogus.DataSets.Name", "974-814-8547", "Jan", "K", "Schinner", "974-814-8547", 2, null },
                    { 16, new DateTime(1965, 2, 4, 9, 42, 21, 282, DateTimeKind.Local).AddTicks(9872), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "196502042895", "Horace_Walsh87@hotmail.com", "Bogus.DataSets.Name", "738-763-4494", "Horace", "L", "Walsh", "738-763-4494", 2, null },
                    { 17, new DateTime(1965, 3, 19, 0, 10, 49, 620, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "196503196278", "Chris_Denesik70@hotmail.com", "Bogus.DataSets.Name", "384-499-2921 x09113", "Chris", "J", "Denesik", "384-499-2921 x09113", 2, null },
                    { 18, new DateTime(1965, 5, 19, 20, 26, 34, 499, DateTimeKind.Local).AddTicks(7347), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "196505194990", "Dewey.Hickle32@yahoo.com", "Bogus.DataSets.Name", "1-216-257-4529 x7510", "Dewey", "G", "Hickle", "1-216-257-4529 x7510", 2, null },
                    { 19, new DateTime(1987, 3, 28, 0, 35, 25, 400, DateTimeKind.Local).AddTicks(2817), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "198703284045", "Tammy_Mann@yahoo.com", "Bogus.DataSets.Name", "398-534-2930", "Tammy", "J", "Mann", "398-534-2930", 2, null },
                    { 20, new DateTime(1987, 9, 28, 4, 54, 56, 614, DateTimeKind.Local).AddTicks(1217), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "198709286150", "Domingo61@yahoo.com", "Bogus.DataSets.Name", "239-326-0989", "Domingo", "K", "Donnelly", "239-326-0989", 2, null },
                    { 21, new DateTime(1975, 10, 9, 13, 14, 0, 691, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "197510096949", "Sheila36@yahoo.com", "Bogus.DataSets.Name", "(318) 832-2016", "Sheila", "F", "Dickinson", "(318) 832-2016", 2, null },
                    { 22, new DateTime(1992, 1, 19, 18, 12, 27, 5, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "199201190080", "Sara_Spinka@hotmail.com", "Bogus.DataSets.Name", "249.651.4819", "Sara", "K", "Spinka", "249.651.4819", 2, null },
                    { 23, new DateTime(1963, 10, 5, 14, 51, 10, 18, DateTimeKind.Local).AddTicks(7130), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "196310050130", "Domingo91@gmail.com", "Bogus.DataSets.Name", "1-334-424-9741", "Domingo", "G", "Beer", "1-334-424-9741", 2, null },
                    { 24, new DateTime(1960, 1, 7, 8, 21, 21, 493, DateTimeKind.Local).AddTicks(6872), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "196001074977", "Shane_Gorczany9@gmail.com", "Bogus.DataSets.Name", "485-490-4006", "Shane", "I", "Gorczany", "485-490-4006", 2, null },
                    { 25, new DateTime(1970, 1, 26, 5, 41, 9, 266, DateTimeKind.Local).AddTicks(6835), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "197001262612", "Clinton78@hotmail.com", "Bogus.DataSets.Name", "486-235-6919", "Clinton", "H", "Legros", "486-235-6919", 2, null },
                    { 26, new DateTime(1993, 5, 3, 19, 21, 36, 432, DateTimeKind.Local).AddTicks(6824), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "199305034374", "Jared_Shanahan@hotmail.com", "Bogus.DataSets.Name", "(385) 862-5805", "Jared", "H", "Shanahan", "(385) 862-5805", 2, null },
                    { 27, new DateTime(1987, 8, 26, 9, 13, 26, 932, DateTimeKind.Local).AddTicks(5020), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "198708269330", "Herbert.Koch@yahoo.com", "Bogus.DataSets.Name", "(918) 826-7058", "Herbert", "K", "Koch", "(918) 826-7058", 2, null },
                    { 28, new DateTime(1970, 11, 24, 15, 51, 30, 795, DateTimeKind.Local).AddTicks(4388), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "197011247934", "Benjamin.Feest@hotmail.com", "Bogus.DataSets.Name", "1-730-428-3059 x45616", "Benjamin", "H", "Feest", "1-730-428-3059 x45616", 2, null },
                    { 29, new DateTime(2003, 9, 22, 16, 39, 37, 677, DateTimeKind.Local).AddTicks(50), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "200309226769", "Bernadette4@yahoo.com", "Bogus.DataSets.Name", "1-435-585-7970", "Bernadette", "G", "Parker", "1-435-585-7970", 2, null },
                    { 30, new DateTime(1974, 5, 6, 14, 55, 11, 932, DateTimeKind.Local).AddTicks(2178), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "197405069399", "Russell96@gmail.com", "Bogus.DataSets.Name", "238-506-7100 x7145", "Russell", "J", "Botsford", "238-506-7100 x7145", 2, null },
                    { 31, new DateTime(2004, 5, 27, 3, 50, 13, 271, DateTimeKind.Local).AddTicks(9386), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "200405272774", "Lester24@hotmail.com", "Bogus.DataSets.Name", "942.795.1464 x3955", "Lester", "I", "MacGyver", "942.795.1464 x3955", 2, null },
                    { 32, new DateTime(1962, 11, 4, 5, 34, 26, 363, DateTimeKind.Local).AddTicks(1031), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "196211043697", "Nicholas_Bernier@gmail.com", "Bogus.DataSets.Name", "347-264-9416 x2103", "Nicholas", "J", "Bernier", "347-264-9416 x2103", 2, null },
                    { 33, new DateTime(1999, 1, 29, 10, 6, 31, 440, DateTimeKind.Local).AddTicks(38), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "199901294455", "Walter_Heller36@hotmail.com", "Bogus.DataSets.Name", "883-985-0287 x54073", "Walter", "L", "Heller", "883-985-0287 x54073", 2, null },
                    { 34, new DateTime(1974, 10, 4, 0, 28, 49, 265, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "197410042670", "Rodolfo.Wisozk@hotmail.com", "Bogus.DataSets.Name", "677-744-2434 x3029", "Rodolfo", "I", "Wisozk", "677-744-2434 x3029", 2, null },
                    { 35, new DateTime(1959, 4, 17, 9, 31, 30, 334, DateTimeKind.Local).AddTicks(9357), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "195904173381", "Sabrina_Kozey@hotmail.com", "Bogus.DataSets.Name", "(603) 981-9699 x72458", "Sabrina", "H", "Kozey", "(603) 981-9699 x72458", 2, null },
                    { 36, new DateTime(1980, 2, 27, 7, 39, 45, 253, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "198002272535", "Jessie.Anderson@yahoo.com", "Bogus.DataSets.Name", "214-720-4095", "Jessie", "G", "Anderson", "214-720-4095", 2, null },
                    { 37, new DateTime(1991, 11, 26, 19, 56, 15, 853, DateTimeKind.Local).AddTicks(6062), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "199111268570", "Danny67@gmail.com", "Bogus.DataSets.Name", "(914) 232-8892 x4441", "Danny", "F", "Price", "(914) 232-8892 x4441", 2, null },
                    { 38, new DateTime(1992, 4, 8, 14, 37, 40, 172, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "199204081781", "Hope54@hotmail.com", "Bogus.DataSets.Name", "(663) 995-4345", "Hope", "L", "Lynch", "(663) 995-4345", 2, null },
                    { 39, new DateTime(1990, 2, 22, 1, 37, 50, 892, DateTimeKind.Local).AddTicks(9039), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "199002228964", "Connie74@hotmail.com", "Bogus.DataSets.Name", "1-989-497-3437", "Connie", "I", "Leuschke", "1-989-497-3437", 2, null },
                    { 40, new DateTime(2002, 8, 21, 21, 53, 8, 38, DateTimeKind.Local).AddTicks(9267), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "200208210351", "Terry_Roob67@gmail.com", "Bogus.DataSets.Name", "1-850-945-4341", "Terry", "F", "Roob", "1-850-945-4341", 2, null },
                    { 41, new DateTime(1984, 1, 4, 9, 54, 0, 531, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "198401045342", "Leigh_Pagac28@hotmail.com", "Bogus.DataSets.Name", "1-543-398-0210", "Leigh", "I", "Pagac", "1-543-398-0210", 2, null },
                    { 42, new DateTime(2002, 5, 28, 0, 32, 40, 931, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "200205289358", "Cornelius_Sauer@gmail.com", "Bogus.DataSets.Name", "688.619.0860", "Cornelius", "H", "Sauer", "688.619.0860", 2, null },
                    { 43, new DateTime(1961, 1, 8, 17, 23, 35, 78, DateTimeKind.Local).AddTicks(1736), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "196101080783", "Rosie.Lubowitz@yahoo.com", "Bogus.DataSets.Name", "(610) 997-3813 x092", "Rosie", "G", "Lubowitz", "(610) 997-3813 x092", 2, null },
                    { 44, new DateTime(1973, 12, 8, 16, 40, 25, 852, DateTimeKind.Local).AddTicks(8074), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "197312088581", "Eula.Walsh23@yahoo.com", "Bogus.DataSets.Name", "1-737-673-6829", "Eula", "I", "Walsh", "1-737-673-6829", 2, null },
                    { 45, new DateTime(1959, 6, 20, 10, 9, 20, 843, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "195906208458", "Clark65@hotmail.com", "Bogus.DataSets.Name", "727.911.0723 x308", "Clark", "F", "Hahn", "727.911.0723 x308", 2, null },
                    { 46, new DateTime(1981, 6, 3, 4, 45, 30, 241, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "198106032421", "Lois.Goldner56@hotmail.com", "Bogus.DataSets.Name", "(840) 491-1024", "Lois", "I", "Goldner", "(840) 491-1024", 2, null },
                    { 47, new DateTime(1991, 2, 28, 8, 51, 57, 335, DateTimeKind.Local).AddTicks(7487), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "199102283331", "Omar.Schmidt@gmail.com", "Bogus.DataSets.Name", "991-963-6570 x3213", "Omar", "H", "Schmidt", "991-963-6570 x3213", 2, null },
                    { 48, new DateTime(1980, 8, 18, 3, 48, 14, 410, DateTimeKind.Local).AddTicks(2573), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "198008184171", "Ricardo63@gmail.com", "Bogus.DataSets.Name", "1-213-777-2789", "Ricardo", "I", "Gottlieb", "1-213-777-2789", 2, null },
                    { 49, new DateTime(1979, 8, 13, 10, 56, 18, 258, DateTimeKind.Local).AddTicks(6414), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "197908132561", "Renee13@yahoo.com", "Bogus.DataSets.Name", "546-213-9376 x09676", "Renee", "H", "Pollich", "546-213-9376 x09676", 2, null },
                    { 50, new DateTime(1976, 11, 19, 14, 37, 43, 251, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "197611192589", "Anna25@hotmail.com", "Bogus.DataSets.Name", "487-563-1047 x472", "Anna", "I", "Ferry", "487-563-1047 x472", 2, null },
                    { 51, new DateTime(1969, 10, 18, 2, 30, 6, 515, DateTimeKind.Local).AddTicks(6349), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "196910185153", "Gerard_Morar4@gmail.com", "Bogus.DataSets.Name", "1-483-419-9472 x98763", "Gerard", "J", "Morar", "1-483-419-9472 x98763", 2, null },
                    { 52, new DateTime(1956, 7, 22, 8, 57, 7, 864, DateTimeKind.Local).AddTicks(2027), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "195607228623", "Sylvia62@yahoo.com", "Bogus.DataSets.Name", "(420) 328-8245 x78335", "Sylvia", "L", "Hermiston", "(420) 328-8245 x78335", 2, null },
                    { 53, new DateTime(1955, 11, 5, 1, 28, 58, 63, DateTimeKind.Local).AddTicks(4869), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "195511050675", "Justin85@gmail.com", "Bogus.DataSets.Name", "662.839.8920 x0719", "Justin", "H", "Mohr", "662.839.8920 x0719", 2, null },
                    { 54, new DateTime(1996, 10, 4, 16, 37, 57, 132, DateTimeKind.Local).AddTicks(6349), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "199610041312", "Malcolm_Predovic@hotmail.com", "Bogus.DataSets.Name", "971-500-3265", "Malcolm", "H", "Predovic", "971-500-3265", 2, null },
                    { 55, new DateTime(1985, 2, 11, 20, 3, 19, 674, DateTimeKind.Local).AddTicks(2797), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "198502116794", "Amos54@hotmail.com", "Bogus.DataSets.Name", "1-694-589-4921", "Amos", "I", "Mills", "1-694-589-4921", 2, null },
                    { 56, new DateTime(1982, 1, 16, 21, 19, 48, 888, DateTimeKind.Local).AddTicks(19), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "198201168872", "Hector79@yahoo.com", "Bogus.DataSets.Name", "452-791-2215 x35817", "Hector", "K", "Hegmann", "452-791-2215 x35817", 2, null },
                    { 57, new DateTime(1958, 2, 8, 15, 25, 9, 568, DateTimeKind.Local).AddTicks(974), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "195802085679", "Eugene53@gmail.com", "Bogus.DataSets.Name", "(768) 729-8089 x5197", "Eugene", "L", "Monahan", "(768) 729-8089 x5197", 2, null },
                    { 58, new DateTime(1957, 3, 6, 11, 8, 30, 129, DateTimeKind.Local).AddTicks(5691), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "195703061225", "Sadie.Rowe@gmail.com", "Bogus.DataSets.Name", "748.728.0867 x50804", "Sadie", "G", "Rowe", "748.728.0867 x50804", 2, null },
                    { 59, new DateTime(1966, 1, 26, 23, 2, 38, 294, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "196601262915", "Antonio_Reichert18@yahoo.com", "Bogus.DataSets.Name", "786.662.7492 x49361", "Antonio", "F", "Reichert", "786.662.7492 x49361", 2, null },
                    { 60, new DateTime(2001, 2, 10, 19, 24, 25, 306, DateTimeKind.Local).AddTicks(9511), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "200102103025", "Angie.OKeefe43@yahoo.com", "Bogus.DataSets.Name", "534-345-3532 x7114", "Angie", "L", "O'Keefe", "534-345-3532 x7114", 2, null },
                    { 61, new DateTime(2001, 4, 29, 11, 36, 14, 544, DateTimeKind.Local).AddTicks(5704), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "200104295472", "Orlando_Toy80@hotmail.com", "Bogus.DataSets.Name", "872-360-9818", "Orlando", "J", "Toy", "872-360-9818", 2, null },
                    { 62, new DateTime(1956, 1, 4, 15, 33, 33, 627, DateTimeKind.Local).AddTicks(7924), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "195601046252", "Shawn47@gmail.com", "Bogus.DataSets.Name", "1-256-499-5897", "Shawn", "F", "Boyle", "1-256-499-5897", 2, null },
                    { 63, new DateTime(1979, 8, 16, 15, 46, 22, 766, DateTimeKind.Local).AddTicks(2989), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "197908167674", "Kirk13@yahoo.com", "Bogus.DataSets.Name", "1-551-204-2681 x367", "Kirk", "I", "Bogan", "1-551-204-2681 x367", 2, null },
                    { 64, new DateTime(1955, 7, 25, 12, 15, 19, 439, DateTimeKind.Local).AddTicks(8820), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "195507254331", "Edgar25@hotmail.com", "Bogus.DataSets.Name", "1-567-739-5605 x03396", "Edgar", "I", "Wintheiser", "1-567-739-5605 x03396", 2, null },
                    { 65, new DateTime(1980, 1, 28, 16, 33, 10, 901, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "198001289019", "Claude80@yahoo.com", "Bogus.DataSets.Name", "(515) 761-0941 x0484", "Claude", "J", "Ruecker", "(515) 761-0941 x0484", 2, null },
                    { 66, new DateTime(1954, 9, 18, 5, 25, 55, 225, DateTimeKind.Local).AddTicks(7552), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "195409182291", "Ervin_Rath6@hotmail.com", "Bogus.DataSets.Name", "1-264-693-6222", "Ervin", "H", "Rath", "1-264-693-6222", 2, null },
                    { 67, new DateTime(1980, 12, 25, 19, 15, 53, 327, DateTimeKind.Local).AddTicks(5493), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "198012253251", "Mack.Dare@gmail.com", "Bogus.DataSets.Name", "(523) 971-8194 x534", "Mack", "K", "Dare", "(523) 971-8194 x534", 2, null },
                    { 68, new DateTime(1982, 4, 15, 17, 27, 51, 927, DateTimeKind.Local).AddTicks(2537), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "198204159225", "Latoya_Yost81@gmail.com", "Bogus.DataSets.Name", "969-366-3526 x17506", "Latoya", "G", "Yost", "969-366-3526 x17506", 2, null },
                    { 69, new DateTime(1986, 1, 18, 13, 41, 38, 845, DateTimeKind.Local).AddTicks(5011), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "198601188488", "Rosalie_Halvorson@yahoo.com", "Bogus.DataSets.Name", "1-865-601-0075 x642", "Rosalie", "G", "Halvorson", "1-865-601-0075 x642", 2, null },
                    { 70, new DateTime(1998, 5, 5, 13, 30, 11, 563, DateTimeKind.Local).AddTicks(3278), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "199805055671", "Melvin_Douglas4@yahoo.com", "Bogus.DataSets.Name", "258.406.6604 x6400", "Melvin", "G", "Douglas", "258.406.6604 x6400", 2, null },
                    { 71, new DateTime(1977, 4, 21, 7, 58, 26, 70, DateTimeKind.Local).AddTicks(9986), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "197704210751", "Levi.Borer@yahoo.com", "Bogus.DataSets.Name", "1-959-631-4916", "Levi", "K", "Borer", "1-959-631-4916", 2, null },
                    { 72, new DateTime(1973, 6, 11, 2, 47, 10, 638, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "197306116398", "Jonathon78@hotmail.com", "Bogus.DataSets.Name", "(423) 505-3753 x28228", "Jonathon", "K", "Herman", "(423) 505-3753 x28228", 2, null },
                    { 73, new DateTime(1962, 8, 1, 18, 38, 23, 898, DateTimeKind.Local).AddTicks(8890), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "196208018967", "Elsa5@yahoo.com", "Bogus.DataSets.Name", "993.270.9317", "Elsa", "G", "Hagenes", "993.270.9317", 2, null },
                    { 74, new DateTime(1958, 10, 6, 22, 12, 24, 122, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "195810061217", "Francisco.Runolfsson82@hotmail.com", "Bogus.DataSets.Name", "1-623-641-3394 x16866", "Francisco", "F", "Runolfsson", "1-623-641-3394 x16866", 2, null },
                    { 75, new DateTime(2002, 10, 21, 17, 21, 21, 534, DateTimeKind.Local).AddTicks(5273), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "200210215364", "Patty.Hickle57@gmail.com", "Bogus.DataSets.Name", "238-792-1487 x943", "Patty", "H", "Hickle", "238-792-1487 x943", 2, null },
                    { 76, new DateTime(2003, 8, 19, 3, 46, 43, 338, DateTimeKind.Local).AddTicks(2348), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "200308193382", "Rose_Renner96@hotmail.com", "Bogus.DataSets.Name", "299.732.7674 x301", "Rose", "J", "Renner", "299.732.7674 x301", 2, null },
                    { 77, new DateTime(1973, 3, 3, 1, 14, 18, 100, DateTimeKind.Local).AddTicks(5022), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "197303031012", "Darren85@hotmail.com", "Bogus.DataSets.Name", "(947) 292-6126", "Darren", "L", "Schmidt", "(947) 292-6126", 2, null },
                    { 78, new DateTime(2002, 3, 14, 18, 7, 20, 815, DateTimeKind.Local).AddTicks(7163), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "200203148192", "Jonathon73@gmail.com", "Bogus.DataSets.Name", "751.750.4646", "Jonathon", "L", "Powlowski", "751.750.4646", 2, null },
                    { 79, new DateTime(1985, 7, 20, 15, 43, 41, 685, DateTimeKind.Local).AddTicks(8157), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "198507206855", "Earnest.Ernser@gmail.com", "Bogus.DataSets.Name", "(452) 222-4147 x9237", "Earnest", "K", "Ernser", "(452) 222-4147 x9237", 2, null },
                    { 80, new DateTime(1996, 10, 7, 4, 3, 9, 369, DateTimeKind.Local).AddTicks(1054), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "199610073695", "Gerardo44@hotmail.com", "Bogus.DataSets.Name", "1-429-625-1027", "Gerardo", "L", "Keeling", "1-429-625-1027", 2, null },
                    { 81, new DateTime(1983, 7, 8, 22, 21, 3, 351, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "198307083546", "Hazel.Langworth81@gmail.com", "Bogus.DataSets.Name", "1-284-216-8116", "Hazel", "K", "Langworth", "1-284-216-8116", 2, null },
                    { 82, new DateTime(1999, 3, 2, 16, 29, 9, 584, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "199903025832", "Bill.Treutel@gmail.com", "Bogus.DataSets.Name", "1-979-279-6030 x54040", "Bill", "L", "Treutel", "1-979-279-6030 x54040", 2, null },
                    { 83, new DateTime(1985, 4, 30, 10, 43, 24, 357, DateTimeKind.Local).AddTicks(9060), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "198504303572", "Harvey.Howell@hotmail.com", "Bogus.DataSets.Name", "(639) 486-5888", "Harvey", "H", "Howell", "(639) 486-5888", 2, null },
                    { 84, new DateTime(1995, 5, 9, 12, 39, 23, 270, DateTimeKind.Local).AddTicks(6249), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "199505092743", "Brittany.Kuhlman@gmail.com", "Bogus.DataSets.Name", "1-973-247-6887 x1559", "Brittany", "L", "Kuhlman", "1-973-247-6887 x1559", 2, null },
                    { 85, new DateTime(2001, 3, 6, 16, 54, 9, 840, DateTimeKind.Local).AddTicks(6304), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "200103068433", "Adam_Dickinson@yahoo.com", "Bogus.DataSets.Name", "573-401-8412", "Adam", "I", "Dickinson", "573-401-8412", 2, null },
                    { 86, new DateTime(1988, 5, 26, 1, 8, 24, 870, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "198805268714", "Claude45@yahoo.com", "Bogus.DataSets.Name", "(411) 794-8306", "Claude", "I", "Heaney", "(411) 794-8306", 2, null },
                    { 87, new DateTime(1957, 5, 20, 21, 50, 22, 362, DateTimeKind.Local).AddTicks(79), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "195705203668", "Annie.Rau69@hotmail.com", "Bogus.DataSets.Name", "1-344-859-2476 x211", "Annie", "H", "Rau", "1-344-859-2476 x211", 2, null },
                    { 88, new DateTime(1979, 8, 22, 15, 47, 32, 578, DateTimeKind.Local).AddTicks(2285), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "197908225712", "Mark34@gmail.com", "Bogus.DataSets.Name", "908.698.8651", "Mark", "J", "Herzog", "908.698.8651", 2, null },
                    { 89, new DateTime(1956, 8, 7, 1, 59, 41, 211, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "195608072160", "Suzanne.Waelchi15@yahoo.com", "Bogus.DataSets.Name", "310.757.1141 x14666", "Suzanne", "K", "Waelchi", "310.757.1141 x14666", 2, null },
                    { 90, new DateTime(1958, 1, 8, 6, 13, 14, 838, DateTimeKind.Local).AddTicks(5095), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "195801088344", "Angel57@hotmail.com", "Bogus.DataSets.Name", "(964) 445-3784 x8812", "Angel", "J", "Bergnaum", "(964) 445-3784 x8812", 2, null },
                    { 91, new DateTime(1994, 1, 2, 16, 2, 42, 31, DateTimeKind.Local).AddTicks(7442), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "199401020327", "Viola_Sanford@yahoo.com", "Bogus.DataSets.Name", "915-716-7117", "Viola", "F", "Sanford", "915-716-7117", 2, null },
                    { 92, new DateTime(1959, 3, 20, 6, 46, 35, 850, DateTimeKind.Local).AddTicks(1880), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "195903208568", "Sheryl_Lindgren76@gmail.com", "Bogus.DataSets.Name", "651.921.2067", "Sheryl", "L", "Lindgren", "651.921.2067", 2, null },
                    { 93, new DateTime(1997, 11, 6, 23, 51, 52, 709, DateTimeKind.Local).AddTicks(7234), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "199711067067", "Erma80@gmail.com", "Bogus.DataSets.Name", "943-270-4224 x505", "Erma", "I", "Abshire", "943-270-4224 x505", 2, null },
                    { 94, new DateTime(1977, 1, 8, 20, 14, 50, 984, DateTimeKind.Local).AddTicks(3542), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, "197701089836", "Dominic_Murphy45@gmail.com", "Bogus.DataSets.Name", "843-427-7699 x89597", "Dominic", "H", "Murphy", "843-427-7699 x89597", 2, null },
                    { 95, new DateTime(1979, 2, 11, 11, 46, 17, 417, DateTimeKind.Local).AddTicks(5891), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "197902114136", "Tracy.Waters@yahoo.com", "Bogus.DataSets.Name", "583-819-7682 x6989", "Tracy", "F", "Waters", "583-819-7682 x6989", 2, null },
                    { 96, new DateTime(1993, 6, 1, 5, 52, 42, 567, DateTimeKind.Local).AddTicks(6401), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "199306015679", "Ronnie46@yahoo.com", "Bogus.DataSets.Name", "1-702-841-2182 x128", "Ronnie", "I", "Kovacek", "1-702-841-2182 x128", 2, null },
                    { 97, new DateTime(1998, 11, 17, 21, 32, 52, 335, DateTimeKind.Local).AddTicks(1272), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, "199811173328", "Chelsea45@gmail.com", "Bogus.DataSets.Name", "1-505-529-8749 x599", "Chelsea", "L", "Kerluke", "1-505-529-8749 x599", 2, null },
                    { 98, new DateTime(1981, 10, 10, 10, 34, 36, 289, DateTimeKind.Local).AddTicks(6133), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, "198110102863", "Sheila_Rau83@hotmail.com", "Bogus.DataSets.Name", "771.899.6399 x085", "Sheila", "L", "Rau", "771.899.6399 x085", 2, null },
                    { 99, new DateTime(1961, 8, 29, 17, 24, 0, 843, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, "196108298487", "Delia_Carter@hotmail.com", "Bogus.DataSets.Name", "891-732-0495 x33437", "Delia", "L", "Carter", "891-732-0495 x33437", 2, null },
                    { 100, new DateTime(1974, 8, 22, 8, 31, 53, 193, DateTimeKind.Local).AddTicks(1728), new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, "197408221971", "Floyd_Franecki34@hotmail.com", "Bogus.DataSets.Name", "736-813-9005 x6085", "Floyd", "H", "Franecki", "736-813-9005 x6085", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "Availability", "CreatedAt", "CreatedBy", "HotelId", "MaxGuest", "RoomNumber", "RoomTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, 2, "R97", 1, null },
                    { 2, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, 2, "P84", 1, null },
                    { 3, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, 4, "P8", 2, null },
                    { 4, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 12, 2, "E43", 3, null },
                    { 5, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 4, "L50", 1, null },
                    { 6, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, 2, "K70", 1, null },
                    { 7, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 25, 1, "E85", 3, null },
                    { 8, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 8, 3, "C36", 1, null },
                    { 9, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, 2, "S40", 3, null },
                    { 10, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 11, 3, "M69", 2, null },
                    { 11, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 12, 1, "G82", 3, null },
                    { 12, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 14, 1, "G13", 2, null },
                    { 13, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 1, "R18", 2, null },
                    { 14, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 3, "U85", 1, null },
                    { 15, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 7, 2, "V11", 1, null },
                    { 16, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 24, 3, "K0", 2, null },
                    { 17, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, 4, "Y32", 1, null },
                    { 18, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 3, "I97", 1, null },
                    { 19, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, 4, "H82", 3, null },
                    { 20, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, 4, "S24", 1, null },
                    { 21, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 11, 1, "Z7", 3, null },
                    { 22, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 6, 3, "H59", 3, null },
                    { 23, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, 2, "V71", 3, null },
                    { 24, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 4, "M62", 1, null },
                    { 25, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 7, 2, "O10", 1, null },
                    { 26, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 13, 2, "Q92", 1, null },
                    { 27, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, 3, "S50", 1, null },
                    { 28, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, 3, "D72", 1, null },
                    { 29, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 1, "N11", 1, null },
                    { 30, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 1, "I97", 1, null },
                    { 31, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 25, 4, "Z23", 1, null },
                    { 32, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 11, 2, "W55", 2, null },
                    { 33, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, 3, "G36", 3, null },
                    { 34, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 18, 4, "N25", 1, null },
                    { 35, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 2, "H70", 3, null },
                    { 36, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 25, 4, "G50", 3, null },
                    { 37, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 1, "N62", 2, null },
                    { 38, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 12, 2, "Q92", 3, null },
                    { 39, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, 4, "L57", 2, null },
                    { 40, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 25, 4, "M82", 1, null },
                    { 41, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 3, "D81", 2, null },
                    { 42, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, 2, "H96", 3, null },
                    { 43, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 13, 2, "D7", 2, null },
                    { 44, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, 2, "U43", 1, null },
                    { 45, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 24, 1, "D93", 1, null },
                    { 46, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 8, 1, "P78", 2, null },
                    { 47, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 20, 2, "Z88", 2, null },
                    { 48, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 3, "B9", 1, null },
                    { 49, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, 4, "I31", 2, null },
                    { 50, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 12, 4, "V31", 2, null },
                    { 51, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, 4, "N53", 1, null },
                    { 52, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 8, 2, "N16", 2, null },
                    { 53, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 1, "U6", 1, null },
                    { 54, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 14, 1, "C32", 2, null },
                    { 55, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, 3, "Z70", 3, null },
                    { 56, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, 1, "O96", 1, null },
                    { 57, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, 4, "L43", 2, null },
                    { 58, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 9, 4, "D96", 1, null },
                    { 59, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, 4, "P26", 1, null },
                    { 60, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, 4, "N53", 3, null },
                    { 61, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, 2, "Y45", 3, null },
                    { 62, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 13, 4, "V61", 1, null },
                    { 63, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 9, 4, "I94", 2, null },
                    { 64, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, 1, "M31", 3, null },
                    { 65, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, 2, "P29", 2, null },
                    { 66, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 8, 2, "E23", 1, null },
                    { 67, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 3, "S25", 1, null },
                    { 68, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 4, "Y13", 2, null },
                    { 69, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 8, 1, "I95", 3, null },
                    { 70, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 25, 1, "M29", 3, null },
                    { 71, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 16, 1, "L38", 2, null },
                    { 72, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 11, 1, "Y74", 3, null },
                    { 73, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, 4, "Q57", 3, null },
                    { 74, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 9, 2, "F33", 2, null },
                    { 75, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 6, 3, "H38", 3, null },
                    { 76, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, 1, "J92", 2, null },
                    { 77, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 20, 4, "B11", 1, null },
                    { 78, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, 4, "H5", 1, null },
                    { 79, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 16, 2, "H68", 3, null },
                    { 80, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 2, "Z77", 3, null },
                    { 81, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, 3, "O37", 2, null },
                    { 82, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, 3, "R13", 2, null },
                    { 83, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 12, 2, "O2", 1, null },
                    { 84, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 16, 1, "S61", 3, null },
                    { 85, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 2, 2, "R15", 3, null },
                    { 86, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, 2, "M96", 3, null },
                    { 87, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, 4, "Y22", 1, null },
                    { 88, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, 3, "F21", 3, null },
                    { 89, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 6, 4, "R55", 3, null },
                    { 90, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 18, 2, "J27", 2, null },
                    { 91, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 1, "M36", 1, null },
                    { 92, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, 4, "P90", 1, null },
                    { 93, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 23, 2, "L83", 2, null },
                    { 94, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, 1, "E40", 2, null },
                    { 95, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 9, 4, "Q9", 1, null },
                    { 96, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, 2, "H58", 2, null },
                    { 97, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 14, 3, "L26", 2, null },
                    { 98, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 23, 3, "X14", 1, null },
                    { 99, false, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, 2, "L80", 3, null },
                    { 100, true, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 7, 4, "B1", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "Availability", "BaseCost", "Code", "CreatedAt", "CreatedBy", "EndDate", "PersonId", "RoomId", "StarDate", "Tax", "Total", "TotalGuest", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, 0.0, "NYASXN", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 91, new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 2, false, 0.0, "MOAHNB", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 43, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 3, false, 0.0, "YHUCMW", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, 65, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 4, true, 0.0, "DQOLBC", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 65, new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 5, false, 0.0, "DSEHTZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 55, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 6, false, 0.0, "IJOCNO", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 3, new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 7, false, 0.0, "PPABBJ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 31, new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 8, true, 0.0, "KBAALN", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 4, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 9, false, 0.0, "TFEFIX", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 99, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 10, true, 0.0, "GOESOF", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 95, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 11, false, 0.0, "HGAROH", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 24, new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 12, true, 0.0, "VIASJZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 27, new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 13, false, 0.0, "WBAGLT", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 76, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 14, false, 0.0, "DPECPU", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 65, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 15, true, 0.0, "SFOOMF", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 55, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 16, false, 0.0, "UKUVAD", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 44, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 17, false, 0.0, "UHOBMZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 57, new DateTime(2024, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 18, true, 0.0, "YDEACM", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 36, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 19, true, 0.0, "PHIIMG", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 99, new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 20, false, 0.0, "YKUMCB", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 44, new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 21, true, 0.0, "FWEPWN", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 99, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 22, false, 0.0, "KJEZRR", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 52, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 23, true, 0.0, "OZISOU", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 17, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 24, true, 0.0, "JUALYO", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 18, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 25, false, 0.0, "NVEWFQ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 70, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 26, true, 0.0, "QGICCZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 8, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 27, false, 0.0, "GKAGIH", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 17, new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 28, false, 0.0, "PBAASL", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 29, new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 29, false, 0.0, "QTANEV", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 30, true, 0.0, "UXAMEA", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 83, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 31, true, 0.0, "VLEBQW", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 49, new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 32, true, 0.0, "MPAADX", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 4, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 33, true, 0.0, "VXAGGJ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 81, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 34, false, 0.0, "HYOMLW", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 1, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 35, true, 0.0, "LUUHRJ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 77, new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 36, false, 0.0, "GJEPWG", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 29, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 37, true, 0.0, "CIEBAR", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 19, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 38, false, 0.0, "WVUATZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 50, new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 39, false, 0.0, "TBODZS", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 98, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 40, false, 0.0, "OKUPSR", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 3, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 41, false, 0.0, "MBOINC", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 58, new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 42, true, 0.0, "FJEMNG", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 94, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 43, false, 0.0, "IKUQAT", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 97, 26, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 44, false, 0.0, "RPACEK", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 79, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 45, true, 0.0, "SEIIMZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 42, new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 46, true, 0.0, "HHEKGQ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 75, new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 47, true, 0.0, "HQEUSP", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 9, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 48, true, 0.0, "QKITTF", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 82, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 49, false, 0.0, "AQESJR", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 56, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 50, true, 0.0, "GFOBZE", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 77, new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 51, false, 0.0, "WYOSBB", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 75, new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 52, true, 0.0, "BVEVCT", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 19, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 53, false, 0.0, "PKOZRU", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 88, 16, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 54, true, 0.0, "GKABMY", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 46, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 55, true, 0.0, "GOUSDY", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 62, 39, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 56, true, 0.0, "CNABFB", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 6, new DateTime(2024, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 57, true, 0.0, "TDOSNI", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 63, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 58, true, 0.0, "TSAIRC", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 82, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 59, false, 0.0, "SXARWV", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 94, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 60, false, 0.0, "QOISIK", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 33, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 61, false, 0.0, "CJUMYX", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 71, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 62, true, 0.0, "KIITGN", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, 87, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 63, false, 0.0, "CXOCXQ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 46, new DateTime(2024, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 64, true, 0.0, "YPOBSQ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 72, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 65, true, 0.0, "PJOTTZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 75, new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 66, false, 0.0, "HZAAWX", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 65, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 67, true, 0.0, "TIOSXI", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 75, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 68, false, 0.0, "OIEINB", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 76, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 69, false, 0.0, "YRICHI", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 99, 47, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 70, false, 0.0, "PWUMAY", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 58, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 71, false, 0.0, "ZPERSL", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 92, 85, new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 72, true, 0.0, "FPEETS", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 75, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 73, false, 0.0, "ZMUSHZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 46, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 74, false, 0.0, "VIUCDO", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 64, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 75, true, 0.0, "KPOGDR", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 92, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 76, false, 0.0, "GZODDH", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 79, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 77, false, 0.0, "SXIETP", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 75, new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 78, true, 0.0, "NRUAFO", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 69, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 79, false, 0.0, "GLOCSV", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 65, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 80, false, 0.0, "NWEPEP", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 83, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 81, true, 0.0, "WRIBUO", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 12, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 82, false, 0.0, "ZOUUMI", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 62, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 83, false, 0.0, "MMUVIE", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 48, new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 84, true, 0.0, "AQICSW", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 94, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 85, true, 0.0, "ZMUBGD", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 12, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 86, false, 0.0, "VPOITZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 50, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 87, true, 0.0, "QYUBWM", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 93, new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 88, false, 0.0, "PLASRC", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 79, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 89, true, 0.0, "MMEASO", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 77, 73, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 90, true, 0.0, "BOIMCI", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 45, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 91, false, 0.0, "OYAGTU", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 79, 67, new DateTime(2024, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 92, false, 0.0, "AZOSHZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 77, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 93, false, 0.0, "UYIGBT", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 97, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 94, false, 0.0, "JKIBNZ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 20, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 95, true, 0.0, "OZOAGJ", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 36, new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 96, false, 0.0, "ZUICPL", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 91, 72, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 97, true, 0.0, "WTIAUN", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 94, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 98, false, 0.0, "AGEHKD", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 25, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 99, true, 0.0, "PMABFO", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 12, new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null },
                    { 100, false, 0.0, "WXOSTW", new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 81, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 0.0, null }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "FavoritesId", "CreatedAt", "CreatedBy", "PersonId", "RoomId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 20, 97, null },
                    { 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 31, 93, null },
                    { 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 90, 70, null },
                    { 4, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 63, 85, null },
                    { 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, 70, null },
                    { 6, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 98, 96, null },
                    { 7, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 62, 16, null },
                    { 8, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, 70, null },
                    { 9, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 18, 95, null },
                    { 10, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, 14, null },
                    { 11, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 89, 66, null },
                    { 12, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 31, 69, null },
                    { 13, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 92, 97, null },
                    { 14, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 8, 13, null },
                    { 15, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 72, 56, null },
                    { 16, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 36, 35, null },
                    { 17, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 28, 66, null },
                    { 18, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 99, 74, null },
                    { 19, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 59, 31, null },
                    { 20, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 39, 17, null },
                    { 21, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 25, 67, null },
                    { 22, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 27, 3, null },
                    { 23, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 92, 9, null },
                    { 24, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 43, 6, null },
                    { 25, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, 13, null },
                    { 26, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 75, 94, null },
                    { 27, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 13, 36, null },
                    { 28, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 70, 5, null },
                    { 29, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 80, 8, null },
                    { 30, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 88, 31, null },
                    { 31, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 7, 99, null },
                    { 32, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 27, 95, null },
                    { 33, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 97, 84, null },
                    { 34, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 65, 69, null },
                    { 35, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 87, 62, null },
                    { 36, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 49, 98, null },
                    { 37, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, 1, null },
                    { 38, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 40, 63, null },
                    { 39, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 40, 5, null },
                    { 40, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 86, 16, null },
                    { 41, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 64, 98, null },
                    { 42, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 13, 95, null },
                    { 43, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 37, 61, null },
                    { 44, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, 76, null },
                    { 45, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 56, 96, null },
                    { 46, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 42, 71, null },
                    { 47, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 12, 24, null },
                    { 48, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, 83, null },
                    { 49, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 42, 10, null },
                    { 50, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 55, 21, null },
                    { 51, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 57, 99, null },
                    { 52, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, 24, null },
                    { 53, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 96, 58, null },
                    { 54, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 33, 66, null },
                    { 55, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 54, 51, null },
                    { 56, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 40, 46, null },
                    { 57, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 82, 27, null },
                    { 58, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 83, 87, null },
                    { 59, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 79, 78, null },
                    { 60, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 7, 73, null },
                    { 61, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 99, 70, null },
                    { 62, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 50, 27, null },
                    { 63, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 16, 5, null },
                    { 64, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 26, 25, null },
                    { 65, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, 80, null },
                    { 66, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 30, 92, null },
                    { 67, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 64, 5, null },
                    { 68, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, 47, null },
                    { 69, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 23, 5, null },
                    { 70, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 96, 71, null },
                    { 71, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 92, 52, null },
                    { 72, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 34, 30, null },
                    { 73, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 51, 42, null },
                    { 74, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 56, 37, null },
                    { 75, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 67, 41, null },
                    { 76, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 44, 83, null },
                    { 77, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, 84, null },
                    { 78, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 96, 61, null },
                    { 79, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 20, 32, null },
                    { 80, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 86, 2, null },
                    { 81, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 20, 85, null },
                    { 82, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 86, 53, null },
                    { 83, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 48, 45, null },
                    { 84, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 46, 48, null },
                    { 85, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, 17, null },
                    { 86, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 92, 11, null },
                    { 87, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 67, 83, null },
                    { 88, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 48, 16, null },
                    { 89, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 54, 70, null },
                    { 90, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 43, 79, null },
                    { 91, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 62, 40, null },
                    { 92, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, 100, null },
                    { 93, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 43, 56, null },
                    { 94, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 77, 49, null },
                    { 95, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 74, 77, null },
                    { 96, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 25, 28, null },
                    { 97, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 45, 63, null },
                    { 98, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 39, 4, null },
                    { 99, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 24, 86, null },
                    { 100, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 75, 74, null }
                });

            migrationBuilder.InsertData(
                table: "PersonBooking",
                columns: new[] { "PersonBookingId", "BookingId", "CreatedAt", "CreatedBy", "PersonId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 96, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 53, null },
                    { 2, 52, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 37, null },
                    { 3, 67, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 99, null },
                    { 4, 87, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 42, null },
                    { 5, 94, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 39, null },
                    { 6, 87, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, null },
                    { 7, 100, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 7, null },
                    { 8, 49, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, null },
                    { 9, 39, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 14, null },
                    { 10, 36, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, null },
                    { 11, 27, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 88, null },
                    { 12, 38, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 78, null },
                    { 13, 56, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 72, null },
                    { 14, 15, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 36, null },
                    { 15, 21, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 41, null },
                    { 16, 62, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 94, null },
                    { 17, 16, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 41, null },
                    { 18, 88, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 39, null },
                    { 19, 57, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, null },
                    { 20, 58, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 64, null },
                    { 21, 64, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 37, null },
                    { 22, 91, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 89, null },
                    { 23, 24, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 87, null },
                    { 24, 17, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 65, null },
                    { 25, 87, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 55, null },
                    { 26, 44, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 35, null },
                    { 27, 53, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, null },
                    { 28, 68, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 44, null },
                    { 29, 22, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 11, null },
                    { 30, 89, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 26, null },
                    { 31, 29, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 29, null },
                    { 32, 87, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 59, null },
                    { 33, 16, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, null },
                    { 34, 96, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 88, null },
                    { 35, 30, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 68, null },
                    { 36, 65, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 37, 19, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 35, null },
                    { 38, 14, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, null },
                    { 39, 61, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 34, null },
                    { 40, 59, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 86, null },
                    { 41, 42, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 76, null },
                    { 42, 33, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 49, null },
                    { 43, 99, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 98, null },
                    { 44, 79, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 28, null },
                    { 45, 14, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 46, null },
                    { 46, 94, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 37, null },
                    { 47, 17, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 37, null },
                    { 48, 6, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 96, null },
                    { 49, 57, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 9, null },
                    { 50, 20, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 93, null },
                    { 51, 47, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 89, null },
                    { 52, 15, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 53, null },
                    { 53, 92, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, null },
                    { 54, 60, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 57, null },
                    { 55, 26, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 20, null },
                    { 56, 90, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 58, null },
                    { 57, 60, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 67, null },
                    { 58, 44, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, null },
                    { 59, 42, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 60, 96, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 96, null },
                    { 61, 48, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 69, null },
                    { 62, 77, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 94, null },
                    { 63, 29, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 36, null },
                    { 64, 92, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 31, null },
                    { 65, 11, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 46, null },
                    { 66, 79, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, null },
                    { 67, 40, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 59, null },
                    { 68, 10, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 67, null },
                    { 69, 13, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 11, null },
                    { 70, 64, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 63, null },
                    { 71, 25, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 16, null },
                    { 72, 29, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 12, null },
                    { 73, 32, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, null },
                    { 74, 44, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 63, null },
                    { 75, 67, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 95, null },
                    { 76, 61, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 87, null },
                    { 77, 7, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, null },
                    { 78, 30, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 79, 70, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 50, null },
                    { 80, 50, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 32, null },
                    { 81, 85, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, null },
                    { 82, 50, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 24, null },
                    { 83, 63, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, null },
                    { 84, 48, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 58, null },
                    { 85, 66, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 9, null },
                    { 86, 23, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 79, null },
                    { 87, 68, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 51, null },
                    { 88, 50, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 37, null },
                    { 89, 29, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 90, 79, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 24, null },
                    { 91, 89, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 49, null },
                    { 92, 41, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 55, null },
                    { 93, 9, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 13, null },
                    { 94, 33, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 99, null },
                    { 95, 20, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 71, null },
                    { 96, 45, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 83, null },
                    { 97, 30, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, null },
                    { 98, 24, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 73, null },
                    { 99, 15, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 74, null },
                    { 100, 54, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 75, null },
                    { 101, 53, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 16, null },
                    { 102, 50, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 91, null },
                    { 103, 79, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 89, null },
                    { 104, 80, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 84, null },
                    { 105, 55, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 100, null },
                    { 106, 48, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 34, null },
                    { 107, 42, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, null },
                    { 108, 88, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 93, null },
                    { 109, 32, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 35, null },
                    { 110, 36, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 53, null },
                    { 111, 54, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 91, null },
                    { 112, 49, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 7, null },
                    { 113, 22, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 43, null },
                    { 114, 76, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 87, null },
                    { 115, 12, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 27, null },
                    { 116, 44, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 71, null },
                    { 117, 49, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 83, null },
                    { 118, 4, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 88, null },
                    { 119, 11, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 16, null },
                    { 120, 70, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, null },
                    { 121, 6, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 45, null },
                    { 122, 72, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 123, 14, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 35, null },
                    { 124, 98, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 51, null },
                    { 125, 19, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 66, null },
                    { 126, 17, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 27, null },
                    { 127, 57, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 32, null },
                    { 128, 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, null },
                    { 129, 57, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, null },
                    { 130, 66, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 37, null },
                    { 131, 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 46, null },
                    { 132, 56, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 34, null },
                    { 133, 4, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 53, null },
                    { 134, 11, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 76, null },
                    { 135, 22, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, null },
                    { 136, 29, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 97, null },
                    { 137, 87, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 62, null },
                    { 138, 86, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 79, null },
                    { 139, 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 53, null },
                    { 140, 20, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 46, null },
                    { 141, 82, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 51, null },
                    { 142, 41, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 82, null },
                    { 143, 100, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 80, null },
                    { 144, 42, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 61, null },
                    { 145, 25, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 9, null },
                    { 146, 8, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 8, null },
                    { 147, 15, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, null },
                    { 148, 41, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 26, null },
                    { 149, 73, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 60, null },
                    { 150, 71, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 42, null },
                    { 151, 84, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 36, null },
                    { 152, 66, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 13, null },
                    { 153, 77, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 7, null },
                    { 154, 41, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 59, null },
                    { 155, 67, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 89, null },
                    { 156, 50, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 71, null },
                    { 157, 40, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 92, null },
                    { 158, 6, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 82, null },
                    { 159, 96, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 22, null },
                    { 160, 96, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 8, null },
                    { 161, 30, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, null },
                    { 162, 89, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 58, null },
                    { 163, 31, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 5, null },
                    { 164, 18, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 64, null },
                    { 165, 99, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 6, null },
                    { 166, 73, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 78, null },
                    { 167, 26, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 80, null },
                    { 168, 81, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 21, null },
                    { 169, 39, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 11, null },
                    { 170, 81, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 42, null },
                    { 171, 47, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, null },
                    { 172, 42, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 173, 41, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, null },
                    { 174, 97, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 53, null },
                    { 175, 62, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 43, null },
                    { 176, 19, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 86, null },
                    { 177, 63, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 59, null },
                    { 178, 39, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 99, null },
                    { 179, 69, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 57, null },
                    { 180, 17, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 26, null },
                    { 181, 72, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 95, null },
                    { 182, 26, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 12, null },
                    { 183, 22, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 76, null },
                    { 184, 96, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 100, null },
                    { 185, 33, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 65, null },
                    { 186, 61, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 61, null },
                    { 187, 7, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 74, null },
                    { 188, 35, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 44, null },
                    { 189, 42, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 1, null },
                    { 190, 43, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 90, null },
                    { 191, 39, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 34, null },
                    { 192, 46, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 94, null },
                    { 193, 9, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 100, null },
                    { 194, 91, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 9, null },
                    { 195, 93, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 82, null },
                    { 196, 53, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 49, null },
                    { 197, 11, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 3, null },
                    { 198, 82, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 11, null },
                    { 199, 25, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 51, null },
                    { 200, 100, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 89, null },
                    { 201, 87, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 99, null },
                    { 202, 44, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 49, null },
                    { 203, 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 84, null },
                    { 204, 64, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 38, null },
                    { 205, 89, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 92, null },
                    { 206, 49, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 20, null },
                    { 207, 35, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 100, null },
                    { 208, 46, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 37, null },
                    { 209, 5, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 57, null },
                    { 210, 48, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, null },
                    { 211, 78, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 32, null },
                    { 212, 57, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 75, null },
                    { 213, 68, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 97, null },
                    { 214, 25, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 45, null },
                    { 215, 7, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 65, null },
                    { 216, 20, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 79, null },
                    { 217, 89, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 72, null },
                    { 218, 11, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 39, null },
                    { 219, 1, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 31, null },
                    { 220, 86, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 65, null },
                    { 221, 26, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 23, null },
                    { 222, 10, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 96, null },
                    { 223, 42, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 83, null },
                    { 224, 75, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 62, null },
                    { 225, 71, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, null },
                    { 226, 16, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 63, null },
                    { 227, 2, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 71, null },
                    { 228, 27, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 24, null },
                    { 229, 52, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 58, null },
                    { 230, 6, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 52, null },
                    { 231, 36, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 232, 34, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 70, null },
                    { 233, 3, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 18, null },
                    { 234, 8, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 19, null },
                    { 235, 9, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 55, null },
                    { 236, 86, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 27, null },
                    { 237, 27, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 77, null },
                    { 238, 97, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 80, null },
                    { 239, 50, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 70, null },
                    { 240, 64, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 17, null },
                    { 241, 100, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 242, 85, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 47, null },
                    { 243, 45, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 66, null },
                    { 244, 74, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 4, null },
                    { 245, 19, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, null },
                    { 246, 10, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 6, null },
                    { 247, 50, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 99, null },
                    { 248, 36, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 60, null },
                    { 249, 48, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 15, null },
                    { 250, 15, new DateTime(2024, 6, 6, 9, 15, 15, 593, DateTimeKind.Utc).AddTicks(1991), "ApiNet", 10, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_PersonId",
                table: "Booking",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_RoomId",
                table: "Booking",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_PersonId",
                table: "Favorites",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_RoomId",
                table: "Favorites",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CityId",
                table: "Hotel",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_DocTypeId",
                table: "Person",
                column: "DocTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RolTypeId",
                table: "Person",
                column: "RolTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonBooking_BookingId",
                table: "PersonBooking",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonBooking_PersonId",
                table: "PersonBooking",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_HotelId",
                table: "Room",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_RoomTypeId",
                table: "Room",
                column: "RoomTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "PersonBooking");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "DocType");

            migrationBuilder.DropTable(
                name: "RolType");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
