using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace hospitalGQL.Migrations
{
    public partial class AddPatientToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    cpr_patient = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    patient_name = table.Column<string>(type: "text", nullable: false),
                    blood_type = table.Column<string>(type: "text", nullable: true),
                    house_number = table.Column<long>(type: "bigint", nullable: false),
                    street = table.Column<string>(type: "text", nullable: true),
                    postal_code = table.Column<long>(type: "bigint", nullable: false),
                    city = table.Column<string>(type: "text", nullable: true),
                    phone = table.Column<long>(type: "bigint", nullable: false),
                    gender = table.Column<string>(type: "text", nullable: true),
                    last_update = table.Column<DateTime>(type: "date", nullable: true),
                    patient_status = table.Column<string>(type: "text", nullable: true),
                    cpr_doctor = table.Column<long>(type: "bigint", nullable: false),
                    DoctorId = table.Column<long>(type: "bigint", nullable: false),
                    RoomID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.cpr_patient);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
