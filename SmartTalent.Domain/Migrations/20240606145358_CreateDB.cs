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
                    { 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Bogota D.C.", null },
                    { 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Medellin", null },
                    { 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Pereira", null },
                    { 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Barranquilla", null },
                    { 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Ibague", null }
                });

            migrationBuilder.InsertData(
                table: "DocType",
                columns: new[] { "DocTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "type" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Cedula Ciudadania", null, "C.C." },
                    { 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Pasaporte", null, "PP" },
                    { 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Tarjeta Identidad", null, "T.I." },
                    { 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "NIT", null, "NIT" },
                    { 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Cedula Extranjeria", null, "C.E." }
                });

            migrationBuilder.InsertData(
                table: "RolType",
                columns: new[] { "RolTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Administrador", null },
                    { 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Cliente", null }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "RoomTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "ValuePerNight" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Basica", null, 45000.0 },
                    { 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Premium", null, 90000.0 },
                    { 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Deluxe", null, 150000.0 }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelId", "Availability", "CityId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Bartell Mews", null },
                    { 2, true, 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Agustin Knolls", null },
                    { 3, false, 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Beatty Common", null },
                    { 4, true, 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Ola Motorway", null },
                    { 5, false, 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Ebert Mills", null },
                    { 6, true, 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Aufderhar Summit", null },
                    { 7, true, 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Daisy Street", null },
                    { 8, false, 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Kariane Springs", null },
                    { 9, false, 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Aufderhar Underpass", null },
                    { 10, true, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Torp Via", null },
                    { 11, false, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Lynch Drive", null },
                    { 12, false, 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Lemke Mount", null },
                    { 13, false, 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Chaz Park", null },
                    { 14, false, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Leila Knolls", null },
                    { 15, false, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Daniela Branch", null },
                    { 16, true, 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Annabell Mills", null },
                    { 17, false, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Herzog Mill", null },
                    { 18, true, 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Mark Turnpike", null },
                    { 19, true, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Ritchie Key", null },
                    { 20, false, 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Junior Pine", null },
                    { 21, true, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Huel Well", null },
                    { 22, false, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Cartwright Turnpike", null },
                    { 23, false, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Kassulke Crescent", null },
                    { 24, false, 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Jillian Shore", null },
                    { 25, true, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", "Hotel Wehner Stream", null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Birth", "CreatedAt", "CreatedBy", "DocTypeId", "Document", "Email", "EmergencyContact", "EmergencyPhone", "FirstName", "Gender", "LastName", "Phone", "RolTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1972, 4, 16, 5, 39, 6, 61, DateTimeKind.Local).AddTicks(2206), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "197204160647", "Gladys_Bahringer@hotmail.com", "Dr. Chad Emmerich", "560.265.1256", "Gladys", "H", "Bahringer", "560.265.1256", 2, null },
                    { 2, new DateTime(1976, 9, 11, 9, 20, 4, 894, DateTimeKind.Local).AddTicks(9969), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "197609118992", "Guy21@hotmail.com", "Mrs. Randal Treutel", "542.339.8803", "Guy", "F", "Hartmann", "542.339.8803", 2, null },
                    { 3, new DateTime(1978, 7, 30, 12, 36, 14, 459, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "197807304568", "Sophia.Brakus@yahoo.com", "Miss Edmond Stiedemann", "1-774-968-5029 x4456", "Sophia", "F", "Brakus", "1-774-968-5029 x4456", 2, null },
                    { 4, new DateTime(2003, 10, 1, 11, 56, 39, 617, DateTimeKind.Local).AddTicks(8867), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "200310016142", "Bobbie_Bednar61@hotmail.com", "Miss Jeanne Mohr", "844.814.6362", "Bobbie", "I", "Bednar", "844.814.6362", 2, null },
                    { 5, new DateTime(1991, 6, 23, 11, 3, 58, 531, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "199106235345", "Evelyn.Considine61@gmail.com", "Mr. Jerome Jones", "1-620-225-7360", "Evelyn", "F", "Considine", "1-620-225-7360", 2, null },
                    { 6, new DateTime(1962, 12, 12, 11, 28, 37, 764, DateTimeKind.Local).AddTicks(5799), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "196212127697", "Rene.Larkin16@gmail.com", "Dwayne Haag Sr.", "1-539-538-8591 x18118", "Rene", "L", "Larkin", "1-539-538-8591 x18118", 2, null },
                    { 7, new DateTime(1960, 10, 4, 1, 1, 49, 846, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "196010048442", "Eva26@gmail.com", "Mr. Carrie Kutch", "1-771-813-6394 x823", "Eva", "I", "Parisian", "1-771-813-6394 x823", 2, null },
                    { 8, new DateTime(1992, 12, 20, 23, 8, 46, 83, DateTimeKind.Local).AddTicks(8321), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "199212200845", "Emily_Schuppe@hotmail.com", "Woodrow Morar Sr.", "611-554-0304", "Emily", "G", "Schuppe", "611-554-0304", 2, null },
                    { 9, new DateTime(1974, 2, 18, 6, 43, 6, 914, DateTimeKind.Local).AddTicks(4024), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "197402189133", "Brent33@gmail.com", "Ms. Brendan Johnson", "927.799.7601 x594", "Brent", "I", "Thiel", "927.799.7601 x594", 2, null },
                    { 10, new DateTime(1996, 8, 30, 1, 15, 48, 392, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "199608303922", "Silvia70@hotmail.com", "Molly Prohaska III", "205.316.3463 x4526", "Silvia", "J", "Schmeler", "205.316.3463 x4526", 2, null },
                    { 11, new DateTime(1975, 11, 2, 12, 44, 9, 998, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "197511029972", "Francis_Zulauf47@yahoo.com", "Ms. Darnell Carter", "(726) 218-7275", "Francis", "F", "Zulauf", "(726) 218-7275", 2, null },
                    { 12, new DateTime(1994, 1, 16, 10, 58, 4, 857, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "199401168555", "Van_Schamberger@hotmail.com", "Sheldon Rowe MD", "(444) 664-0123 x67901", "Van", "I", "Schamberger", "(444) 664-0123 x67901", 2, null },
                    { 13, new DateTime(1963, 1, 23, 1, 21, 11, 366, DateTimeKind.Local).AddTicks(8005), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "196301233687", "Dianne.Towne@hotmail.com", "Miss Vicki Homenick", "967-550-9113", "Dianne", "H", "Towne", "967-550-9113", 2, null },
                    { 14, new DateTime(1978, 2, 26, 17, 23, 54, 711, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "197802267125", "Rachael28@gmail.com", "Jerome Homenick Jr.", "708-386-8838", "Rachael", "H", "Koss", "708-386-8838", 2, null },
                    { 15, new DateTime(1969, 6, 8, 21, 45, 31, 293, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "196906082935", "Willis18@hotmail.com", "Delia Green I", "925-850-6920 x35574", "Willis", "K", "Gutkowski", "925-850-6920 x35574", 2, null },
                    { 16, new DateTime(1996, 7, 20, 6, 47, 40, 464, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "199607204634", "Rickey_Bailey@hotmail.com", "Ira Orn V", "1-349-773-6047 x4112", "Rickey", "K", "Bailey", "1-349-773-6047 x4112", 2, null },
                    { 17, new DateTime(1966, 12, 21, 4, 53, 18, 556, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "196612215522", "Silvia_Kris@gmail.com", "Dr. Samuel Rohan", "912-899-3538 x597", "Silvia", "G", "Kris", "912-899-3538 x597", 2, null },
                    { 18, new DateTime(1972, 9, 17, 7, 39, 51, 184, DateTimeKind.Local).AddTicks(8602), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "197209171862", "Olga25@gmail.com", "Mrs. Bridget Veum", "453.536.8234", "Olga", "K", "Jakubowski", "453.536.8234", 2, null },
                    { 19, new DateTime(1997, 11, 20, 23, 41, 5, 465, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "199711204652", "Orlando_Oberbrunner@yahoo.com", "Dr. Philip Koss", "254-784-3017 x58862", "Orlando", "G", "Oberbrunner", "254-784-3017 x58862", 2, null },
                    { 20, new DateTime(1994, 6, 3, 8, 40, 17, 76, DateTimeKind.Local).AddTicks(9834), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "199406030735", "Alberto49@yahoo.com", "Margaret Lowe DDS", "546.441.2283", "Alberto", "I", "Koelpin", "546.441.2283", 2, null },
                    { 21, new DateTime(1986, 12, 15, 4, 13, 47, 684, DateTimeKind.Local).AddTicks(3637), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "198612156813", "Christopher.Kiehn89@gmail.com", "Bruce Prohaska I", "920.636.1880 x5477", "Christopher", "G", "Kiehn", "920.636.1880 x5477", 2, null },
                    { 22, new DateTime(2000, 9, 27, 23, 24, 33, 229, DateTimeKind.Local).AddTicks(1109), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "200009272279", "Christopher83@hotmail.com", "Miss Florence Schmidt", "(596) 671-5469 x715", "Christopher", "G", "Morar", "(596) 671-5469 x715", 2, null },
                    { 23, new DateTime(1982, 7, 3, 2, 3, 32, 931, DateTimeKind.Local).AddTicks(4376), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "198207039341", "Kellie_Towne@hotmail.com", "Linda Davis Sr.", "1-970-348-4882 x63520", "Kellie", "L", "Towne", "1-970-348-4882 x63520", 2, null },
                    { 24, new DateTime(1981, 6, 10, 21, 39, 27, 165, DateTimeKind.Local).AddTicks(220), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "198106101671", "Luke.Denesik17@gmail.com", "Josh McLaughlin I", "531-274-3479", "Luke", "L", "Denesik", "531-274-3479", 2, null },
                    { 25, new DateTime(1969, 1, 18, 10, 11, 14, 46, DateTimeKind.Local).AddTicks(572), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "196901180411", "Clayton.Botsford@yahoo.com", "Nelson Rodriguez MD", "250-207-7820", "Clayton", "I", "Botsford", "250-207-7820", 2, null },
                    { 26, new DateTime(1954, 11, 3, 15, 23, 52, 288, DateTimeKind.Local).AddTicks(5314), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195411032823", "Sylvia.Strosin@gmail.com", "Lowell Waelchi PhD", "659.631.9544", "Sylvia", "G", "Strosin", "659.631.9544", 2, null },
                    { 27, new DateTime(1972, 10, 11, 22, 21, 54, 214, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "197210112160", "Lila59@yahoo.com", "Ms. Luz Kuhlman", "888-271-8614", "Lila", "H", "Adams", "888-271-8614", 2, null },
                    { 28, new DateTime(1988, 11, 3, 18, 40, 5, 198, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "198811031932", "Harry.Kutch2@hotmail.com", "Monica Collier II", "1-265-705-7355", "Harry", "I", "Kutch", "1-265-705-7355", 2, null },
                    { 29, new DateTime(1969, 1, 29, 11, 40, 21, 950, DateTimeKind.Local).AddTicks(3772), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "196901299575", "Darrel.Hettinger21@hotmail.com", "Lucille Johnson II", "653.783.6407 x24753", "Darrel", "K", "Hettinger", "653.783.6407 x24753", 2, null },
                    { 30, new DateTime(1979, 1, 16, 13, 0, 3, 754, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "197901167598", "Doyle4@hotmail.com", "Dr. Stacy Brekke", "679.816.9051 x421", "Doyle", "L", "Morissette", "679.816.9051 x421", 2, null },
                    { 31, new DateTime(1975, 1, 23, 2, 48, 50, 854, DateTimeKind.Local).AddTicks(1620), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "197501238567", "Cristina58@gmail.com", "Ms. Christopher Turner", "(269) 616-1283 x14269", "Cristina", "I", "Smith", "(269) 616-1283 x14269", 2, null },
                    { 32, new DateTime(2003, 4, 25, 8, 26, 34, 719, DateTimeKind.Local).AddTicks(2171), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "200304257124", "Lula.Tremblay33@hotmail.com", "Laurence Romaguera II", "276-643-9065 x0094", "Lula", "K", "Tremblay", "276-643-9065 x0094", 2, null },
                    { 33, new DateTime(1956, 7, 23, 15, 37, 17, 512, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "195607235115", "Arthur99@gmail.com", "Wilfred Kuhlman IV", "221.486.6575", "Arthur", "F", "Daugherty", "221.486.6575", 2, null },
                    { 34, new DateTime(1991, 4, 8, 17, 30, 42, 781, DateTimeKind.Local).AddTicks(1363), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "199104087821", "Myra_Frami@hotmail.com", "Kristen Wolf IV", "375.472.8083 x1479", "Myra", "K", "Frami", "375.472.8083 x1479", 2, null },
                    { 35, new DateTime(1961, 8, 26, 16, 40, 1, 496, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "196108264943", "Suzanne.Quigley@hotmail.com", "Christopher Casper MD", "(564) 497-0874 x6276", "Suzanne", "F", "Quigley", "(564) 497-0874 x6276", 2, null },
                    { 36, new DateTime(1987, 2, 17, 15, 2, 29, 71, DateTimeKind.Local).AddTicks(8948), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "198702170740", "Georgia_Ullrich@gmail.com", "Dr. Nichole Bode", "1-632-399-4780", "Georgia", "H", "Ullrich", "1-632-399-4780", 2, null },
                    { 37, new DateTime(1958, 7, 23, 15, 21, 30, 292, DateTimeKind.Local).AddTicks(6554), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195807232953", "Darren29@hotmail.com", "Miss Arturo Schamberger", "1-896-729-9293 x3737", "Darren", "G", "Pfannerstill", "1-896-729-9293 x3737", 2, null },
                    { 38, new DateTime(1957, 6, 5, 0, 42, 45, 257, DateTimeKind.Local).AddTicks(873), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "195706052585", "Marlene_Fay94@yahoo.com", "Ms. Maryann Haley", "658-798-9337 x7228", "Marlene", "H", "Fay", "658-798-9337 x7228", 2, null },
                    { 39, new DateTime(1960, 1, 3, 10, 55, 29, 19, DateTimeKind.Local).AddTicks(5679), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "196001030193", "Gregory_Bechtelar43@yahoo.com", "Wanda Collins V", "729.830.4268 x00627", "Gregory", "H", "Bechtelar", "729.830.4268 x00627", 2, null },
                    { 40, new DateTime(1984, 6, 29, 19, 19, 3, 845, DateTimeKind.Local).AddTicks(233), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "198406298466", "Nichole.Harvey85@hotmail.com", "Mr. Adam Grant", "1-972-995-5914", "Nichole", "G", "Harvey", "1-972-995-5914", 2, null },
                    { 41, new DateTime(1970, 3, 18, 8, 58, 6, 907, DateTimeKind.Local).AddTicks(81), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "197003189045", "Lynette.Marvin@yahoo.com", "Ms. Garry Schumm", "282-323-9849 x05009", "Lynette", "I", "Marvin", "282-323-9849 x05009", 2, null },
                    { 42, new DateTime(1988, 12, 27, 9, 48, 19, 147, DateTimeKind.Local).AddTicks(6665), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "198812271446", "Tina_Littel32@hotmail.com", "Mrs. Franklin Wuckert", "(873) 463-8807 x2479", "Tina", "J", "Littel", "(873) 463-8807 x2479", 2, null },
                    { 43, new DateTime(1969, 8, 9, 16, 34, 0, 761, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "196908097626", "Tracey99@yahoo.com", "Ms. Grace Stamm", "(605) 521-2307 x803", "Tracey", "F", "Hermann", "(605) 521-2307 x803", 2, null },
                    { 44, new DateTime(2000, 7, 5, 21, 20, 52, 886, DateTimeKind.Local).AddTicks(6139), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "200007058860", "Blanche.Klein@yahoo.com", "Mrs. Ellen Pagac", "419-222-7779", "Blanche", "H", "Klein", "419-222-7779", 2, null },
                    { 45, new DateTime(1998, 5, 11, 14, 22, 34, 701, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "199805117075", "Alan_Schuster20@yahoo.com", "Dr. Max Maggio", "(737) 654-0509", "Alan", "I", "Schuster", "(737) 654-0509", 2, null },
                    { 46, new DateTime(2001, 4, 27, 21, 51, 51, 824, DateTimeKind.Local).AddTicks(7805), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "200104278247", "Carolyn9@gmail.com", "Percy Harris II", "1-469-778-3010 x0516", "Carolyn", "H", "Langosh", "1-469-778-3010 x0516", 2, null },
                    { 47, new DateTime(1955, 3, 9, 17, 43, 7, 817, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195503098187", "Pearl.Ritchie@yahoo.com", "Dr. Ivan DuBuque", "1-560-342-1920", "Pearl", "K", "Ritchie", "1-560-342-1920", 2, null },
                    { 48, new DateTime(1962, 5, 15, 3, 9, 41, 934, DateTimeKind.Local).AddTicks(3686), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "196205159368", "Lisa.Sanford@hotmail.com", "Carol Botsford PhD", "841-902-1814 x156", "Lisa", "K", "Sanford", "841-902-1814 x156", 2, null },
                    { 49, new DateTime(1980, 10, 14, 22, 5, 9, 121, DateTimeKind.Local).AddTicks(1336), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "198010141227", "Flora.Quitzon@hotmail.com", "Dr. Eddie Stiedemann", "1-938-208-1788", "Flora", "H", "Quitzon", "1-938-208-1788", 2, null },
                    { 50, new DateTime(1997, 7, 13, 4, 6, 26, 657, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "199707136553", "Emanuel.Morar@yahoo.com", "Franklin Kling PhD", "1-772-524-3046 x544", "Emanuel", "K", "Morar", "1-772-524-3046 x544", 2, null },
                    { 51, new DateTime(1978, 7, 20, 15, 40, 30, 119, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "197807201194", "Dennis_Stark44@gmail.com", "Noah Beatty I", "1-242-916-9842 x668", "Dennis", "J", "Stark", "1-242-916-9842 x668", 2, null },
                    { 52, new DateTime(1983, 3, 16, 12, 56, 49, 404, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "198303164068", "Lena.Waters44@gmail.com", "Mr. Rolando Kirlin", "1-832-972-7176", "Lena", "G", "Waters", "1-832-972-7176", 2, null },
                    { 53, new DateTime(1973, 10, 23, 5, 18, 18, 990, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "197310239947", "Blanche30@hotmail.com", "Mrs. Tyler Goldner", "1-989-273-6844", "Blanche", "L", "Reilly", "1-989-273-6844", 2, null },
                    { 54, new DateTime(1957, 9, 30, 1, 52, 1, 426, DateTimeKind.Local).AddTicks(737), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195709304264", "Marion47@hotmail.com", "Mr. Delbert Mann", "847-411-7958 x44225", "Marion", "F", "Gottlieb", "847-411-7958 x44225", 2, null },
                    { 55, new DateTime(2004, 3, 30, 12, 29, 19, 572, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "200403305758", "Donald.Bruen@yahoo.com", "Dr. Jan Kulas", "611.743.6524 x7984", "Donald", "G", "Bruen", "611.743.6524 x7984", 2, null },
                    { 56, new DateTime(1967, 1, 5, 0, 49, 23, 111, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "196701051119", "Frederick99@hotmail.com", "Earnest Lakin DVM", "1-830-802-8848 x23166", "Frederick", "F", "Schulist", "1-830-802-8848 x23166", 2, null },
                    { 57, new DateTime(1979, 4, 10, 10, 22, 16, 497, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "197904104986", "Tiffany90@gmail.com", "Leo Hettinger V", "(921) 479-7922 x758", "Tiffany", "H", "Grady", "(921) 479-7922 x758", 2, null },
                    { 58, new DateTime(1990, 7, 1, 6, 20, 19, 897, DateTimeKind.Local).AddTicks(5698), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "199007018980", "Sheri_Lang65@gmail.com", "Elmer Hegmann III", "462-914-4575 x4424", "Sheri", "F", "Lang", "462-914-4575 x4424", 2, null },
                    { 59, new DateTime(1972, 7, 28, 11, 4, 54, 462, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "197207284691", "Jean.Hirthe@hotmail.com", "Jodi Mertz Jr.", "(907) 579-9055", "Jean", "I", "Hirthe", "(907) 579-9055", 2, null },
                    { 60, new DateTime(1957, 10, 20, 11, 11, 36, 174, DateTimeKind.Local).AddTicks(3883), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195710201723", "Rosemary_Simonis@hotmail.com", "Robyn Lockman IV", "378-713-9890 x2619", "Rosemary", "G", "Simonis", "378-713-9890 x2619", 2, null },
                    { 61, new DateTime(1966, 5, 6, 6, 9, 53, 120, DateTimeKind.Local).AddTicks(3882), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "196605061248", "Ella33@hotmail.com", "Mrs. Bertha Marquardt", "(289) 253-9529 x237", "Ella", "H", "Carter", "(289) 253-9529 x237", 2, null },
                    { 62, new DateTime(1957, 4, 21, 10, 9, 29, 154, DateTimeKind.Local).AddTicks(7448), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195704211563", "Katie.Stokes50@yahoo.com", "Lena Conn III", "1-594-812-1292 x8745", "Katie", "F", "Stokes", "1-594-812-1292 x8745", 2, null },
                    { 63, new DateTime(1982, 9, 27, 2, 28, 45, 530, DateTimeKind.Local).AddTicks(2732), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "198209275364", "Paula15@hotmail.com", "Dr. Wm Fisher", "697-453-5766", "Paula", "I", "Toy", "697-453-5766", 2, null },
                    { 64, new DateTime(1962, 6, 30, 22, 58, 2, 77, DateTimeKind.Local).AddTicks(4824), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "196206300771", "Bennie_Marks27@gmail.com", "Jimmie Wunsch I", "1-607-915-4655 x97723", "Bennie", "G", "Marks", "1-607-915-4655 x97723", 2, null },
                    { 65, new DateTime(1974, 10, 23, 15, 19, 42, 682, DateTimeKind.Local).AddTicks(9906), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "197410236868", "Dixie_Luettgen@gmail.com", "Patricia Bogan DDS", "1-228-235-7760 x471", "Dixie", "K", "Luettgen", "1-228-235-7760 x471", 2, null },
                    { 66, new DateTime(1992, 6, 13, 1, 16, 42, 111, DateTimeKind.Local).AddTicks(9109), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "199206131188", "Angel23@gmail.com", "Harvey Wisozk III", "786.999.9437 x1336", "Angel", "J", "Romaguera", "786.999.9437 x1336", 2, null },
                    { 67, new DateTime(1966, 12, 22, 13, 17, 20, 132, DateTimeKind.Local).AddTicks(5267), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "196612221371", "Gregg.McGlynn11@hotmail.com", "Byron Wintheiser MD", "(952) 987-6991", "Gregg", "G", "McGlynn", "(952) 987-6991", 2, null },
                    { 68, new DateTime(1991, 11, 23, 12, 44, 15, 66, DateTimeKind.Local).AddTicks(1450), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "199111230638", "Howard60@gmail.com", "Grace Hegmann III", "1-584-426-7755", "Howard", "K", "Gulgowski", "1-584-426-7755", 2, null },
                    { 69, new DateTime(1960, 11, 2, 16, 55, 7, 470, DateTimeKind.Local).AddTicks(1797), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "196011024723", "Diana1@hotmail.com", "Nora Cartwright V", "(204) 953-7135", "Diana", "K", "Hartmann", "(204) 953-7135", 2, null },
                    { 70, new DateTime(1970, 6, 13, 21, 45, 52, 228, DateTimeKind.Local).AddTicks(7864), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "197006132299", "Erick90@hotmail.com", "Gene Moore Sr.", "(304) 448-5426 x171", "Erick", "G", "Von", "(304) 448-5426 x171", 2, null },
                    { 71, new DateTime(1961, 5, 7, 8, 38, 21, 582, DateTimeKind.Local).AddTicks(8472), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "196105075839", "Arthur.Will@yahoo.com", "Nelson Baumbach DDS", "794-941-2640 x4762", "Arthur", "K", "Will", "794-941-2640 x4762", 2, null },
                    { 72, new DateTime(1967, 11, 9, 3, 48, 46, 271, DateTimeKind.Local).AddTicks(5688), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "196711092780", "Kara.Jakubowski74@gmail.com", "Ms. Vicky Beier", "201.630.7241 x14409", "Kara", "J", "Jakubowski", "201.630.7241 x14409", 2, null },
                    { 73, new DateTime(1980, 10, 17, 19, 26, 45, 946, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "198010179466", "Camille.Lowe90@yahoo.com", "Miss Gerald Brown", "1-758-204-5134 x64160", "Camille", "K", "Lowe", "1-758-204-5134 x64160", 2, null },
                    { 74, new DateTime(1986, 12, 12, 18, 28, 22, 294, DateTimeKind.Local).AddTicks(3842), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "198612122948", "Tabitha.Brown@gmail.com", "Johnny Hodkiewicz Sr.", "(467) 235-2463", "Tabitha", "I", "Brown", "(467) 235-2463", 2, null },
                    { 75, new DateTime(1968, 1, 10, 19, 14, 17, 999, DateTimeKind.Local).AddTicks(624), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "196801109957", "Benny_Emmerich36@hotmail.com", "Ms. Freda Denesik", "1-813-998-3230", "Benny", "H", "Emmerich", "1-813-998-3230", 2, null },
                    { 76, new DateTime(1968, 11, 23, 5, 4, 28, 903, DateTimeKind.Local).AddTicks(5647), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "196811239042", "Beatrice_Lubowitz@yahoo.com", "Mr. Robin Murray", "935-546-1079", "Beatrice", "J", "Lubowitz", "935-546-1079", 2, null },
                    { 77, new DateTime(1955, 7, 1, 11, 37, 41, 89, DateTimeKind.Local).AddTicks(2156), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195507010873", "Kurt.Nienow@gmail.com", "Guillermo Rolfson V", "1-453-469-6479 x36599", "Kurt", "F", "Nienow", "1-453-469-6479 x36599", 2, null },
                    { 78, new DateTime(1992, 9, 13, 23, 27, 52, 969, DateTimeKind.Local).AddTicks(2844), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "199209139642", "Marcia_Ullrich@gmail.com", "Dr. Abel Lind", "1-299-972-8645 x18475", "Marcia", "H", "Ullrich", "1-299-972-8645 x18475", 2, null },
                    { 79, new DateTime(1956, 7, 24, 23, 40, 21, 295, DateTimeKind.Local).AddTicks(3123), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195607242962", "Bessie.Durgan@yahoo.com", "Mr. Perry Jast", "1-343-556-6287 x5918", "Bessie", "K", "Durgan", "1-343-556-6287 x5918", 2, null },
                    { 80, new DateTime(1955, 4, 30, 11, 14, 9, 150, DateTimeKind.Local).AddTicks(167), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "195504301580", "Ruby.Hettinger48@yahoo.com", "Frank Herman II", "236.901.2320 x63936", "Ruby", "F", "Hettinger", "236.901.2320 x63936", 2, null },
                    { 81, new DateTime(1997, 6, 5, 16, 39, 38, 848, DateTimeKind.Local).AddTicks(1375), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "199706058477", "Robin.Homenick85@yahoo.com", "Alma Crooks V", "1-518-556-5848", "Robin", "J", "Homenick", "1-518-556-5848", 2, null },
                    { 82, new DateTime(1987, 2, 17, 2, 44, 39, 115, DateTimeKind.Local).AddTicks(3798), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "198702171169", "Olivia.Buckridge@yahoo.com", "Ms. Van Graham", "1-266-593-3511 x6648", "Olivia", "L", "Buckridge", "1-266-593-3511 x6648", 2, null },
                    { 83, new DateTime(1981, 5, 25, 3, 57, 6, 901, DateTimeKind.Local).AddTicks(7583), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "198105259033", "Brian.Bartoletti54@yahoo.com", "Ms. Jo Swaniawski", "(639) 819-9306 x60335", "Brian", "L", "Bartoletti", "(639) 819-9306 x60335", 2, null },
                    { 84, new DateTime(1956, 7, 29, 13, 1, 19, 658, DateTimeKind.Local).AddTicks(2072), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "195607296513", "Santiago.Kihn13@gmail.com", "Mr. Lee Conn", "(367) 640-0631", "Santiago", "G", "Kihn", "(367) 640-0631", 2, null },
                    { 85, new DateTime(2002, 3, 22, 13, 48, 24, 257, DateTimeKind.Local).AddTicks(4090), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "200203222583", "Rebecca_Cruickshank0@gmail.com", "Dr. Alberta Bruen", "(903) 502-8104 x0143", "Rebecca", "I", "Cruickshank", "(903) 502-8104 x0143", 2, null },
                    { 86, new DateTime(1966, 10, 28, 9, 1, 7, 773, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "196610287762", "Mona.Murray@yahoo.com", "Dr. Gerardo Ledner", "838.837.6741", "Mona", "K", "Murray", "838.837.6741", 2, null },
                    { 87, new DateTime(1989, 6, 5, 3, 35, 22, 187, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "198906051829", "Evelyn_Klocko91@yahoo.com", "Colin Kuhlman IV", "(464) 869-5400 x7731", "Evelyn", "I", "Klocko", "(464) 869-5400 x7731", 2, null },
                    { 88, new DateTime(1963, 11, 1, 14, 17, 29, 32, DateTimeKind.Local).AddTicks(419), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "196311010364", "Leticia.Torphy@hotmail.com", "Mr. Susie Deckow", "1-528-249-2284 x62920", "Leticia", "G", "Torphy", "1-528-249-2284 x62920", 2, null },
                    { 89, new DateTime(1970, 3, 6, 3, 57, 37, 126, DateTimeKind.Local).AddTicks(2721), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "197003061244", "Andrea.Windler80@hotmail.com", "Joseph Skiles DDS", "1-948-967-6284 x19237", "Andrea", "K", "Windler", "1-948-967-6284 x19237", 2, null },
                    { 90, new DateTime(1963, 8, 5, 6, 35, 2, 223, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "196308052254", "Israel76@yahoo.com", "Miss Morris Paucek", "719-644-7623 x6887", "Israel", "F", "Sanford", "719-644-7623 x6887", 2, null },
                    { 91, new DateTime(1962, 4, 8, 10, 17, 52, 65, DateTimeKind.Local).AddTicks(1998), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "196204080672", "Clayton_Beer95@gmail.com", "Tamara Orn V", "249-787-5697", "Clayton", "I", "Beer", "249-787-5697", 2, null },
                    { 92, new DateTime(1976, 12, 9, 23, 21, 16, 692, DateTimeKind.Local).AddTicks(9670), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "197612096920", "Helen_Carroll@yahoo.com", "Allison Dietrich IV", "1-433-700-4935 x53988", "Helen", "F", "Carroll", "1-433-700-4935 x53988", 2, null },
                    { 93, new DateTime(1979, 7, 4, 9, 57, 31, 708, DateTimeKind.Local).AddTicks(755), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "197907047067", "Christine_Adams@hotmail.com", "Hattie Ruecker Jr.", "226.425.1973 x6226", "Christine", "F", "Adams", "226.425.1973 x6226", 2, null },
                    { 94, new DateTime(1997, 9, 28, 5, 50, 54, 272, DateTimeKind.Local).AddTicks(1626), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "199709282728", "Claudia_Torp41@hotmail.com", "Ms. Seth Collins", "658-774-4221", "Claudia", "F", "Torp", "658-774-4221", 2, null },
                    { 95, new DateTime(1973, 11, 28, 5, 59, 12, 565, DateTimeKind.Local).AddTicks(9649), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, "197311285618", "William_Spencer@hotmail.com", "Horace Gutkowski I", "(866) 765-2677 x26032", "William", "G", "Spencer", "(866) 765-2677 x26032", 2, null },
                    { 96, new DateTime(1962, 5, 30, 22, 58, 19, 10, DateTimeKind.Local).AddTicks(5809), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "196205300129", "Nadine.Wisozk53@gmail.com", "Erika West I", "1-470-454-3186 x10704", "Nadine", "G", "Wisozk", "1-470-454-3186 x10704", 2, null },
                    { 97, new DateTime(1954, 10, 10, 4, 50, 10, 283, DateTimeKind.Local).AddTicks(7753), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, "195410102874", "Charles_Metz@yahoo.com", "Miss Todd Labadie", "(604) 632-9628 x243", "Charles", "J", "Metz", "(604) 632-9628 x243", 2, null },
                    { 98, new DateTime(1968, 10, 26, 16, 36, 46, 977, DateTimeKind.Local).AddTicks(9185), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, "196810269735", "Dennis_Rowe13@hotmail.com", "Dr. Brett Rohan", "408.961.2479 x240", "Dennis", "L", "Rowe", "408.961.2479 x240", 2, null },
                    { 99, new DateTime(1967, 2, 21, 10, 3, 45, 345, DateTimeKind.Local).AddTicks(3137), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, "196702213437", "Reginald61@yahoo.com", "Mr. Sergio West", "1-672-231-9748 x8785", "Reginald", "H", "Watsica", "1-672-231-9748 x8785", 2, null },
                    { 100, new DateTime(1962, 12, 20, 15, 4, 1, 261, DateTimeKind.Local).AddTicks(4962), new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, "196212202664", "Helen77@yahoo.com", "Emily Blick IV", "(625) 944-3892 x903", "Helen", "J", "Corwin", "(625) 944-3892 x903", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "Availability", "CreatedAt", "CreatedBy", "HotelId", "MaxGuest", "RoomNumber", "RoomTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 3, "P26", 2, null },
                    { 2, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 6, 3, "N64", 1, null },
                    { 3, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 9, 3, "O87", 1, null },
                    { 4, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 14, 4, "P95", 3, null },
                    { 5, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, 4, "M63", 2, null },
                    { 6, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 16, 2, "M53", 1, null },
                    { 7, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, 2, "S55", 2, null },
                    { 8, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, 1, "V69", 2, null },
                    { 9, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 15, 4, "Q71", 2, null },
                    { 10, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 3, "E80", 3, null },
                    { 11, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, 3, "P43", 3, null },
                    { 12, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, 3, "N91", 1, null },
                    { 13, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, 1, "E31", 3, null },
                    { 14, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, 1, "X9", 1, null },
                    { 15, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 22, 3, "X88", 3, null },
                    { 16, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 16, 2, "V89", 1, null },
                    { 17, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 9, 4, "Y2", 1, null },
                    { 18, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 6, 1, "F50", 2, null },
                    { 19, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, 2, "S9", 1, null },
                    { 20, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, 1, "F58", 3, null },
                    { 21, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 9, 3, "V6", 3, null },
                    { 22, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, 1, "S15", 1, null },
                    { 23, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 2, "G55", 3, null },
                    { 24, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, 3, "L14", 2, null },
                    { 25, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 6, 4, "V5", 3, null },
                    { 26, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, 4, "P93", 2, null },
                    { 27, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, 1, "W5", 3, null },
                    { 28, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, 1, "I95", 3, null },
                    { 29, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, 1, "B17", 1, null },
                    { 30, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, 4, "D4", 3, null },
                    { 31, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 11, 2, "E14", 1, null },
                    { 32, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, 4, "R93", 1, null },
                    { 33, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 2, "E68", 2, null },
                    { 34, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 6, 3, "W29", 1, null },
                    { 35, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, 2, "H95", 2, null },
                    { 36, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 1, "H74", 2, null },
                    { 37, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 3, "I91", 2, null },
                    { 38, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, 2, "O95", 3, null },
                    { 39, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 4, "D8", 1, null },
                    { 40, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 20, 4, "M85", 2, null },
                    { 41, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 14, 2, "U19", 2, null },
                    { 42, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 3, "Y43", 3, null },
                    { 43, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, 1, "C18", 3, null },
                    { 44, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, 4, "O8", 3, null },
                    { 45, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 8, 1, "L97", 1, null },
                    { 46, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 3, "X36", 2, null },
                    { 47, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 4, "P53", 3, null },
                    { 48, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 9, 3, "W30", 2, null },
                    { 49, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 22, 3, "D19", 1, null },
                    { 50, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 16, 3, "K51", 3, null },
                    { 51, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, 3, "Z46", 3, null },
                    { 52, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, 4, "O98", 3, null },
                    { 53, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, 2, "U10", 1, null },
                    { 54, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, 4, "H17", 1, null },
                    { 55, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, 2, "B18", 2, null },
                    { 56, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, 4, "W79", 2, null },
                    { 57, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 8, 4, "K45", 1, null },
                    { 58, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, 1, "N94", 2, null },
                    { 59, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, 2, "W39", 1, null },
                    { 60, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, 2, "G21", 2, null },
                    { 61, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 14, 2, "K22", 2, null },
                    { 62, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 9, 4, "M26", 1, null },
                    { 63, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 13, 2, "L39", 3, null },
                    { 64, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 2, "V45", 1, null },
                    { 65, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 1, "K75", 1, null },
                    { 66, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 25, 4, "G41", 1, null },
                    { 67, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 1, "C58", 3, null },
                    { 68, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 15, 4, "N91", 3, null },
                    { 69, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 22, 2, "Q81", 3, null },
                    { 70, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 2, "D90", 1, null },
                    { 71, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 12, 4, "W43", 3, null },
                    { 72, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 2, "Z60", 1, null },
                    { 73, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 6, 2, "C40", 2, null },
                    { 74, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, 3, "Y71", 2, null },
                    { 75, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 8, 1, "G34", 2, null },
                    { 76, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 4, "U23", 2, null },
                    { 77, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 13, 2, "V16", 1, null },
                    { 78, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 20, 1, "F98", 3, null },
                    { 79, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 4, "Y38", 2, null },
                    { 80, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 4, "G81", 1, null },
                    { 81, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 16, 4, "C68", 3, null },
                    { 82, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 22, 1, "Q22", 3, null },
                    { 83, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, 4, "G0", 2, null },
                    { 84, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 20, 3, "U66", 3, null },
                    { 85, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, 3, "I73", 3, null },
                    { 86, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, 2, "Y44", 2, null },
                    { 87, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 2, "B19", 1, null },
                    { 88, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, 1, "Y70", 3, null },
                    { 89, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 4, "P12", 2, null },
                    { 90, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 14, 2, "X37", 2, null },
                    { 91, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 12, 4, "W25", 3, null },
                    { 92, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 2, "M25", 3, null },
                    { 93, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, 2, "S20", 3, null },
                    { 94, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, 2, "V85", 2, null },
                    { 95, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 1, "Z19", 1, null },
                    { 96, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 16, 3, "L83", 1, null },
                    { 97, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 12, 3, "E33", 2, null },
                    { 98, false, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 2, "O91", 1, null },
                    { 99, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 1, "U25", 1, null },
                    { 100, true, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 3, "H51", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "Availability", "BaseCost", "Code", "CreatedAt", "CreatedBy", "EndDate", "PersonId", "RoomId", "StarDate", "Tax", "Total", "TotalGuest", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, 0.0, "NZAMGP", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 41, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 2, false, 0.0, "ESABNX", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 73, 82, new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 3, false, 0.0, "FEUZAN", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, 59, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 4, true, 0.0, "XNEGHK", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 33, new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 5, false, 0.0, "EQIBNR", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 3, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 6, false, 0.0, "XGOTCF", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 52, 74, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 7, false, 0.0, "AREGNO", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 55, new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 8, true, 0.0, "LEUNRX", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 12, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 9, false, 0.0, "JPUGWD", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 84, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 10, false, 0.0, "PAUDKW", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 83, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 11, false, 0.0, "OBETAK", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 26, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 12, true, 0.0, "URULUE", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 29, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 13, true, 0.0, "BLUBQL", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 92, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 14, true, 0.0, "VREKRH", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 25, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 15, true, 0.0, "XOUPFZ", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 27, new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 16, false, 0.0, "TNALID", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 89, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 17, true, 0.0, "ENEKPA", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 29, new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 18, true, 0.0, "VJERSR", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 75, new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 19, false, 0.0, "RXOZRV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 52, new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 20, true, 0.0, "RFIVGS", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 70, new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 21, false, 0.0, "NBUTZD", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 26, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 22, true, 0.0, "KVUILG", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 53, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 23, true, 0.0, "ZXOFJA", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 37, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 24, false, 0.0, "NWOBSV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 2, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 25, true, 0.0, "URIGBV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 75, 51, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 26, false, 0.0, "LIERUU", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 51, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 27, false, 0.0, "NJUNLV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 31, new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 28, true, 0.0, "VIUNUT", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 67, 78, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 29, false, 0.0, "ZSUFOC", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 51, new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 30, true, 0.0, "DNIGFK", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 69, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 31, false, 0.0, "ECECIE", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 44, new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 32, true, 0.0, "PTEYEG", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 16, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 33, false, 0.0, "XOABBG", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 55, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 34, true, 0.0, "WPEPLM", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 3, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 35, true, 0.0, "QXOKIU", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 64, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 36, true, 0.0, "AUOAER", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 22, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 37, true, 0.0, "WYIUSE", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 68, new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 38, true, 0.0, "TVATVA", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 66, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 39, true, 0.0, "CKISSZ", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 40, new DateTime(2024, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 40, false, 0.0, "AMICRT", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 82, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 41, true, 0.0, "GNOSRN", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 46, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 42, true, 0.0, "FFIUMV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 6, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 43, true, 0.0, "EHOMCV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 30, new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 44, true, 0.0, "JKOTFS", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 25, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 45, true, 0.0, "OFEBFT", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 13, new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 46, false, 0.0, "MPOMVI", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 8, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 47, true, 0.0, "YROAXJ", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 39, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 48, false, 0.0, "IDITRY", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 30, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 49, false, 0.0, "ESASLV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 8, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 50, false, 0.0, "IRUFRR", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 81, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 51, true, 0.0, "JIEBUA", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 71, new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 52, true, 0.0, "DCUTHU", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 79, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 53, false, 0.0, "ZGACRA", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 80, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 54, true, 0.0, "FGANGE", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 66, new DateTime(2024, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 55, true, 0.0, "IJAPSW", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 80, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 56, true, 0.0, "RJUCRC", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 66, 14, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 57, true, 0.0, "HREGTG", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 35, 77, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 58, true, 0.0, "NSIPML", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 16, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 59, false, 0.0, "MXOSXH", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 50, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 60, true, 0.0, "GKUPNP", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 26, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 61, false, 0.0, "BXEGHE", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 26, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 62, false, 0.0, "ZJEAIZ", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 17, new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 63, false, 0.0, "HCUPKE", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 95, 93, new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 64, false, 0.0, "PFULIN", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 71, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 65, true, 0.0, "OLAILA", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 82, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 66, false, 0.0, "UDIVIU", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 65, new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 67, false, 0.0, "EHOGIF", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 66, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 68, false, 0.0, "WIADDV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 51, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 69, true, 0.0, "BKOCXK", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 8, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 70, true, 0.0, "ROOMVS", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 34, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 71, true, 0.0, "CTESRJ", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 9, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 72, false, 0.0, "QIASJI", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 93, 36, new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 73, true, 0.0, "CYUSUD", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 13, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 74, true, 0.0, "ANECNU", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 51, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 75, false, 0.0, "XMEFMK", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 60, new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 76, false, 0.0, "QFEBYC", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 1, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 77, true, 0.0, "ANAGNR", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 58, new DateTime(2024, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 78, true, 0.0, "VKOGYY", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 56, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 79, true, 0.0, "FIUMGR", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 53, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 80, false, 0.0, "GEANRR", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 1, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 81, false, 0.0, "MEUMSI", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 4, new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 82, true, 0.0, "ZKEVGZ", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 74, new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 83, false, 0.0, "LFEBIS", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 99, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 84, false, 0.0, "ORISNX", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 90, 4, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 85, false, 0.0, "YDUSCV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, 95, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 86, true, 0.0, "KKUKPI", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 96, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 87, true, 0.0, "WVEAUB", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 54, 75, new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 88, true, 0.0, "RKEWSR", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 36, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 89, false, 0.0, "YQESJV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, 25, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 90, false, 0.0, "GAAHRV", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 67, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 91, true, 0.0, "NQODDB", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 65, 98, new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 92, false, 0.0, "PXIECX", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 15, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 93, false, 0.0, "ITUAQL", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 68, 62, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 94, false, 0.0, "FBUKIP", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 54, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 95, false, 0.0, "CPABTC", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 39, 98, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 96, false, 0.0, "URABTT", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 38, new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 97, false, 0.0, "BRITDD", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 50, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 98, false, 0.0, "INILRH", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 36, 45, new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 99, true, 0.0, "ZNOBWR", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 58, 45, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 100, false, 0.0, "FUIKRC", new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 56, 1, new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "FavoritesId", "CreatedAt", "CreatedBy", "PersonId", "RoomId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, 59, null },
                    { 2, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 31, 5, null },
                    { 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 79, 9, null },
                    { 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 80, 31, null },
                    { 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 6, null },
                    { 6, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 23, 91, null },
                    { 7, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 43, 26, null },
                    { 8, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 88, 24, null },
                    { 9, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 75, 33, null },
                    { 10, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 48, 47, null },
                    { 11, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 91, 62, null },
                    { 12, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 11, 68, null },
                    { 13, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 36, 56, null },
                    { 14, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 85, 82, null },
                    { 15, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 96, 22, null },
                    { 16, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 49, 69, null },
                    { 17, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 54, 65, null },
                    { 18, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 73, 45, null },
                    { 19, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 22, 8, null },
                    { 20, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, 91, null },
                    { 21, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 91, 16, null },
                    { 22, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 40, 27, null },
                    { 23, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 35, 68, null },
                    { 24, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 64, 78, null },
                    { 25, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 67, 48, null },
                    { 26, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 34, 42, null },
                    { 27, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 72, 24, null },
                    { 28, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 26, 70, null },
                    { 29, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 60, 14, null },
                    { 30, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 50, 64, null },
                    { 31, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 43, 7, null },
                    { 32, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, 57, null },
                    { 33, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 27, 87, null },
                    { 34, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 57, 44, null },
                    { 35, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 96, 20, null },
                    { 36, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 28, 34, null },
                    { 37, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 13, 23, null },
                    { 38, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, 95, null },
                    { 39, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, 67, null },
                    { 40, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 92, 86, null },
                    { 41, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 49, 16, null },
                    { 42, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 72, 79, null },
                    { 43, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 72, 70, null },
                    { 44, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 47, 37, null },
                    { 45, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, 13, null },
                    { 46, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 85, 91, null },
                    { 47, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 85, 78, null },
                    { 48, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, 50, null },
                    { 49, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, 69, null },
                    { 50, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, 53, null },
                    { 51, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 2, null },
                    { 52, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 42, 52, null },
                    { 53, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 36, 5, null },
                    { 54, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 71, 49, null },
                    { 55, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 38, 22, null },
                    { 56, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 32, 60, null },
                    { 57, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 62, 76, null },
                    { 58, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 84, 13, null },
                    { 59, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 58, 46, null },
                    { 60, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, 22, null },
                    { 61, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 77, 52, null },
                    { 62, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, 18, null },
                    { 63, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 36, 100, null },
                    { 64, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 39, 44, null },
                    { 65, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 85, 71, null },
                    { 66, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 33, 28, null },
                    { 67, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, 3, null },
                    { 68, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 52, 20, null },
                    { 69, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 23, 10, null },
                    { 70, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 43, 90, null },
                    { 71, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 84, 91, null },
                    { 72, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 68, 13, null },
                    { 73, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 94, 89, null },
                    { 74, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 40, 50, null },
                    { 75, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 26, 39, null },
                    { 76, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 36, 95, null },
                    { 77, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 69, 55, null },
                    { 78, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 54, 59, null },
                    { 79, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, 52, null },
                    { 80, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 75, 66, null },
                    { 81, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 60, 95, null },
                    { 82, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 66, 43, null },
                    { 83, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 55, 70, null },
                    { 84, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 78, 92, null },
                    { 85, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, 17, null },
                    { 86, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 47, 65, null },
                    { 87, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 34, 44, null },
                    { 88, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 58, 83, null },
                    { 89, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 50, 76, null },
                    { 90, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 58, 88, null },
                    { 91, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 84, 86, null },
                    { 92, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 94, 97, null },
                    { 93, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, 33, null },
                    { 94, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 91, 1, null },
                    { 95, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 38, 28, null },
                    { 96, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 48, 37, null },
                    { 97, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 79, 47, null },
                    { 98, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 28, 16, null },
                    { 99, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 15, 77, null },
                    { 100, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 69, 29, null }
                });

            migrationBuilder.InsertData(
                table: "PersonBooking",
                columns: new[] { "PersonBookingId", "BookingId", "CreatedAt", "CreatedBy", "PersonId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 83, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 83, null },
                    { 2, 65, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, null },
                    { 3, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 91, null },
                    { 4, 8, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 40, null },
                    { 5, 14, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 6, 18, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 39, null },
                    { 7, 33, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 81, null },
                    { 8, 18, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, null },
                    { 9, 99, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, null },
                    { 10, 34, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 75, null },
                    { 11, 100, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 12, 87, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 81, null },
                    { 13, 53, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 38, null },
                    { 14, 16, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 89, null },
                    { 15, 22, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 72, null },
                    { 16, 72, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 86, null },
                    { 17, 46, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, null },
                    { 18, 75, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, null },
                    { 19, 92, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 94, null },
                    { 20, 96, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 14, null },
                    { 21, 42, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 57, null },
                    { 22, 65, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 47, null },
                    { 23, 82, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 67, null },
                    { 24, 29, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 25, null },
                    { 25, 44, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 27, null },
                    { 26, 17, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 66, null },
                    { 27, 83, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 86, null },
                    { 28, 56, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 78, null },
                    { 29, 58, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 22, null },
                    { 30, 71, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 78, null },
                    { 31, 59, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 32, 8, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, null },
                    { 33, 55, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 27, null },
                    { 34, 82, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 35, 88, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, null },
                    { 36, 74, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 56, null },
                    { 37, 66, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 90, null },
                    { 38, 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 70, null },
                    { 39, 91, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 80, null },
                    { 40, 38, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, null },
                    { 41, 16, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 36, null },
                    { 42, 29, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 43, 33, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 50, null },
                    { 44, 10, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 20, null },
                    { 45, 23, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 9, null },
                    { 46, 97, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 44, null },
                    { 47, 51, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 26, null },
                    { 48, 85, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 71, null },
                    { 49, 17, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 76, null },
                    { 50, 44, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 92, null },
                    { 51, 37, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 88, null },
                    { 52, 58, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 53, 19, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, null },
                    { 54, 76, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 12, null },
                    { 55, 71, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 56, null },
                    { 56, 62, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 87, null },
                    { 57, 65, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 25, null },
                    { 58, 20, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 58, null },
                    { 59, 26, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 47, null },
                    { 60, 77, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 88, null },
                    { 61, 9, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 35, null },
                    { 62, 67, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 40, null },
                    { 63, 46, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 20, null },
                    { 64, 9, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 31, null },
                    { 65, 96, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, null },
                    { 66, 60, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 73, null },
                    { 67, 50, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 32, null },
                    { 68, 73, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 30, null },
                    { 69, 87, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, null },
                    { 70, 12, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 88, null },
                    { 71, 61, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 72, 17, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 97, null },
                    { 73, 86, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 98, null },
                    { 74, 66, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 85, null },
                    { 75, 7, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 91, null },
                    { 76, 25, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 77, null },
                    { 77, 88, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, null },
                    { 78, 96, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 14, null },
                    { 79, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 40, null },
                    { 80, 10, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 30, null },
                    { 81, 35, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 35, null },
                    { 82, 93, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 45, null },
                    { 83, 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 33, null },
                    { 84, 14, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, null },
                    { 85, 18, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 57, null },
                    { 86, 70, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, null },
                    { 87, 75, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 29, null },
                    { 88, 54, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 15, null },
                    { 89, 47, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 39, null },
                    { 90, 53, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 13, null },
                    { 91, 58, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 88, null },
                    { 92, 88, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, null },
                    { 93, 67, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 83, null },
                    { 94, 43, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 35, null },
                    { 95, 68, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, null },
                    { 96, 49, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 69, null },
                    { 97, 56, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 23, null },
                    { 98, 72, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 47, null },
                    { 99, 55, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 35, null },
                    { 100, 52, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 20, null },
                    { 101, 90, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 34, null },
                    { 102, 100, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, null },
                    { 103, 44, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 77, null },
                    { 104, 67, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, null },
                    { 105, 67, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 57, null },
                    { 106, 58, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 49, null },
                    { 107, 74, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 32, null },
                    { 108, 82, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 89, null },
                    { 109, 33, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 13, null },
                    { 110, 21, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 67, null },
                    { 111, 44, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 72, null },
                    { 112, 24, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 72, null },
                    { 113, 70, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 79, null },
                    { 114, 31, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 86, null },
                    { 115, 51, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 43, null },
                    { 116, 46, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 12, null },
                    { 117, 76, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, null },
                    { 118, 71, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 73, null },
                    { 119, 63, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 9, null },
                    { 120, 56, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 96, null },
                    { 121, 83, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 122, 36, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 16, null },
                    { 123, 21, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, null },
                    { 124, 10, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 46, null },
                    { 125, 23, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 15, null },
                    { 126, 60, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 100, null },
                    { 127, 24, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 96, null },
                    { 128, 29, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 46, null },
                    { 129, 88, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 21, null },
                    { 130, 41, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 28, null },
                    { 131, 68, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 29, null },
                    { 132, 87, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 52, null },
                    { 133, 9, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 38, null },
                    { 134, 45, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 62, null },
                    { 135, 92, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 88, null },
                    { 136, 28, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 52, null },
                    { 137, 8, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 29, null },
                    { 138, 93, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 32, null },
                    { 139, 26, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 50, null },
                    { 140, 42, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 54, null },
                    { 141, 91, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 3, null },
                    { 142, 100, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, null },
                    { 143, 73, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 96, null },
                    { 144, 80, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 24, null },
                    { 145, 29, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 93, null },
                    { 146, 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 89, null },
                    { 147, 85, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 57, null },
                    { 148, 62, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 29, null },
                    { 149, 6, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 65, null },
                    { 150, 67, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 8, null },
                    { 151, 53, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 43, null },
                    { 152, 91, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 64, null },
                    { 153, 85, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 100, null },
                    { 154, 89, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 31, null },
                    { 155, 60, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 28, null },
                    { 156, 8, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 53, null },
                    { 157, 58, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 14, null },
                    { 158, 47, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 39, null },
                    { 159, 79, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 76, null },
                    { 160, 84, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 77, null },
                    { 161, 61, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 6, null },
                    { 162, 17, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 37, null },
                    { 163, 80, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 33, null },
                    { 164, 35, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 39, null },
                    { 165, 77, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 41, null },
                    { 166, 71, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, null },
                    { 167, 36, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, null },
                    { 168, 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 59, null },
                    { 169, 45, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 67, null },
                    { 170, 11, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 37, null },
                    { 171, 23, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 96, null },
                    { 172, 48, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 77, null },
                    { 173, 79, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 98, null },
                    { 174, 99, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 11, null },
                    { 175, 81, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 91, null },
                    { 176, 5, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 87, null },
                    { 177, 37, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 65, null },
                    { 178, 88, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 45, null },
                    { 179, 55, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 44, null },
                    { 180, 48, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 75, null },
                    { 181, 34, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 62, null },
                    { 182, 4, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 38, null },
                    { 183, 47, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 68, null },
                    { 184, 85, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, null },
                    { 185, 85, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 76, null },
                    { 186, 25, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, null },
                    { 187, 49, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 74, null },
                    { 188, 37, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 63, null },
                    { 189, 85, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 67, null },
                    { 190, 44, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 5, null },
                    { 191, 81, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, null },
                    { 192, 35, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 40, null },
                    { 193, 33, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, null },
                    { 194, 56, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 63, null },
                    { 195, 67, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 74, null },
                    { 196, 60, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 12, null },
                    { 197, 19, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 8, null },
                    { 198, 1, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 96, null },
                    { 199, 48, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 69, null },
                    { 200, 95, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 12, null },
                    { 201, 98, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, null },
                    { 202, 28, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 89, null },
                    { 203, 46, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, null },
                    { 204, 26, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 46, null },
                    { 205, 83, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 71, null },
                    { 206, 84, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, null },
                    { 207, 79, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 95, null },
                    { 208, 26, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 100, null },
                    { 209, 95, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 37, null },
                    { 210, 42, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 1, null },
                    { 211, 97, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 90, null },
                    { 212, 71, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 12, null },
                    { 213, 25, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 80, null },
                    { 214, 57, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 76, null },
                    { 215, 19, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 90, null },
                    { 216, 29, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, null },
                    { 217, 21, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 85, null },
                    { 218, 21, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 82, null },
                    { 219, 43, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 48, null },
                    { 220, 90, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 79, null },
                    { 221, 24, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 23, null },
                    { 222, 100, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 60, null },
                    { 223, 83, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 45, null },
                    { 224, 76, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 78, null },
                    { 225, 61, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 72, null },
                    { 226, 54, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 78, null },
                    { 227, 77, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 10, null },
                    { 228, 54, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 2, null },
                    { 229, 26, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 55, null },
                    { 230, 64, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 71, null },
                    { 231, 76, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 77, null },
                    { 232, 41, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 88, null },
                    { 233, 86, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 92, null },
                    { 234, 95, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 18, null },
                    { 235, 45, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 28, null },
                    { 236, 25, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 17, null },
                    { 237, 20, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 81, null },
                    { 238, 50, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 4, null },
                    { 239, 61, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 77, null },
                    { 240, 77, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 73, null },
                    { 241, 25, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 45, null },
                    { 242, 32, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 36, null },
                    { 243, 89, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 72, null },
                    { 244, 54, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 94, null },
                    { 245, 90, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 52, null },
                    { 246, 3, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 32, null },
                    { 247, 93, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 79, null },
                    { 248, 93, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 49, null },
                    { 249, 92, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 19, null },
                    { 250, 23, new DateTime(2024, 6, 6, 9, 53, 57, 383, DateTimeKind.Utc).AddTicks(8988), "ApiNet", 7, null }
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
