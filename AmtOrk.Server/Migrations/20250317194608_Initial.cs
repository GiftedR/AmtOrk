using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AmtOrk.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AmtUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    HeraldryPath = table.Column<string>(type: "TEXT", nullable: false),
                    PersonaName = table.Column<string>(type: "TEXT", nullable: false),
                    IsRestricted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsWaivered = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsSuspended = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordExpires = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReeveQualified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CorporaQualified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ParkMemberSince = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmtUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClassName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Credit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreditDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    CreditKingdomId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreditParkId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreditEventId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreditClassId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreditCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AmtUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Credit_AmtUser_AmtUserId",
                        column: x => x.AmtUserId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kingdom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KingdomName = table.Column<string>(type: "TEXT", nullable: false),
                    KingdomDesciption = table.Column<string>(type: "TEXT", nullable: true),
                    MonarchId = table.Column<string>(type: "TEXT", nullable: true),
                    RegentId = table.Column<string>(type: "TEXT", nullable: true),
                    ChampionId = table.Column<string>(type: "TEXT", nullable: true),
                    PrimeMinisterId = table.Column<string>(type: "TEXT", nullable: true),
                    GMRId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kingdom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kingdom_AmtUser_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kingdom_AmtUser_GMRId",
                        column: x => x.GMRId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kingdom_AmtUser_MonarchId",
                        column: x => x.MonarchId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kingdom_AmtUser_PrimeMinisterId",
                        column: x => x.PrimeMinisterId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kingdom_AmtUser_RegentId",
                        column: x => x.RegentId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Land",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LandName = table.Column<string>(type: "TEXT", nullable: false),
                    LandDescription = table.Column<string>(type: "TEXT", nullable: false),
                    LandLocation = table.Column<string>(type: "TEXT", nullable: false),
                    KingdomId = table.Column<int>(type: "INTEGER", nullable: false),
                    MonarchId = table.Column<string>(type: "TEXT", nullable: true),
                    RegentId = table.Column<string>(type: "TEXT", nullable: true),
                    ChampionId = table.Column<string>(type: "TEXT", nullable: true),
                    PrimeMinisterId = table.Column<string>(type: "TEXT", nullable: true),
                    GMRId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Land", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Land_AmtUser_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Land_AmtUser_GMRId",
                        column: x => x.GMRId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Land_AmtUser_MonarchId",
                        column: x => x.MonarchId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Land_AmtUser_PrimeMinisterId",
                        column: x => x.PrimeMinisterId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Land_AmtUser_RegentId",
                        column: x => x.RegentId,
                        principalTable: "AmtUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Land_Kingdom_KingdomId",
                        column: x => x.KingdomId,
                        principalTable: "Kingdom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventName = table.Column<string>(type: "TEXT", nullable: false),
                    EventLocation = table.Column<string>(type: "TEXT", nullable: false),
                    EventDescription = table.Column<string>(type: "TEXT", nullable: false),
                    EventStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EventEndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KingdomId = table.Column<int>(type: "INTEGER", nullable: true),
                    LandId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_Kingdom_KingdomId",
                        column: x => x.KingdomId,
                        principalTable: "Kingdom",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Event_Land_LandId",
                        column: x => x.LandId,
                        principalTable: "Land",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassName" },
                values: new object[,]
                {
                    { 1, "Anti-Paladin" },
                    { 2, "Archer" },
                    { 3, "Assassin" },
                    { 4, "Barbarian" },
                    { 5, "Bard" },
                    { 6, "Color" },
                    { 7, "Druid" },
                    { 8, "Healer" },
                    { 9, "Monk" },
                    { 10, "Monster" },
                    { 11, "Paladin" },
                    { 12, "Peasant" },
                    { 13, "Reeve" },
                    { 14, "Scout" },
                    { 15, "Warrior" },
                    { 16, "Wizard" }
                });

            migrationBuilder.InsertData(
                table: "Kingdom",
                columns: new[] { "Id", "ChampionId", "GMRId", "KingdomDesciption", "KingdomName", "MonarchId", "PrimeMinisterId", "RegentId" },
                values: new object[,]
                {
                    { 1, null, null, null, "13 Roads", null, null, null },
                    { 2, null, null, null, "Kingdom of Desert Winds", null, null, null },
                    { 3, null, null, null, "The Celestial Kingdom", null, null, null },
                    { 4, null, null, null, "The Empire of Rivermoor", null, null, null },
                    { 5, null, null, null, "The Empire of the Iron Mountains", null, null, null },
                    { 6, null, null, null, "The Freeholds of Amtgard", null, null, null },
                    { 7, null, null, null, "The Kingdom of Blackspire", null, null, null },
                    { 8, null, null, null, "The Kingdom of Burning Lands", null, null, null },
                    { 9, null, null, null, "The Kingdom of Crystal Groves", null, null, null },
                    { 10, null, null, null, "The Kingdom of Dragonspine", null, null, null },
                    { 11, null, null, null, "The Kingdom of Goldenvale", null, null, null },
                    { 12, null, null, null, "The Kingdom of Neverwinter", null, null, null },
                    { 13, null, null, null, "The Kingdom of Northern Lights", null, null, null },
                    { 14, null, null, null, "The Kingdom of Northreach", null, null, null },
                    { 15, null, null, null, "The Kingdom of Polaris", null, null, null },
                    { 16, null, null, null, "The Kingdom of Tal Dagore", null, null, null },
                    { 17, null, null, null, "The Kingdom of the Emerald Hills", null, null, null },
                    { 18, null, null, null, "The Kingdom of the Golden Plains", null, null, null },
                    { 19, null, null, null, "The Kingdom of the Nine Blades", null, null, null },
                    { 20, null, null, null, "The Kingdom of the Rising Winds", null, null, null },
                    { 21, null, null, null, "The Kingdom of the Wetlands", null, null, null },
                    { 22, null, null, null, "The Kingdom of Viridian Outlands", null, null, null },
                    { 23, null, null, null, "The Kingdom of Westmarch", null, null, null },
                    { 24, null, null, null, "The Kingdom of Winters Edge", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Land",
                columns: new[] { "Id", "ChampionId", "GMRId", "KingdomId", "LandDescription", "LandLocation", "LandName", "MonarchId", "PrimeMinisterId", "RegentId" },
                values: new object[,]
                {
                    { 1, null, null, 13, "Blade's Edge meets three times a week:\nTuesday @ 4:00pm -Fighter Practice\nFriday @ 4:00pm - Fighter Practice\nSaturday @ 1:00pm -Park Day", "2729 Jackson Ave SE, Port Orchard, WA 98366, USA", "Blade's Edge", null, null, null },
                    { 2, null, null, 13, "", "", "Dragons of Fire Valley", null, null, null },
                    { 3, null, null, 13, "", "", "Greenwood Keep", null, null, null },
                    { 4, null, null, 13, "", "", "Inland Ocean", null, null, null },
                    { 5, null, null, 13, "", "", "Lost Cove", null, null, null },
                    { 6, null, null, 13, "", "", "Mithril Hills", null, null, null },
                    { 7, null, null, 13, "", "", "Oceans Alley", null, null, null },
                    { 8, null, null, 13, "", "", "Seaside Keep", null, null, null },
                    { 9, null, null, 13, "", "", "Shrouding Mist", null, null, null },
                    { 10, null, null, 13, "", "", "The Hollow", null, null, null },
                    { 11, null, null, 13, "", "", "Three Lakes", null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_ClassName",
                table: "Classes",
                column: "ClassName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Credit_AmtUserId",
                table: "Credit",
                column: "AmtUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_KingdomId",
                table: "Event",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_LandId",
                table: "Event",
                column: "LandId");

            migrationBuilder.CreateIndex(
                name: "IX_Kingdom_ChampionId",
                table: "Kingdom",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_Kingdom_GMRId",
                table: "Kingdom",
                column: "GMRId");

            migrationBuilder.CreateIndex(
                name: "IX_Kingdom_KingdomName",
                table: "Kingdom",
                column: "KingdomName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kingdom_MonarchId",
                table: "Kingdom",
                column: "MonarchId");

            migrationBuilder.CreateIndex(
                name: "IX_Kingdom_PrimeMinisterId",
                table: "Kingdom",
                column: "PrimeMinisterId");

            migrationBuilder.CreateIndex(
                name: "IX_Kingdom_RegentId",
                table: "Kingdom",
                column: "RegentId");

            migrationBuilder.CreateIndex(
                name: "IX_Land_ChampionId",
                table: "Land",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_Land_GMRId",
                table: "Land",
                column: "GMRId");

            migrationBuilder.CreateIndex(
                name: "IX_Land_KingdomId",
                table: "Land",
                column: "KingdomId");

            migrationBuilder.CreateIndex(
                name: "IX_Land_MonarchId",
                table: "Land",
                column: "MonarchId");

            migrationBuilder.CreateIndex(
                name: "IX_Land_PrimeMinisterId",
                table: "Land",
                column: "PrimeMinisterId");

            migrationBuilder.CreateIndex(
                name: "IX_Land_RegentId",
                table: "Land",
                column: "RegentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Credit");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Land");

            migrationBuilder.DropTable(
                name: "Kingdom");

            migrationBuilder.DropTable(
                name: "AmtUser");
        }
    }
}
