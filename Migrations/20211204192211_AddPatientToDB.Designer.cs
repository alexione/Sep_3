﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using hospitalGQL.Data;

namespace hospitalGQL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211204192211_AddPatientToDB")]
    partial class AddPatientToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("hospitalGQL.Models.Patient", b =>
                {
                    b.Property<int>("cpr_patient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<int>("RoomID")
                        .HasColumnType("integer");

                    b.Property<string>("blood_type")
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<int>("cpr_doctor")
                        .HasColumnType("integer");

                    b.Property<string>("gender")
                        .HasColumnType("text");

                    b.Property<int>("house_number")
                        .HasColumnType("integer");

                    b.Property<int>("last_update")
                        .HasColumnType("integer");

                    b.Property<string>("patient_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("patient_status")
                        .HasColumnType("text");

                    b.Property<int>("phone")
                        .HasColumnType("integer");

                    b.Property<int>("postal_code")
                        .HasColumnType("integer");

                    b.Property<string>("street")
                        .HasColumnType("text");

                    b.HasKey("cpr_patient");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
