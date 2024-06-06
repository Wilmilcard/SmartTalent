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
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordHash = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccessFailCount = table.Column<sbyte>(type: "tinyint", nullable: true),
                    IsAdmin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
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
                    UserId = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Person_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    SesionID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expiration_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.SesionID);
                    table.ForeignKey(
                        name: "FK_Session_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
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
                    { 1, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Bogota D.C.", null },
                    { 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Medellin", null },
                    { 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Pereira", null },
                    { 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Barranquilla", null },
                    { 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Ibague", null }
                });

            migrationBuilder.InsertData(
                table: "DocType",
                columns: new[] { "DocTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "type" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Cedula Ciudadania", null, "C.C." },
                    { 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Pasaporte", null, "PP" },
                    { 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Tarjeta Identidad", null, "T.I." },
                    { 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "NIT", null, "NIT" },
                    { 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Cedula Extranjeria", null, "C.E." }
                });

            migrationBuilder.InsertData(
                table: "RolType",
                columns: new[] { "RolTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Administrador", null },
                    { 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Cliente", null }
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "RoomTypeId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "ValuePerNight" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Basica", null, 45000.0 },
                    { 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Premium", null, 90000.0 },
                    { 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Deluxe", null, 150000.0 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "AccessFailCount", "CreatedAt", "CreatedBy", "IsActive", "IsAdmin", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, (sbyte)0, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", true, true, "81DC9BDB52D04DC223B621240E3DD8B7", null, "ADMIN" },
                    { 2, (sbyte)0, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", true, false, "81DC9BDB52D04DC223B621240E3DD8B7", null, "SMART" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "HotelId", "Availability", "CityId", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, false, 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Cronin Circles", null },
                    { 2, false, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Pfeffer Manors", null },
                    { 3, false, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Conner Valley", null },
                    { 4, false, 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Heidenreich Curve", null },
                    { 5, false, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Rigoberto Curve", null },
                    { 6, true, 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Jeanie Fork", null },
                    { 7, true, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Jaqueline Centers", null },
                    { 8, true, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Deven Port", null },
                    { 9, true, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Lubowitz Views", null },
                    { 10, true, 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Kaia Expressway", null },
                    { 11, false, 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Jensen Forges", null },
                    { 12, true, 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Geovanni Creek", null },
                    { 13, true, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Malinda Summit", null },
                    { 14, false, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Frederic Corner", null },
                    { 15, false, 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Gusikowski Pine", null },
                    { 16, true, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Strosin Turnpike", null },
                    { 17, true, 1, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Batz Stravenue", null },
                    { 18, true, 1, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Terry Points", null },
                    { 19, true, 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Ratke Summit", null },
                    { 20, true, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Prudence Lodge", null },
                    { 21, true, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Kuhic Manors", null },
                    { 22, false, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Halle Path", null },
                    { 23, false, 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Hoeger Mountain", null },
                    { 24, true, 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Lesch Gardens", null },
                    { 25, true, 1, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", "Hotel Reinger Ford", null }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonId", "Birth", "CreatedAt", "CreatedBy", "DocTypeId", "Document", "Email", "EmergencyContact", "EmergencyPhone", "FirstName", "Gender", "LastName", "Phone", "RolTypeId", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1974, 11, 25, 6, 27, 53, 773, DateTimeKind.Local).AddTicks(1631), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "197411257798", "Dale34@gmail.com", "Carlos Rutherford IV", "1-260-252-3754 x561", "Dale", "L", "Rosenbaum", "1-260-252-3754 x561", 2, null, null },
                    { 2, new DateTime(1991, 3, 29, 12, 29, 47, 577, DateTimeKind.Local).AddTicks(5297), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "199103295789", "Tasha.Powlowski@gmail.com", "Angelina Bauch MD", "(246) 853-4531 x24410", "Tasha", "L", "Powlowski", "(246) 853-4531 x24410", 2, null, null },
                    { 3, new DateTime(1979, 7, 24, 0, 37, 20, 368, DateTimeKind.Local).AddTicks(3016), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "197907243674", "Ian66@yahoo.com", "Allison Stanton DDS", "804-542-7545", "Ian", "J", "Kris", "804-542-7545", 2, null, null },
                    { 4, new DateTime(1998, 4, 10, 3, 46, 57, 766, DateTimeKind.Local).AddTicks(253), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199804107648", "Stella.Mraz@hotmail.com", "Donald Mante DDS", "(791) 913-4879", "Stella", "I", "Mraz", "(791) 913-4879", 2, null, null },
                    { 5, new DateTime(1960, 10, 8, 5, 51, 46, 297, DateTimeKind.Local).AddTicks(5580), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "196010082987", "Stephanie.Monahan38@yahoo.com", "Felipe Wisoky DDS", "219.556.2237 x754", "Stephanie", "I", "Monahan", "219.556.2237 x754", 2, null, null },
                    { 6, new DateTime(1997, 9, 10, 12, 15, 9, 425, DateTimeKind.Local).AddTicks(6236), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "199709104229", "Lucille94@gmail.com", "Harriet Veum III", "(353) 942-8740", "Lucille", "H", "Rempel", "(353) 942-8740", 2, null, null },
                    { 7, new DateTime(1956, 9, 21, 2, 55, 54, 637, DateTimeKind.Local).AddTicks(374), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "195609216378", "Daryl.Upton@hotmail.com", "Dr. Edmund Torphy", "1-885-824-2479 x33947", "Daryl", "J", "Upton", "1-885-824-2479 x33947", 2, null, null },
                    { 8, new DateTime(1965, 12, 28, 2, 42, 57, 622, DateTimeKind.Local).AddTicks(5229), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "196512286284", "Juanita_Grady@gmail.com", "Ms. Tina O'Keefe", "584.900.0863 x9549", "Juanita", "I", "Grady", "584.900.0863 x9549", 2, null, null },
                    { 9, new DateTime(1985, 9, 26, 1, 34, 38, 135, DateTimeKind.Local).AddTicks(9204), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "198509261379", "Patrick_Trantow@gmail.com", "Frances Jacobs V", "(711) 664-9408 x841", "Patrick", "F", "Trantow", "(711) 664-9408 x841", 2, null, null },
                    { 10, new DateTime(1978, 7, 1, 16, 6, 34, 488, DateTimeKind.Local).AddTicks(7648), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "197807014837", "Jerome_Fisher@gmail.com", "Wayne Lind Jr.", "(646) 695-7441 x019", "Jerome", "K", "Fisher", "(646) 695-7441 x019", 2, null, null },
                    { 11, new DateTime(1960, 1, 5, 4, 25, 53, 104, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "196001051017", "Wendell_Beier59@gmail.com", "Erika Stoltenberg IV", "(443) 469-4514", "Wendell", "G", "Beier", "(443) 469-4514", 2, null, null },
                    { 12, new DateTime(1993, 2, 12, 22, 30, 2, 830, DateTimeKind.Local).AddTicks(1037), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "199302128328", "Marsha87@yahoo.com", "Mr. Katherine Leuschke", "751-502-6477 x32406", "Marsha", "L", "Corkery", "751-502-6477 x32406", 2, null, null },
                    { 13, new DateTime(1976, 4, 13, 11, 6, 13, 589, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "197604135819", "Lloyd4@gmail.com", "Marianne Hayes DVM", "798.875.5313", "Lloyd", "J", "Jones", "798.875.5313", 2, null, null },
                    { 14, new DateTime(1979, 7, 27, 10, 58, 3, 982, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "197907279843", "Bernadette10@hotmail.com", "Lloyd Beahan V", "253-679-7531", "Bernadette", "K", "Ankunding", "253-679-7531", 2, null, null },
                    { 15, new DateTime(1957, 2, 1, 22, 7, 39, 467, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "195702014647", "Sylvia61@gmail.com", "Mrs. Nora Wisoky", "1-297-687-8307", "Sylvia", "F", "Hoeger", "1-297-687-8307", 2, null, null },
                    { 16, new DateTime(1980, 10, 29, 13, 7, 1, 121, DateTimeKind.Local).AddTicks(5179), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "198010291246", "Allison.Corkery12@hotmail.com", "Lance Hauck MD", "285.824.2057", "Allison", "G", "Corkery", "285.824.2057", 2, null, null },
                    { 17, new DateTime(1996, 11, 5, 22, 35, 22, 769, DateTimeKind.Local).AddTicks(7612), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "199611057614", "Mack_Dooley@hotmail.com", "Miss Bradford Oberbrunner", "1-683-971-3975", "Mack", "H", "Dooley", "1-683-971-3975", 2, null, null },
                    { 18, new DateTime(1960, 11, 19, 2, 11, 50, 260, DateTimeKind.Local).AddTicks(1342), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "196011192660", "Lola72@yahoo.com", "Mr. Edward Fahey", "(437) 775-8097", "Lola", "H", "Morar", "(437) 775-8097", 2, null, null },
                    { 19, new DateTime(1979, 2, 2, 12, 17, 57, 193, DateTimeKind.Local).AddTicks(9117), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "197902021919", "Moses_Keeling@gmail.com", "Mr. Noah Morissette", "1-284-763-6886 x300", "Moses", "L", "Keeling", "1-284-763-6886 x300", 2, null, null },
                    { 20, new DateTime(1964, 11, 24, 19, 27, 33, 976, DateTimeKind.Local).AddTicks(4946), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "196411249763", "Kay.Morar@hotmail.com", "Mrs. Jeannie Watsica", "329.696.6201 x362", "Kay", "I", "Morar", "329.696.6201 x362", 2, null, null },
                    { 21, new DateTime(1987, 8, 20, 2, 50, 36, 676, DateTimeKind.Local).AddTicks(3261), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "198708206795", "Ignacio.Kemmer95@gmail.com", "Joann Lubowitz PhD", "812.875.9902 x7184", "Ignacio", "J", "Kemmer", "812.875.9902 x7184", 2, null, null },
                    { 22, new DateTime(1963, 9, 10, 21, 44, 12, 69, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "196309100649", "Sandra.Mann19@gmail.com", "Tara Fisher DVM", "1-569-552-0395 x8275", "Sandra", "L", "Mann", "1-569-552-0395 x8275", 2, null, null },
                    { 23, new DateTime(1967, 5, 20, 6, 6, 22, 490, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "196705204979", "Sean.Hamill@hotmail.com", "Mrs. Fred Heidenreich", "(714) 382-3132 x35023", "Sean", "G", "Hamill", "(714) 382-3132 x35023", 2, null, null },
                    { 24, new DateTime(2000, 1, 6, 9, 24, 50, 973, DateTimeKind.Local).AddTicks(2403), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "200001069731", "Marco.Jacobi@gmail.com", "Erica Wunsch Sr.", "298-618-5203 x6910", "Marco", "F", "Jacobi", "298-618-5203 x6910", 2, null, null },
                    { 25, new DateTime(1989, 9, 6, 2, 17, 11, 361, DateTimeKind.Local).AddTicks(7522), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "198909063664", "Hope_Breitenberg98@gmail.com", "Dr. Lucia Schiller", "(291) 629-4397 x21342", "Hope", "H", "Breitenberg", "(291) 629-4397 x21342", 2, null, null },
                    { 26, new DateTime(1983, 6, 15, 1, 16, 29, 169, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "198306151617", "Cedric.Doyle@yahoo.com", "Miss Peggy Quitzon", "1-473-609-7658 x587", "Cedric", "L", "Doyle", "1-473-609-7658 x587", 2, null, null },
                    { 27, new DateTime(1999, 4, 10, 14, 1, 52, 814, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199904108181", "Joanna44@gmail.com", "Mr. Frankie Effertz", "331-346-5725", "Joanna", "K", "Nicolas", "331-346-5725", 2, null, null },
                    { 28, new DateTime(2000, 3, 23, 7, 57, 48, 535, DateTimeKind.Local).AddTicks(2918), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "200003235322", "Nellie.Kris@gmail.com", "Dr. Carole Fay", "268.387.5608", "Nellie", "J", "Kris", "268.387.5608", 2, null, null },
                    { 29, new DateTime(2004, 1, 23, 18, 26, 27, 484, DateTimeKind.Local).AddTicks(2799), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "200401234869", "Marta75@hotmail.com", "Brandon Bernier DDS", "232-370-2781 x8098", "Marta", "F", "Brekke", "232-370-2781 x8098", 2, null, null },
                    { 30, new DateTime(1960, 11, 19, 13, 16, 54, 35, DateTimeKind.Local).AddTicks(5212), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "196011190326", "Lucy_Pfannerstill24@hotmail.com", "Mr. Miguel Jacobson", "(414) 581-3098", "Lucy", "H", "Pfannerstill", "(414) 581-3098", 2, null, null },
                    { 31, new DateTime(2001, 9, 17, 2, 9, 2, 635, DateTimeKind.Local).AddTicks(8177), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "200109176339", "Jimmie_Mraz8@yahoo.com", "Peter Breitenberg Jr.", "389.709.0264 x733", "Jimmie", "L", "Mraz", "389.709.0264 x733", 2, null, null },
                    { 32, new DateTime(1975, 4, 25, 22, 18, 26, 168, DateTimeKind.Local).AddTicks(7550), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "197504251666", "Alicia.Rempel45@yahoo.com", "Josefina Greenfelder DVM", "(772) 470-8266 x03869", "Alicia", "H", "Rempel", "(772) 470-8266 x03869", 2, null, null },
                    { 33, new DateTime(1958, 4, 11, 21, 44, 57, 218, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "195804112190", "Guillermo_Turner30@hotmail.com", "Mr. Faith MacGyver", "1-645-356-5128", "Guillermo", "G", "Turner", "1-645-356-5128", 2, null, null },
                    { 34, new DateTime(1989, 10, 12, 0, 26, 56, 323, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "198910123234", "Garry48@hotmail.com", "Luke Glover I", "1-509-460-0189 x34573", "Garry", "J", "Runolfsdottir", "1-509-460-0189 x34573", 2, null, null },
                    { 35, new DateTime(1959, 5, 14, 22, 20, 42, 525, DateTimeKind.Local).AddTicks(1956), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "195905145222", "Brandy.Littel52@yahoo.com", "Mr. Ginger Cremin", "456.270.1348", "Brandy", "J", "Littel", "456.270.1348", 2, null, null },
                    { 36, new DateTime(1956, 1, 9, 21, 30, 49, 701, DateTimeKind.Local).AddTicks(7861), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "195601097032", "Brent48@hotmail.com", "Mrs. Fannie O'Keefe", "343-282-1764 x757", "Brent", "L", "Leffler", "343-282-1764 x757", 2, null, null },
                    { 37, new DateTime(1984, 7, 2, 10, 39, 57, 37, DateTimeKind.Local).AddTicks(9065), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "198407020372", "Clifford35@hotmail.com", "Mr. Harry Jakubowski", "1-565-552-4316 x84350", "Clifford", "J", "Hodkiewicz", "1-565-552-4316 x84350", 2, null, null },
                    { 38, new DateTime(1974, 8, 4, 1, 40, 5, 787, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "197408047889", "Alberta.Greenholt70@hotmail.com", "Marcella Grant III", "1-852-625-9226 x84520", "Alberta", "F", "Greenholt", "1-852-625-9226 x84520", 2, null, null },
                    { 39, new DateTime(1982, 11, 16, 21, 0, 35, 313, DateTimeKind.Local).AddTicks(1875), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "198211163145", "Maryann4@hotmail.com", "Mrs. Carlos Dietrich", "269.977.9652 x2325", "Maryann", "J", "Schultz", "269.977.9652 x2325", 2, null, null },
                    { 40, new DateTime(1979, 10, 26, 17, 50, 0, 158, DateTimeKind.Local).AddTicks(6248), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "197910261515", "Salvatore_Brekke@gmail.com", "Dr. Rosie Zboncak", "381-951-7805 x0095", "Salvatore", "G", "Brekke", "381-951-7805 x0095", 2, null, null },
                    { 41, new DateTime(2004, 1, 4, 14, 10, 55, 286, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "200401042890", "Glen.Bayer49@yahoo.com", "Catherine Klein III", "1-940-391-0187", "Glen", "I", "Bayer", "1-940-391-0187", 2, null, null },
                    { 42, new DateTime(1992, 1, 8, 20, 14, 58, 162, DateTimeKind.Local).AddTicks(356), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199201081636", "Trevor_Kuhic69@hotmail.com", "Mrs. Marilyn Bauch", "250-392-9585", "Trevor", "F", "Kuhic", "250-392-9585", 2, null, null },
                    { 43, new DateTime(1983, 10, 6, 12, 57, 5, 115, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "198310061158", "Ralph.Roberts@hotmail.com", "Joy Kovacek III", "1-941-722-9266", "Ralph", "I", "Roberts", "1-941-722-9266", 2, null, null },
                    { 44, new DateTime(1991, 3, 15, 22, 42, 4, 158, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "199103151511", "Leonard51@gmail.com", "Shirley Grant Jr.", "846.870.3724 x6132", "Leonard", "J", "Dare", "846.870.3724 x6132", 2, null, null },
                    { 45, new DateTime(1965, 12, 11, 4, 6, 31, 362, DateTimeKind.Local).AddTicks(2740), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "196512113629", "Gloria97@yahoo.com", "Damon Goyette V", "800.577.1525 x0119", "Gloria", "L", "Cummings", "800.577.1525 x0119", 2, null, null },
                    { 46, new DateTime(1988, 11, 7, 4, 23, 51, 368, DateTimeKind.Local).AddTicks(3981), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "198811073645", "Kristina_Shanahan14@gmail.com", "Mrs. Alicia Jerde", "(954) 228-5926", "Kristina", "I", "Shanahan", "(954) 228-5926", 2, null, null },
                    { 47, new DateTime(1999, 8, 21, 6, 23, 38, 677, DateTimeKind.Local).AddTicks(1881), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199908216741", "Penny_Bayer88@hotmail.com", "Sally Cassin PhD", "(604) 742-7347 x747", "Penny", "I", "Bayer", "(604) 742-7347 x747", 2, null, null },
                    { 48, new DateTime(1962, 8, 17, 20, 17, 20, 970, DateTimeKind.Local).AddTicks(3753), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "196208179744", "Maxine.Walker88@gmail.com", "Mr. Delores Block", "(374) 306-6689", "Maxine", "F", "Walker", "(374) 306-6689", 2, null, null },
                    { 49, new DateTime(1984, 11, 13, 17, 21, 32, 595, DateTimeKind.Local).AddTicks(1570), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "198411135984", "Vanessa30@hotmail.com", "Dr. Beatrice Little", "(352) 400-0048", "Vanessa", "L", "Flatley", "(352) 400-0048", 2, null, null },
                    { 50, new DateTime(1955, 1, 23, 8, 21, 10, 162, DateTimeKind.Local).AddTicks(5253), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "195501231681", "Carla_Fritsch@hotmail.com", "Sherri Heaney DDS", "650.604.0346 x5455", "Carla", "F", "Fritsch", "650.604.0346 x5455", 2, null, null },
                    { 51, new DateTime(1974, 4, 28, 10, 47, 14, 98, DateTimeKind.Local).AddTicks(1364), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "197404280922", "Alexis.Goyette72@gmail.com", "Kim Berge II", "566.265.6184 x13406", "Alexis", "J", "Goyette", "566.265.6184 x13406", 2, null, null },
                    { 52, new DateTime(1972, 11, 14, 0, 0, 4, 367, DateTimeKind.Local).AddTicks(4887), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "197211143644", "Clara_Mohr@hotmail.com", "Jay Buckridge IV", "691.926.4324", "Clara", "H", "Mohr", "691.926.4324", 2, null, null },
                    { 53, new DateTime(1985, 1, 18, 18, 16, 44, 771, DateTimeKind.Local).AddTicks(9094), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "198501187770", "Anthony_Bartoletti@gmail.com", "Mr. Gina Towne", "203-933-5288 x4613", "Anthony", "F", "Bartoletti", "203-933-5288 x4613", 2, null, null },
                    { 54, new DateTime(1987, 5, 31, 14, 51, 53, 559, DateTimeKind.Local).AddTicks(6611), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "198705315540", "Kathy.Gulgowski18@hotmail.com", "Lana Frami MD", "665.651.2503 x5951", "Kathy", "L", "Gulgowski", "665.651.2503 x5951", 2, null, null },
                    { 55, new DateTime(1981, 1, 15, 5, 34, 54, 552, DateTimeKind.Local).AddTicks(4044), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "198101155573", "Dexter.Bergnaum@yahoo.com", "Ms. Martin Pagac", "1-472-370-3769 x548", "Dexter", "J", "Bergnaum", "1-472-370-3769 x548", 2, null, null },
                    { 56, new DateTime(1989, 6, 26, 15, 44, 48, 34, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "198906260354", "Don.Mitchell@yahoo.com", "Lynn Christiansen Sr.", "(506) 918-0857", "Don", "L", "Mitchell", "(506) 918-0857", 2, null, null },
                    { 57, new DateTime(1972, 12, 25, 7, 48, 5, 231, DateTimeKind.Local).AddTicks(6427), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "197212252386", "Judy21@hotmail.com", "Patsy Bode II", "(955) 275-8354 x968", "Judy", "G", "Ortiz", "(955) 275-8354 x968", 2, null, null },
                    { 58, new DateTime(1976, 4, 20, 9, 32, 33, 358, DateTimeKind.Local).AddTicks(7234), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "197604203518", "Grady89@gmail.com", "Alexis Stracke III", "218.275.5012", "Grady", "K", "Feeney", "218.275.5012", 2, null, null },
                    { 59, new DateTime(1999, 12, 22, 7, 28, 59, 538, DateTimeKind.Local).AddTicks(1548), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199912225357", "Kyle_Hermann@gmail.com", "Miss Earl Rogahn", "(726) 407-4779 x897", "Kyle", "I", "Hermann", "(726) 407-4779 x897", 2, null, null },
                    { 60, new DateTime(1960, 4, 9, 10, 49, 34, 220, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "196004092299", "Seth98@yahoo.com", "Joel Fritsch I", "876.782.3653 x309", "Seth", "F", "Lubowitz", "876.782.3653 x309", 2, null, null },
                    { 61, new DateTime(2003, 9, 18, 0, 5, 16, 974, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "200309189728", "Samantha.Stoltenberg32@hotmail.com", "Ms. Krista Nitzsche", "942-327-9311", "Samantha", "G", "Stoltenberg", "942-327-9311", 2, null, null },
                    { 62, new DateTime(1995, 7, 24, 14, 52, 4, 700, DateTimeKind.Local).AddTicks(9584), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "199507247014", "Edmond_Prohaska@gmail.com", "Marvin Miller III", "549.483.2222 x81859", "Edmond", "G", "Prohaska", "549.483.2222 x81859", 2, null, null },
                    { 63, new DateTime(1968, 9, 21, 12, 9, 41, 38, DateTimeKind.Local).AddTicks(3251), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "196809210385", "Shelley.Kreiger75@hotmail.com", "Hannah Steuber DDS", "309-410-4702", "Shelley", "G", "Kreiger", "309-410-4702", 2, null, null },
                    { 64, new DateTime(1964, 4, 10, 15, 45, 57, 394, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "196404103951", "Nathaniel55@gmail.com", "Delores Sauer I", "309.317.3747 x960", "Nathaniel", "L", "Hilpert", "309.317.3747 x960", 2, null, null },
                    { 65, new DateTime(1979, 5, 11, 8, 21, 40, 997, DateTimeKind.Local).AddTicks(2832), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "197905119942", "Michele24@gmail.com", "Marta Gutkowski Jr.", "234-802-4579 x66490", "Michele", "I", "Nolan", "234-802-4579 x66490", 2, null, null },
                    { 66, new DateTime(1981, 12, 20, 23, 36, 24, 922, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "198112209245", "Gina51@yahoo.com", "Tami Cummerata DVM", "1-592-536-6011", "Gina", "I", "Batz", "1-592-536-6011", 2, null, null },
                    { 67, new DateTime(1985, 1, 18, 3, 4, 18, 871, DateTimeKind.Local).AddTicks(2951), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "198501188794", "Dana14@yahoo.com", "Paul Morar I", "1-705-869-6622 x616", "Dana", "L", "Labadie", "1-705-869-6622 x616", 2, null, null },
                    { 68, new DateTime(1971, 7, 8, 9, 27, 38, 458, DateTimeKind.Local).AddTicks(1242), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "197107084571", "Santiago_Hodkiewicz@gmail.com", "Mr. Peggy Smith", "838.414.7310 x39379", "Santiago", "G", "Hodkiewicz", "838.414.7310 x39379", 2, null, null },
                    { 69, new DateTime(1974, 4, 3, 17, 47, 3, 602, DateTimeKind.Local).AddTicks(2635), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "197404036027", "Vickie.Hermiston@hotmail.com", "Bruce Will II", "915-307-1501", "Vickie", "L", "Hermiston", "915-307-1501", 2, null, null },
                    { 70, new DateTime(1995, 12, 5, 4, 31, 1, 332, DateTimeKind.Local).AddTicks(9072), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199512053332", "Ernest.Altenwerth47@yahoo.com", "Ruth Bernier PhD", "1-477-527-8372", "Ernest", "J", "Altenwerth", "1-477-527-8372", 2, null, null },
                    { 71, new DateTime(1999, 2, 3, 5, 10, 54, 372, DateTimeKind.Local).AddTicks(1833), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "199902033738", "Ernest_Hermiston95@yahoo.com", "Toni Veum DDS", "1-687-227-0953", "Ernest", "H", "Hermiston", "1-687-227-0953", 2, null, null },
                    { 72, new DateTime(1982, 10, 13, 15, 24, 23, 407, DateTimeKind.Local).AddTicks(7823), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "198210134048", "Brenda19@yahoo.com", "Craig Cartwright DVM", "634-297-6809 x47924", "Brenda", "H", "Green", "634-297-6809 x47924", 2, null, null },
                    { 73, new DateTime(1964, 1, 30, 0, 54, 27, 668, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "196401306664", "Dixie67@yahoo.com", "Miss Gwen Spinka", "630-633-6236", "Dixie", "K", "Dicki", "630-633-6236", 2, null, null },
                    { 74, new DateTime(1971, 1, 6, 10, 5, 20, 776, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "197101067796", "Tyler.Romaguera2@hotmail.com", "Mrs. Julie Kshlerin", "478.456.4506 x332", "Tyler", "F", "Romaguera", "478.456.4506 x332", 2, null, null },
                    { 75, new DateTime(1967, 7, 10, 19, 15, 0, 362, DateTimeKind.Local).AddTicks(2218), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "196707103674", "Michael11@gmail.com", "Ms. Lewis O'Kon", "455-226-0278", "Michael", "H", "Herman", "455-226-0278", 2, null, null },
                    { 76, new DateTime(1998, 9, 25, 15, 18, 30, 934, DateTimeKind.Local).AddTicks(1133), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "199809259394", "Anthony14@gmail.com", "Bernadette Langosh II", "236-699-4776 x8756", "Anthony", "J", "Parker", "236-699-4776 x8756", 2, null, null },
                    { 77, new DateTime(1995, 3, 14, 6, 12, 27, 530, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199503145360", "Lillian22@gmail.com", "Guadalupe Hickle PhD", "1-496-366-2891 x6288", "Lillian", "K", "Greenholt", "1-496-366-2891 x6288", 2, null, null },
                    { 78, new DateTime(1961, 8, 27, 3, 21, 51, 159, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "196108271583", "Jana.Rowe@yahoo.com", "Bernadette Lakin Jr.", "(556) 682-5747 x154", "Jana", "K", "Rowe", "(556) 682-5747 x154", 2, null, null },
                    { 79, new DateTime(1959, 2, 15, 0, 32, 29, 471, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "195902154797", "Seth69@gmail.com", "Valerie Rogahn V", "(420) 903-9331 x4477", "Seth", "F", "Padberg", "(420) 903-9331 x4477", 2, null, null },
                    { 80, new DateTime(1996, 10, 28, 3, 32, 15, 142, DateTimeKind.Local).AddTicks(1150), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "199610281488", "Shelly29@yahoo.com", "Hector Farrell IV", "784.258.0883 x8634", "Shelly", "F", "Rutherford", "784.258.0883 x8634", 2, null, null },
                    { 81, new DateTime(1958, 5, 15, 15, 1, 0, 993, DateTimeKind.Local).AddTicks(1865), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "195805159950", "Daniel.Kuhn22@gmail.com", "Elsie Paucek IV", "530-317-4541 x897", "Daniel", "F", "Kuhn", "530-317-4541 x897", 2, null, null },
                    { 82, new DateTime(1997, 9, 20, 1, 37, 56, 771, DateTimeKind.Local).AddTicks(314), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "199709207758", "Salvador.Franecki@gmail.com", "Wilbert Hickle V", "349-867-0817", "Salvador", "J", "Franecki", "349-867-0817", 2, null, null },
                    { 83, new DateTime(1999, 7, 8, 0, 0, 16, 181, DateTimeKind.Local).AddTicks(9958), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "199907081823", "Georgia_Bergstrom89@gmail.com", "Cathy Halvorson V", "1-529-531-8710", "Georgia", "J", "Bergstrom", "1-529-531-8710", 2, null, null },
                    { 84, new DateTime(1992, 9, 19, 22, 22, 29, 900, DateTimeKind.Local).AddTicks(1824), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "199209199083", "Josefina_Langosh@yahoo.com", "Marion Schmidt MD", "747.275.0835", "Josefina", "I", "Langosh", "747.275.0835", 2, null, null },
                    { 85, new DateTime(1997, 11, 21, 20, 9, 59, 597, DateTimeKind.Local).AddTicks(3371), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199711215963", "Lydia.Hackett55@yahoo.com", "Mrs. Roosevelt Schultz", "492.838.8918 x25686", "Lydia", "G", "Hackett", "492.838.8918 x25686", 2, null, null },
                    { 86, new DateTime(1968, 1, 1, 10, 40, 43, 8, DateTimeKind.Local).AddTicks(5216), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "196801010098", "Matthew_Cummerata@gmail.com", "Dr. Clarence Rippin", "920.787.0212", "Matthew", "F", "Cummerata", "920.787.0212", 2, null, null },
                    { 87, new DateTime(1997, 2, 24, 18, 43, 22, 876, DateTimeKind.Local).AddTicks(8550), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "199702248767", "Lindsay35@hotmail.com", "Denise Blanda Sr.", "863.479.5111 x1381", "Lindsay", "G", "Stamm", "863.479.5111 x1381", 2, null, null },
                    { 88, new DateTime(1969, 6, 14, 13, 25, 37, 863, DateTimeKind.Local).AddTicks(9277), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "196906148678", "Allan_Stark@hotmail.com", "Ms. Velma Harvey", "1-213-287-2047", "Allan", "H", "Stark", "1-213-287-2047", 2, null, null },
                    { 89, new DateTime(1975, 7, 13, 9, 35, 33, 901, DateTimeKind.Local).AddTicks(4393), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "197507139082", "Erma.Schneider62@yahoo.com", "Dr. Della Jaskolski", "1-251-595-1107 x9622", "Erma", "K", "Schneider", "1-251-595-1107 x9622", 2, null, null },
                    { 90, new DateTime(1996, 10, 18, 1, 17, 48, 475, DateTimeKind.Local).AddTicks(414), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "199610184765", "Olivia.Predovic@yahoo.com", "Ms. Toni Heller", "1-272-794-4427 x808", "Olivia", "K", "Predovic", "1-272-794-4427 x808", 2, null, null },
                    { 91, new DateTime(1971, 2, 21, 19, 37, 13, 194, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "197102211948", "Heidi_Kris96@hotmail.com", "Miss Shari Koch", "848.346.5594", "Heidi", "J", "Kris", "848.346.5594", 2, null, null },
                    { 92, new DateTime(1998, 4, 4, 10, 23, 24, 563, DateTimeKind.Local).AddTicks(2207), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "199804045616", "Peter13@yahoo.com", "Deborah Schoen I", "1-342-894-4882 x180", "Peter", "H", "Kessler", "1-342-894-4882 x180", 2, null, null },
                    { 93, new DateTime(1998, 3, 17, 10, 33, 21, 145, DateTimeKind.Local).AddTicks(2539), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "199803171462", "Deanna_OConnell@yahoo.com", "Dr. Toni Herman", "1-443-688-9979 x1892", "Deanna", "G", "O'Connell", "1-443-688-9979 x1892", 2, null, null },
                    { 94, new DateTime(1990, 11, 15, 14, 46, 29, 762, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "199011157659", "Frederick20@hotmail.com", "Lois Jakubowski IV", "1-390-861-2106 x5252", "Frederick", "I", "Marks", "1-390-861-2106 x5252", 2, null, null },
                    { 95, new DateTime(2001, 11, 14, 2, 38, 7, 791, DateTimeKind.Local).AddTicks(5923), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, "200111147971", "Allan.Ondricka12@hotmail.com", "Antonia Wisoky III", "1-751-646-0342 x3032", "Allan", "I", "Ondricka", "1-751-646-0342 x3032", 2, null, null },
                    { 96, new DateTime(1976, 4, 12, 11, 16, 44, 122, DateTimeKind.Local).AddTicks(6374), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "197604121231", "Wayne_Ortiz77@yahoo.com", "Dr. Joey Olson", "991-416-5837", "Wayne", "G", "Ortiz", "991-416-5837", 2, null, null },
                    { 97, new DateTime(1988, 4, 2, 18, 53, 28, 341, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "198804023417", "Tommie_Heathcote92@gmail.com", "Miss Fernando Herzog", "576-228-3612", "Tommie", "F", "Heathcote", "576-228-3612", 2, null, null },
                    { 98, new DateTime(1973, 8, 22, 9, 10, 13, 495, DateTimeKind.Local).AddTicks(1276), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, "197308224935", "Irvin_Mann@gmail.com", "Miss Casey Sanford", "1-714-231-1878 x90896", "Irvin", "I", "Mann", "1-714-231-1878 x90896", 2, null, null },
                    { 99, new DateTime(2001, 1, 18, 23, 42, 52, 585, DateTimeKind.Local).AddTicks(674), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "200101185866", "Eva_Gislason4@yahoo.com", "Mr. Ollie Ernser", "(306) 513-0602", "Eva", "I", "Gislason", "(306) 513-0602", 2, null, null },
                    { 100, new DateTime(1961, 1, 2, 11, 19, 28, 896, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, "196101028915", "Carl.Streich@hotmail.com", "Mrs. Teri Schuster", "(820) 673-7602", "Carl", "F", "Streich", "(820) 673-7602", 2, null, null },
                    { 101, new DateTime(2004, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, "1010101010", "admin@email.com", "N/A", "N/A", "Administrador", "M", "Sistema", "10101010101", 1, null, 1 },
                    { 102, new DateTime(1988, 11, 1, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, "102102120102", "smart@email.com", "N/A", "N/A", "Smart", "F", "Talent", "102102102102", 2, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "RoomId", "Availability", "CreatedAt", "CreatedBy", "HotelId", "MaxGuest", "RoomNumber", "RoomTypeId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 8, 1, "J15", 2, null },
                    { 2, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, 3, "J59", 2, null },
                    { 3, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, 2, "H9", 3, null },
                    { 4, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 3, "V47", 3, null },
                    { 5, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 15, 2, "K70", 3, null },
                    { 6, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, 3, "X77", 2, null },
                    { 7, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 1, "B90", 1, null },
                    { 8, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 21, 4, "B86", 2, null },
                    { 9, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, 4, "B4", 3, null },
                    { 10, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 10, 4, "G71", 3, null },
                    { 11, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, 1, "V36", 1, null },
                    { 12, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, 4, "Q47", 3, null },
                    { 13, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 19, 2, "G70", 3, null },
                    { 14, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 1, "C47", 1, null },
                    { 15, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 21, 4, "B39", 2, null },
                    { 16, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 8, 3, "J32", 2, null },
                    { 17, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 8, 4, "D26", 2, null },
                    { 18, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, 1, "S50", 1, null },
                    { 19, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 14, 2, "M54", 2, null },
                    { 20, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 21, 1, "X52", 2, null },
                    { 21, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 22, 2, "H81", 1, null },
                    { 22, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 14, 1, "X19", 2, null },
                    { 23, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 4, "Q98", 3, null },
                    { 24, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 3, "K63", 2, null },
                    { 25, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, 3, "I59", 1, null },
                    { 26, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 21, 2, "N96", 1, null },
                    { 27, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 17, 3, "J63", 1, null },
                    { 28, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 10, 1, "O70", 1, null },
                    { 29, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 10, 2, "B87", 2, null },
                    { 30, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 3, "O7", 3, null },
                    { 31, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, 1, "N22", 3, null },
                    { 32, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, 2, "R76", 2, null },
                    { 33, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, 4, "Y52", 1, null },
                    { 34, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, 3, "N41", 1, null },
                    { 35, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 20, 3, "K54", 1, null },
                    { 36, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 17, 4, "D31", 2, null },
                    { 37, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 17, 2, "Z28", 1, null },
                    { 38, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, 1, "J90", 3, null },
                    { 39, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 4, "B57", 3, null },
                    { 40, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 22, 2, "S89", 3, null },
                    { 41, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 10, 1, "Z41", 2, null },
                    { 42, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, 1, "E89", 1, null },
                    { 43, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, 2, "K37", 3, null },
                    { 44, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, 3, "O62", 1, null },
                    { 45, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, 2, "L61", 3, null },
                    { 46, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 4, "G57", 1, null },
                    { 47, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 12, 4, "Z76", 1, null },
                    { 48, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 18, 2, "C89", 1, null },
                    { 49, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, 4, "L2", 2, null },
                    { 50, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 19, 2, "C44", 2, null },
                    { 51, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, 1, "L3", 2, null },
                    { 52, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, 4, "M80", 2, null },
                    { 53, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 19, 2, "F72", 2, null },
                    { 54, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, 3, "G10", 2, null },
                    { 55, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 10, 2, "S91", 3, null },
                    { 56, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 14, 2, "F52", 2, null },
                    { 57, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 18, 3, "Q33", 3, null },
                    { 58, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, 2, "L54", 2, null },
                    { 59, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 3, "G69", 2, null },
                    { 60, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 20, 1, "V95", 2, null },
                    { 61, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, 3, "H93", 2, null },
                    { 62, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 25, 4, "R10", 2, null },
                    { 63, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, 3, "Z18", 2, null },
                    { 64, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 2, "R23", 2, null },
                    { 65, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 18, 3, "K96", 3, null },
                    { 66, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, 4, "Y30", 2, null },
                    { 67, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 1, "N25", 2, null },
                    { 68, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, 4, "E47", 1, null },
                    { 69, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 7, 2, "F84", 2, null },
                    { 70, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 3, 2, "B86", 1, null },
                    { 71, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, 3, "O70", 1, null },
                    { 72, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 4, "U7", 2, null },
                    { 73, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, 2, "M6", 3, null },
                    { 74, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 17, 2, "Y52", 3, null },
                    { 75, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 8, 2, "G73", 1, null },
                    { 76, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 19, 4, "P40", 2, null },
                    { 77, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, 1, "S6", 1, null },
                    { 78, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, 4, "R80", 1, null },
                    { 79, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 8, 3, "T61", 2, null },
                    { 80, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 18, 2, "I64", 3, null },
                    { 81, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 25, 2, "R90", 3, null },
                    { 82, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 22, 3, "C98", 2, null },
                    { 83, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 7, 4, "V70", 3, null },
                    { 84, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, 3, "D85", 3, null },
                    { 85, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 18, 4, "T95", 1, null },
                    { 86, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 1, "Y68", 3, null },
                    { 87, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 20, 2, "Y56", 1, null },
                    { 88, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, 4, "U34", 2, null },
                    { 89, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, 4, "L44", 2, null },
                    { 90, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, 1, "L49", 1, null },
                    { 91, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 1, "S65", 3, null },
                    { 92, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 10, 3, "L79", 3, null },
                    { 93, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 20, 3, "D2", 3, null },
                    { 94, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, 2, "S56", 1, null },
                    { 95, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, 4, "C26", 3, null },
                    { 96, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 7, 3, "N36", 3, null },
                    { 97, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, 1, "V89", 2, null },
                    { 98, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 19, 1, "U23", 3, null },
                    { 99, false, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, 2, "W29", 1, null },
                    { 100, true, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 2, "H62", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "BookingId", "Availability", "BaseCost", "Code", "CreatedAt", "CreatedBy", "EndDate", "PersonId", "RoomId", "StarDate", "Tax", "Total", "TotalGuest", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, true, 0.0, "SMABTZ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 92, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 2, false, 0.0, "QOISBH", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 37, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 3, false, 0.0, "YPEJMA", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 99, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 4, true, 0.0, "VIUKHP", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 14, new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 5, true, 0.0, "JNINTF", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 61, new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 6, true, 0.0, "BGUNFB", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 76, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 7, true, 0.0, "OAOBDK", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 53, new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 8, false, 0.0, "GUAAEM", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 17, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 9, true, 0.0, "UHUBDY", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 72, new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 10, false, 0.0, "MXONLV", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 50, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 11, false, 0.0, "CVOITU", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 92, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 12, false, 0.0, "NZUTVQ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 96, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 13, false, 0.0, "HMOUYY", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 70, 95, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 14, false, 0.0, "XBIPNJ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 63, new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 15, true, 0.0, "GZOSMT", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 78, new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 16, true, 0.0, "HWILAN", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 21, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 17, true, 0.0, "AEEKMX", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 89, new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 18, false, 0.0, "DCUTOA", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 39, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 19, true, 0.0, "RMALAM", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 50, new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 20, false, 0.0, "ISEGFD", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 74, 85, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 21, true, 0.0, "UEEZMI", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 85, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 22, false, 0.0, "AJESJL", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 75, new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 23, false, 0.0, "SAOTJX", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 94, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 24, true, 0.0, "TAEAWK", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 37, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 25, false, 0.0, "RAUSMK", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 71, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 26, false, 0.0, "VOUCOT", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, 7, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 27, true, 0.0, "QIISJG", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 66, new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 28, false, 0.0, "DPAKWR", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 2, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 29, false, 0.0, "ZLEMQJ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, 86, new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 30, true, 0.0, "OXUVEF", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 63, 65, new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 31, true, 0.0, "YTATCN", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 57, 1, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 32, false, 0.0, "YBAIDE", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 95, new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 33, false, 0.0, "HUOLKR", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, 86, new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 34, true, 0.0, "AZUAEB", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 98, new DateTime(2024, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 35, true, 0.0, "WSIIEU", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 1, new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 36, false, 0.0, "BSAMVK", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 98, new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 37, true, 0.0, "OWOGLX", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 46, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 38, false, 0.0, "JWUSMB", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 41, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 39, true, 0.0, "SDAGBK", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 59, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 40, false, 0.0, "YBIIQN", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 91, new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 41, false, 0.0, "TFEFRZ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 87, 58, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 42, true, 0.0, "AMIEAN", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 54, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 43, true, 0.0, "FSUMAV", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 88, new DateTime(2024, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 44, true, 0.0, "FAULTP", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 91, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 45, true, 0.0, "PTUMTM", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 71, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 46, true, 0.0, "ESICSL", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 92, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 47, false, 0.0, "TWOWFY", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, 13, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 48, false, 0.0, "DBIGYS", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 34, 36, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 49, true, 0.0, "MIISVK", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 50, new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 50, true, 0.0, "ANUTRW", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 80, new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 51, false, 0.0, "NAAGAK", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 40, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 52, false, 0.0, "EPITAW", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 54, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 53, true, 0.0, "KWAHRQ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 81, 53, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 54, false, 0.0, "KIASNN", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 20, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 55, true, 0.0, "MUECOM", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 41, new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 56, false, 0.0, "QGULCB", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 70, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 57, false, 0.0, "DPITRV", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 64, 38, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 58, false, 0.0, "JJIDKJ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2025, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 78, 37, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 59, false, 0.0, "FIOSDF", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 69, 99, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 60, true, 0.0, "IUOPLU", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 11, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 61, true, 0.0, "DCIMMY", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 50, new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 62, false, 0.0, "NROPNW", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, 85, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 63, false, 0.0, "OLEGPR", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 19, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 64, false, 0.0, "VXASDK", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 51, 73, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 65, false, 0.0, "YGAGDU", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 94, 77, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 66, true, 0.0, "MCESTG", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 71, 45, new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 67, true, 0.0, "GIOVAH", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 69, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 68, true, 0.0, "GUAAMX", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, 24, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 69, false, 0.0, "JEOAXP", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 24, new DateTime(2024, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 70, true, 0.0, "KJEHTC", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 26, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 71, false, 0.0, "XHETCB", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 51, new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 72, false, 0.0, "NLIGHS", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 86, 4, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 73, true, 0.0, "RGEPRO", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 96, 65, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 74, false, 0.0, "UYAAEE", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 23, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 75, false, 0.0, "ZPEBTF", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, 72, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 76, false, 0.0, "HSACCO", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 44, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 77, true, 0.0, "GXAGBM", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 55, 50, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 78, false, 0.0, "UWEAQR", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 24, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 79, true, 0.0, "MNONUY", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 27, new DateTime(2024, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 80, false, 0.0, "CNUUZT", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 75, new DateTime(2024, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 81, true, 0.0, "PCAEUZ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 98, 36, new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 82, true, 0.0, "UQOYEZ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 53, 6, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 83, true, 0.0, "HZACXM", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 84, 22, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 84, false, 0.0, "HOAEHP", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 76, 28, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 85, true, 0.0, "KAUMMB", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 83, new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 86, false, 0.0, "ZEUNIM", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, 81, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 87, false, 0.0, "REEYER", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 83, 6, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 88, true, 0.0, "FYACNG", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 82, 24, new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 89, false, 0.0, "WHICYV", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, 72, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 90, true, 0.0, "WJABFL", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, 49, new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 91, false, 0.0, "QCIMEW", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 20, new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 92, true, 0.0, "LMIMFZ", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, 31, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 93, true, 0.0, "BQENZU", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 85, 1, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 94, false, 0.0, "FWINIR", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 56, new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 95, false, 0.0, "HXEMRE", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 14, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 96, true, 0.0, "RAAAFS", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 72, 42, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 97, false, 0.0, "KAUJPI", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 89, 9, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null },
                    { 98, true, 0.0, "JEEAIN", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 61, 29, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 3.0, null },
                    { 99, false, 0.0, "PRITMY", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, 97, new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 2.0, null },
                    { 100, false, 0.0, "AUAIDI", new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 59, 30, new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.0, 0.0, 1.0, null }
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "FavoritesId", "CreatedAt", "CreatedBy", "PersonId", "RoomId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 91, 34, null },
                    { 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 61, 56, null },
                    { 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 69, 51, null },
                    { 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, 99, null },
                    { 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 77, 93, null },
                    { 6, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 93, 56, null },
                    { 7, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 43, 73, null },
                    { 8, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 66, 1, null },
                    { 9, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 89, 3, null },
                    { 10, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 95, 49, null },
                    { 11, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, 61, null },
                    { 12, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 65, 30, null },
                    { 13, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 86, 64, null },
                    { 14, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 4, null },
                    { 15, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, 78, null },
                    { 16, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 40, 94, null },
                    { 17, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 52, 11, null },
                    { 18, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 31, 4, null },
                    { 19, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 96, 12, null },
                    { 20, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 92, 50, null },
                    { 21, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 78, 61, null },
                    { 22, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 88, 66, null },
                    { 23, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 47, 88, null },
                    { 24, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 34, 56, null },
                    { 25, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 32, 4, null },
                    { 26, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 64, 38, null },
                    { 27, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 33, 27, null },
                    { 28, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 70, 44, null },
                    { 29, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 25, 46, null },
                    { 30, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 97, 40, null },
                    { 31, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 73, 66, null },
                    { 32, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 30, 11, null },
                    { 33, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 39, 92, null },
                    { 34, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 46, 84, null },
                    { 35, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 92, 65, null },
                    { 36, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 77, 70, null },
                    { 37, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 57, 41, null },
                    { 38, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 82, 81, null },
                    { 39, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 49, 62, null },
                    { 40, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 59, 11, null },
                    { 41, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 65, 100, null },
                    { 42, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, 61, null },
                    { 43, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 67, 47, null },
                    { 44, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, 28, null },
                    { 45, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 8, 97, null },
                    { 46, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 81, 18, null },
                    { 47, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 97, 51, null },
                    { 48, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 20, 24, null },
                    { 49, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 99, 60, null },
                    { 50, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 29, 68, null },
                    { 51, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 18, 63, null },
                    { 52, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 86, 46, null },
                    { 53, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, 12, null },
                    { 54, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 33, 44, null },
                    { 55, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 57, 7, null },
                    { 56, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 47, 22, null },
                    { 57, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 95, 92, null },
                    { 58, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 41, 18, null },
                    { 59, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, 16, null },
                    { 60, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 65, 64, null },
                    { 61, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 80, 28, null },
                    { 62, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, 93, null },
                    { 63, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 98, 51, null },
                    { 64, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 25, 87, null },
                    { 65, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 64, 24, null },
                    { 66, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, 28, null },
                    { 67, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 45, 16, null },
                    { 68, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, 19, null },
                    { 69, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 75, 98, null },
                    { 70, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 51, 3, null },
                    { 71, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 77, 70, null },
                    { 72, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 18, 64, null },
                    { 73, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 36, 26, null },
                    { 74, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 56, 36, null },
                    { 75, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 42, 53, null },
                    { 76, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 22, 43, null },
                    { 77, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 32, 11, null },
                    { 78, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 87, 95, null },
                    { 79, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, 7, null },
                    { 80, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 47, 85, null },
                    { 81, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 35, 41, null },
                    { 82, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 100, 90, null },
                    { 83, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 9, 68, null },
                    { 84, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 83, 88, null },
                    { 85, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 91, 98, null },
                    { 86, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 85, 17, null },
                    { 87, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 71, 48, null },
                    { 88, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 48, 14, null },
                    { 89, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 27, 46, null },
                    { 90, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 83, 68, null },
                    { 91, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 36, 29, null },
                    { 92, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 33, 75, null },
                    { 93, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 72, 56, null },
                    { 94, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 81, 96, null },
                    { 95, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 1, 34, null },
                    { 96, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 54, 39, null },
                    { 97, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 94, 2, null },
                    { 98, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 47, 93, null },
                    { 99, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 65, 70, null },
                    { 100, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 49, 13, null }
                });

            migrationBuilder.InsertData(
                table: "PersonBooking",
                columns: new[] { "PersonBookingId", "BookingId", "CreatedAt", "CreatedBy", "PersonId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 9, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 77, null },
                    { 2, 71, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 48, null },
                    { 3, 42, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 95, null },
                    { 4, 87, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 69, null },
                    { 5, 63, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, null },
                    { 6, 62, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 88, null },
                    { 7, 43, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 79, null },
                    { 8, 43, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 72, null },
                    { 9, 83, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 62, null },
                    { 10, 74, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 91, null },
                    { 11, 49, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 97, null },
                    { 12, 23, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 73, null },
                    { 13, 76, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 15, null },
                    { 14, 13, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 80, null },
                    { 15, 72, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 9, null },
                    { 16, 83, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 44, null },
                    { 17, 64, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 86, null },
                    { 18, 88, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 47, null },
                    { 19, 82, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 56, null },
                    { 20, 20, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 89, null },
                    { 21, 49, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 77, null },
                    { 22, 15, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 25, null },
                    { 23, 92, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, null },
                    { 24, 3, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 46, null },
                    { 25, 42, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 55, null },
                    { 26, 18, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 62, null },
                    { 27, 28, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 48, null },
                    { 28, 58, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 7, null },
                    { 29, 71, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 70, null },
                    { 30, 88, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 46, null },
                    { 31, 18, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 27, null },
                    { 32, 8, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 51, null },
                    { 33, 45, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 65, null },
                    { 34, 27, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 35, null },
                    { 35, 54, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 34, null },
                    { 36, 98, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 10, null },
                    { 37, 69, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 46, null },
                    { 38, 27, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 72, null },
                    { 39, 69, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 33, null },
                    { 40, 9, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 59, null },
                    { 41, 24, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 79, null },
                    { 42, 77, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, null },
                    { 43, 10, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 63, null },
                    { 44, 8, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, null },
                    { 45, 34, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 100, null },
                    { 46, 90, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 71, null },
                    { 47, 36, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 34, null },
                    { 48, 15, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 96, null },
                    { 49, 41, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, null },
                    { 50, 46, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 93, null },
                    { 51, 18, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 22, null },
                    { 52, 99, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 30, null },
                    { 53, 41, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 76, null },
                    { 54, 78, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, null },
                    { 55, 13, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 53, null },
                    { 56, 33, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 9, null },
                    { 57, 55, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 58, null },
                    { 58, 22, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 92, null },
                    { 59, 93, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 35, null },
                    { 60, 63, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 49, null },
                    { 61, 68, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 77, null },
                    { 62, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 33, null },
                    { 63, 65, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 61, null },
                    { 64, 31, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 59, null },
                    { 65, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 96, null },
                    { 66, 81, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 29, null },
                    { 67, 93, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 35, null },
                    { 68, 55, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 9, null },
                    { 69, 11, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 91, null },
                    { 70, 98, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 22, null },
                    { 71, 33, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 71, null },
                    { 72, 54, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 91, null },
                    { 73, 69, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 78, null },
                    { 74, 26, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, null },
                    { 75, 99, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 77, null },
                    { 76, 58, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 7, null },
                    { 77, 50, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, null },
                    { 78, 23, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 61, null },
                    { 79, 6, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 65, null },
                    { 80, 94, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 57, null },
                    { 81, 37, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 14, null },
                    { 82, 90, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 8, null },
                    { 83, 26, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 49, null },
                    { 84, 98, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 68, null },
                    { 85, 34, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 76, null },
                    { 86, 76, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 79, null },
                    { 87, 56, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 92, null },
                    { 88, 53, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 33, null },
                    { 89, 93, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 49, null },
                    { 90, 75, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 28, null },
                    { 91, 57, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 62, null },
                    { 92, 63, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 28, null },
                    { 93, 65, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 28, null },
                    { 94, 28, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 20, null },
                    { 95, 49, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 89, null },
                    { 96, 31, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 61, null },
                    { 97, 46, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 93, null },
                    { 98, 44, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 78, null },
                    { 99, 8, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 39, null },
                    { 100, 99, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 66, null },
                    { 101, 95, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 18, null },
                    { 102, 71, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 40, null },
                    { 103, 44, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 55, null },
                    { 104, 97, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 68, null },
                    { 105, 23, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, null },
                    { 106, 77, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 33, null },
                    { 107, 37, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 37, null },
                    { 108, 16, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, null },
                    { 109, 42, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 52, null },
                    { 110, 92, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 28, null },
                    { 111, 76, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 52, null },
                    { 112, 10, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 29, null },
                    { 113, 57, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 7, null },
                    { 114, 36, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 74, null },
                    { 115, 81, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 61, null },
                    { 116, 13, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 50, null },
                    { 117, 97, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 61, null },
                    { 118, 11, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 82, null },
                    { 119, 49, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 45, null },
                    { 120, 88, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 51, null },
                    { 121, 21, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 58, null },
                    { 122, 38, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 57, null },
                    { 123, 98, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, null },
                    { 124, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 90, null },
                    { 125, 42, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 53, null },
                    { 126, 58, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 85, null },
                    { 127, 33, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 64, null },
                    { 128, 81, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 97, null },
                    { 129, 60, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 10, null },
                    { 130, 100, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 85, null },
                    { 131, 63, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, null },
                    { 132, 27, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, null },
                    { 133, 42, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 94, null },
                    { 134, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 31, null },
                    { 135, 46, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 21, null },
                    { 136, 52, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 91, null },
                    { 137, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 29, null },
                    { 138, 70, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, null },
                    { 139, 63, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 43, null },
                    { 140, 30, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 27, null },
                    { 141, 25, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, null },
                    { 142, 81, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 25, null },
                    { 143, 44, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 22, null },
                    { 144, 63, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 43, null },
                    { 145, 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 45, null },
                    { 146, 42, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 32, null },
                    { 147, 49, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 58, null },
                    { 148, 66, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 19, null },
                    { 149, 94, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 40, null },
                    { 150, 8, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 40, null },
                    { 151, 71, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 70, null },
                    { 152, 2, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 52, null },
                    { 153, 49, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 4, null },
                    { 154, 95, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 76, null },
                    { 155, 57, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 88, null },
                    { 156, 54, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 83, null },
                    { 157, 4, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 99, null },
                    { 158, 31, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 23, null },
                    { 159, 97, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 61, null },
                    { 160, 7, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 6, null },
                    { 161, 93, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 32, null },
                    { 162, 32, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 96, null },
                    { 163, 74, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 92, null },
                    { 164, 86, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 58, null },
                    { 165, 94, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 14, null },
                    { 166, 83, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 95, null },
                    { 167, 26, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 73, null },
                    { 168, 39, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 39, null },
                    { 169, 88, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 100, null },
                    { 170, 61, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 85, null },
                    { 171, 23, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 79, null },
                    { 172, 50, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, null },
                    { 173, 22, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, null },
                    { 174, 65, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 68, null },
                    { 175, 65, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, null },
                    { 176, 63, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 38, null },
                    { 177, 90, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 98, null },
                    { 178, 59, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 80, null },
                    { 179, 74, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 39, null },
                    { 180, 83, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 40, null },
                    { 181, 80, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 85, null },
                    { 182, 85, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 96, null },
                    { 183, 98, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 35, null },
                    { 184, 98, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 60, null },
                    { 185, 69, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 86, null },
                    { 186, 5, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 41, null },
                    { 187, 84, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 14, null },
                    { 188, 52, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 8, null },
                    { 189, 22, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 40, null },
                    { 190, 69, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 13, null },
                    { 191, 38, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, null },
                    { 192, 81, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 64, null },
                    { 193, 89, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, null },
                    { 194, 54, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 22, null },
                    { 195, 51, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 15, null },
                    { 196, 72, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 24, null },
                    { 197, 60, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 29, null },
                    { 198, 97, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 5, null },
                    { 199, 17, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 46, null },
                    { 200, 75, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 100, null },
                    { 201, 21, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 43, null },
                    { 202, 45, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 74, null },
                    { 203, 91, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 80, null },
                    { 204, 64, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 25, null },
                    { 205, 43, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 66, null },
                    { 206, 6, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 39, null },
                    { 207, 21, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 29, null },
                    { 208, 91, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 85, null },
                    { 209, 32, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 16, null },
                    { 210, 21, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 47, null },
                    { 211, 10, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 64, null },
                    { 212, 76, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 81, null },
                    { 213, 10, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 76, null },
                    { 214, 94, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 72, null },
                    { 215, 45, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 71, null },
                    { 216, 95, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 98, null },
                    { 217, 8, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 49, null },
                    { 218, 18, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 52, null },
                    { 219, 51, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 60, null },
                    { 220, 94, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 72, null },
                    { 221, 29, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 19, null },
                    { 222, 81, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 70, null },
                    { 223, 77, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 12, null },
                    { 224, 100, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 11, null },
                    { 225, 82, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 67, null },
                    { 226, 11, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 34, null },
                    { 227, 62, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 92, null },
                    { 228, 32, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 47, null },
                    { 229, 99, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 38, null },
                    { 230, 47, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 64, null },
                    { 231, 100, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 35, null },
                    { 232, 97, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 19, null },
                    { 233, 15, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 28, null },
                    { 234, 55, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 70, null },
                    { 235, 78, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 58, null },
                    { 236, 59, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 37, null },
                    { 237, 51, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 69, null },
                    { 238, 47, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 51, null },
                    { 239, 58, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 39, null },
                    { 240, 72, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 70, null },
                    { 241, 25, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 56, null },
                    { 242, 9, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 88, null },
                    { 243, 29, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 32, null },
                    { 244, 7, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 20, null },
                    { 245, 40, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 2, null },
                    { 246, 69, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 87, null },
                    { 247, 46, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 46, null },
                    { 248, 22, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 9, null },
                    { 249, 57, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 38, null },
                    { 250, 6, new DateTime(2024, 6, 6, 12, 35, 45, 615, DateTimeKind.Utc).AddTicks(3448), "ApiNet", 53, null }
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
                name: "IX_Person_UserId",
                table: "Person",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Session_UserID",
                table: "Session",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "PersonBooking");

            migrationBuilder.DropTable(
                name: "Session");

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
                name: "User");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
