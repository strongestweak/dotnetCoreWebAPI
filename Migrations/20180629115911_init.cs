using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookName",
                table: "tblBooks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookName",
                table: "tblBooks");
        }
    }
}
