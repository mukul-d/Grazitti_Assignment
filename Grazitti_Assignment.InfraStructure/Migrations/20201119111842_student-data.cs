using Microsoft.EntityFrameworkCore.Migrations;

namespace Grazitti_Assignment.InfraStructure.Migrations
{
    public partial class studentdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class", "FirstName", "LastName", "Section" },
                values: new object[,]
                {
                    { 1, 7, "Student1", "Last1", "B" },
                    { 2, 5, "Student2", "Last3", "A" },
                    { 3, 7, "Student3", "Last3", "B" },
                    { 4, 7, "Student4", "Last4", "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
