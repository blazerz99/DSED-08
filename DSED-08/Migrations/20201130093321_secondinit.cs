using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DSED_06_AdoptAPet.Migrations
{
    public partial class secondinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppointmentDate = table.Column<DateTime>(nullable: false),
                    DogIDFK = table.Column<int>(nullable: false),
                    UserIDFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Appointment_Dogs_DogIDFK",
                        column: x => x.DogIDFK,
                        principalTable: "Dogs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointment_User_UserIDFK",
                        column: x => x.UserIDFK,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DogIDFK",
                table: "Appointment",
                column: "DogIDFK");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_UserIDFK",
                table: "Appointment",
                column: "UserIDFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");
        }
    }
}
