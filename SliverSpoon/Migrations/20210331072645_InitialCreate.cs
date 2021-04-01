using Microsoft.EntityFrameworkCore.Migrations;

namespace SliverSpoon.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    StaffName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StaffPosition = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StaffContactNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    JobType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
