using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreWebApplication.Migrations
{
    public partial class yeniDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 18, 20, 1, 843, DateTimeKind.Local).AddTicks(4867));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 4, 11, 17, 59, 42, 14, DateTimeKind.Local).AddTicks(3294));
        }
    }
}
