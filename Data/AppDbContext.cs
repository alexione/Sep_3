using Microsoft.EntityFrameworkCore;
using hospitalGQL.Models;

namespace hospitalGQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }


        public DbSet<Room> Rooms { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Doctor>()
                .HasMany(p => p.Patients)
                .WithOne(p => p.Doctor!)
                .HasForeignKey(p => p.DoctorId);

            modelBuilder
                .Entity<Patient>()
                .HasOne(p => p.Doctor)
                .WithMany(p => p.Patients)
                .HasForeignKey(p => p.DoctorId);


            modelBuilder
                .Entity<Room>()
                .HasMany(p => p.Patients)
                .WithOne(p => p.Room!)
                .HasForeignKey(p => p.RoomID);

            modelBuilder
                .Entity<Patient>()
                .HasOne(p => p.Room)
                .WithMany(p => p.Patients)
                .HasForeignKey(p => p.RoomID);


            modelBuilder
                .Entity<Prescription>()
                .HasOne(p => p.Patient)
                .WithMany(p => p.Prescriptions)
                .HasForeignKey(p => p.PatientID);

            modelBuilder
                .Entity<Patient>()
                .HasMany(p => p.Prescriptions)
                .WithOne(p => p.Patient!)
                .HasForeignKey(p => p.PatientID);
        }
    }
}