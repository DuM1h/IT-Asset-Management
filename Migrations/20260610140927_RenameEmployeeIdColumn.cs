using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT_Asset_Management.Migrations
{
    /// <inheritdoc />
    public partial class RenameEmployeeIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Employees_EmployeeID",
                table: "Equipments");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Equipments",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Equipments_EmployeeID",
                table: "Equipments",
                newName: "IX_Equipments_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Employees_EmployeeId",
                table: "Equipments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Employees_EmployeeId",
                table: "Equipments");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Equipments",
                newName: "EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_Equipments_EmployeeId",
                table: "Equipments",
                newName: "IX_Equipments_EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Employees_EmployeeID",
                table: "Equipments",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "Id");
        }
    }
}
