using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_messagetable_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.CreateTable(
                name: "Messages2s",
                columns: table => new
                {
                    Message_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message_Sender = table.Column<int>(type: "int", nullable: true),
                    Message_Receiver = table.Column<int>(type: "int", nullable: true),
                    Message_Context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages2s", x => x.Message_ID);
                    table.ForeignKey(
                        name: "FK_Messages2s_Writers_Message_Receiver",
                        column: x => x.Message_Receiver,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages2s_Writers_Message_Sender",
                        column: x => x.Message_Sender,
                        principalTable: "Writers",
                        principalColumn: "WriterID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages2s_Message_Receiver",
                table: "Messages2s",
                column: "Message_Receiver");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2s_Message_Sender",
                table: "Messages2s",
                column: "Message_Sender");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages2s");

            migrationBuilder.DropColumn(
                name: "Durum",
                table: "Messages");
        }
    }
}
