using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class AddRegister : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2023, 11, 21, 19, 31, 10, 763, DateTimeKind.Local).AddTicks(6238));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2023, 11, 21, 13, 35, 41, 695, DateTimeKind.Local).AddTicks(8551));
        }
    }
}
