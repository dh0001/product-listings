using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace store.Migrations
{
    public partial class adddesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ProductModel",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ProductModel");
        }
    }
}
