using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace hospitalGQL.Migrations
{
    public partial class AddRoomToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    room_number = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    room_type = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    cpr_patient = table.Column<long>(type: "bigint", nullable: false),
                    cpr_doctor = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.room_number);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RoomID",
                table: "Patients",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Rooms_RoomID",
                table: "Patients",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "room_number",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Rooms_RoomID",
                table: "Patients");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Patients_RoomID",
                table: "Patients");
        }
    }
}
