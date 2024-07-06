using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AltenTvMazeRepositories.Migrations
{
    public partial class LastUpdatedDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedDate",
                table: "Shows",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 6, 18, 1, 0, 0, DateTimeKind.Utc));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastUpdatedDate",
                table: "Shows");
        }
    }
}
