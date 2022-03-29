using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class add_read_column_in_message2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<bool>(
                name: "Read",
                table: "Messages2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message2TrashBins");

          
            migrationBuilder.DropColumn(
                name: "Read",
                table: "Messages2s");

        }
    }
}
