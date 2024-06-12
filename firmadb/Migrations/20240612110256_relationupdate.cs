using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace firmadb.Migrations
{
    /// <inheritdoc />
    public partial class relationupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laenutus_LaenutatavadAsjad_LaenutatavadAsjadItemID",
                table: "Laenutus");

            migrationBuilder.DropForeignKey(
                name: "FK_Lapsevanem_Employee_EmployeeID",
                table: "Lapsevanem");

            migrationBuilder.DropIndex(
                name: "IX_Lapsevanem_EmployeeID",
                table: "Lapsevanem");

            migrationBuilder.DropIndex(
                name: "IX_Laenutus_LaenutatavadAsjadItemID",
                table: "Laenutus");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Lapsevanem");

            migrationBuilder.DropColumn(
                name: "LaenutatavadAsjadItemID",
                table: "Laenutus");

            migrationBuilder.CreateIndex(
                name: "IX_Lapsevanem_ParentEmployee",
                table: "Lapsevanem",
                column: "ParentEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_ItemID",
                table: "Laenutus",
                column: "ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Laenutus_LaenutatavadAsjad_ItemID",
                table: "Laenutus",
                column: "ItemID",
                principalTable: "LaenutatavadAsjad",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lapsevanem_Employee_ParentEmployee",
                table: "Lapsevanem",
                column: "ParentEmployee",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Laenutus_LaenutatavadAsjad_ItemID",
                table: "Laenutus");

            migrationBuilder.DropForeignKey(
                name: "FK_Lapsevanem_Employee_ParentEmployee",
                table: "Lapsevanem");

            migrationBuilder.DropIndex(
                name: "IX_Lapsevanem_ParentEmployee",
                table: "Lapsevanem");

            migrationBuilder.DropIndex(
                name: "IX_Laenutus_ItemID",
                table: "Laenutus");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Lapsevanem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LaenutatavadAsjadItemID",
                table: "Laenutus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Lapsevanem_EmployeeID",
                table: "Lapsevanem",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_LaenutatavadAsjadItemID",
                table: "Laenutus",
                column: "LaenutatavadAsjadItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Laenutus_LaenutatavadAsjad_LaenutatavadAsjadItemID",
                table: "Laenutus",
                column: "LaenutatavadAsjadItemID",
                principalTable: "LaenutatavadAsjad",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lapsevanem_Employee_EmployeeID",
                table: "Lapsevanem",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
