using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlogDate",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "BlogThumbnailImage",
                table: "Blogs",
                newName: "BlogThumbNailImage");

            migrationBuilder.AddColumn<DateTime>(
                name: "BlogDate",
                table: "Blogs",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Writers_WriterID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_WriterID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogDate",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "BlogThumbNailImage",
                table: "Blogs",
                newName: "BlogThumbnailImage");

            migrationBuilder.AddColumn<string>(
                name: "BlogDate",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
