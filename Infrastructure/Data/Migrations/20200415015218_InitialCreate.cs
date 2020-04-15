using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    HtmlCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SortOrder = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuildTypesLgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Lang = table.Column<string>(nullable: true),
                    BuildTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildTypesLgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildTypesLgs_BuildTypes_BuildTypeId",
                        column: x => x.BuildTypeId,
                        principalTable: "BuildTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseTypeLgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Lang = table.Column<string>(nullable: true),
                    HouseTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseTypeLgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseTypeLgs_HouseTypes_HouseTypeId",
                        column: x => x.HouseTypeId,
                        principalTable: "HouseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Rooms = table.Column<int>(nullable: false),
                    Disabled = table.Column<int>(nullable: false),
                    MaxGuests = table.Column<int>(nullable: false),
                    SinglesRooms = table.Column<int>(nullable: false),
                    DoublesRooms = table.Column<int>(nullable: false),
                    TripleRooms = table.Column<int>(nullable: false),
                    BathRooms = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    CheckinFrom = table.Column<string>(nullable: true),
                    CheckinTo = table.Column<string>(nullable: true),
                    CheckoutUntil = table.Column<string>(nullable: true),
                    CancellationPolicy = table.Column<string>(nullable: true),
                    SortOrder = table.Column<int>(nullable: false),
                    PictureUrl = table.Column<string>(nullable: false),
                    HouseTypeId = table.Column<int>(nullable: false),
                    BuildTypeId = table.Column<int>(nullable: false),
                    PropertyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Houses_BuildTypes_BuildTypeId",
                        column: x => x.BuildTypeId,
                        principalTable: "BuildTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Houses_HouseTypes_HouseTypeId",
                        column: x => x.HouseTypeId,
                        principalTable: "HouseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Houses_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypeLgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Lang = table.Column<string>(nullable: true),
                    PropertyTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypeLgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyTypeLgs_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseDestinationLgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Lang = table.Column<string>(nullable: true),
                    HouseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseDestinationLgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseDestinationLgs_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HouseLgs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Lang = table.Column<string>(nullable: true),
                    HouseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseLgs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseLgs_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HousePhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PhotoUrl = table.Column<string>(nullable: true),
                    ThumbUrl = table.Column<string>(nullable: true),
                    HouseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HousePhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HousePhotos_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HousePrices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SeasonStartDate = table.Column<DateTime>(nullable: false),
                    SeasonEndDate = table.Column<DateTime>(nullable: false),
                    AllPropertyPrice = table.Column<double>(nullable: false),
                    ShareSingleRoomPrice = table.Column<double>(nullable: false),
                    ShareDoubleRoomPrice = table.Column<double>(nullable: false),
                    ShareTripleRoomPrice = table.Column<double>(nullable: false),
                    HouseId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HousePrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HousePrices_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HousePrices_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuildTypesLgs_BuildTypeId",
                table: "BuildTypesLgs",
                column: "BuildTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseDestinationLgs_HouseId",
                table: "HouseDestinationLgs",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseLgs_HouseId",
                table: "HouseLgs",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HousePhotos_HouseId",
                table: "HousePhotos",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_HousePrices_CurrencyId",
                table: "HousePrices",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_HousePrices_HouseId",
                table: "HousePrices",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_BuildTypeId",
                table: "Houses",
                column: "BuildTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_HouseTypeId",
                table: "Houses",
                column: "HouseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Houses_PropertyTypeId",
                table: "Houses",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseTypeLgs_HouseTypeId",
                table: "HouseTypeLgs",
                column: "HouseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyTypeLgs_PropertyTypeId",
                table: "PropertyTypeLgs",
                column: "PropertyTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildTypesLgs");

            migrationBuilder.DropTable(
                name: "HouseDestinationLgs");

            migrationBuilder.DropTable(
                name: "HouseLgs");

            migrationBuilder.DropTable(
                name: "HousePhotos");

            migrationBuilder.DropTable(
                name: "HousePrices");

            migrationBuilder.DropTable(
                name: "HouseTypeLgs");

            migrationBuilder.DropTable(
                name: "PropertyTypeLgs");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "BuildTypes");

            migrationBuilder.DropTable(
                name: "HouseTypes");

            migrationBuilder.DropTable(
                name: "PropertyTypes");
        }
    }
}
