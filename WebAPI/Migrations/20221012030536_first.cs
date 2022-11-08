using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblT_Household",
                columns: table => new
                {
                    HouseholdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountPeople = table.Column<int>(nullable: false),
                    Standmeter = table.Column<int>(nullable: false),
                    LpgConsumption = table.Column<int>(nullable: false),
                    CityGasConsumption = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblT_Household", x => x.HouseholdId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblT_Household");
        }
    }
}
