using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Your_Health.Server.Models;

namespace Your_Health.Server.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Appointment> appointments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>()
            .HasMany(e => e.Patients)
            .WithOne(e => e.doctor)
            .HasForeignKey(e => e.DocId)
            .IsRequired();

            modelBuilder.Entity<Speciality>()
            .HasMany(e => e.Doctors)
            .WithOne(e => e.speciality)
            .HasForeignKey(e => e.SpecialityId)
            .IsRequired();

            modelBuilder.Entity<Doctor>()
            .HasMany(e => e.Appointments)
            .WithOne(e => e.doctor)
            .HasForeignKey(e => e.DocId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

            modelBuilder.Entity<Patient>()
            .HasOne(e => e.Appointment)
            .WithOne(e => e.patient)
            .HasForeignKey<Appointment>(e => e.PatientId)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();

            modelBuilder.Entity<Speciality>().HasData(
                new Speciality { SpecialityId = 1, SpecialityName = "Cardiology" },
                new Speciality { SpecialityId = 2, SpecialityName = "Dermatology" },
                new Speciality { SpecialityId = 3, SpecialityName = "Endocrinology" },
                new Speciality { SpecialityId = 4, SpecialityName = "Gastroenterology" },
                new Speciality { SpecialityId = 5, SpecialityName = "Hematology" },
                new Speciality { SpecialityId = 6, SpecialityName = "Infectious Disease" },
                new Speciality { SpecialityId = 7, SpecialityName = "Nephrology" },
                new Speciality { SpecialityId = 8, SpecialityName = "Neurology" },
                new Speciality { SpecialityId = 9, SpecialityName = "Oncology" },
                new Speciality { SpecialityId = 10, SpecialityName = "Pulmonology" }
            );
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DocId = 1, DocFirstName = "John", DocLastName = "Smith", email = "john.smith@example.com", phone = 1091095506, SpecialityId = 1 },
                new Doctor { DocId = 2, DocFirstName = "Emily", DocLastName = "Johnson", email = "emily.johnson@example.com", phone = 1024657893, SpecialityId = 2 },
                new Doctor { DocId = 3, DocFirstName = "Michael", DocLastName = "Williams", email = "mic@gmail.com", phone = 1025657893, SpecialityId = 3 },
                new Doctor { DocId = 4, DocFirstName = "Jessica", DocLastName = "Brown", email = "jessica.brown@example.com", phone = 1098765432, SpecialityId = 4 },
                new Doctor { DocId = 5, DocFirstName = "Daniel", DocLastName = "Davis", email = "dan.davis@example.com", phone = 1034567890, SpecialityId = 5 },
                new Doctor { DocId = 6, DocFirstName = "Sophia", DocLastName = "Miller", email = "sophia.miller@example.com", phone = 1045678901, SpecialityId = 6 },
                new Doctor { DocId = 7, DocFirstName = "James", DocLastName = "Wilson", email = "james.wilson@example.com", phone = 1056789012, SpecialityId = 7 },
                new Doctor { DocId = 8, DocFirstName = "Olivia", DocLastName = "Moore", email = "olivia.moore@example.com", phone = 1067890123, SpecialityId = 8 },
                new Doctor { DocId = 9, DocFirstName = "Liam", DocLastName = "Taylor", email = "liam.taylor@example.com", phone = 1078901234, SpecialityId = 9 },
                new Doctor { DocId = 10, DocFirstName = "Ava", DocLastName = "Anderson", email = "ava.anderson@example.com", phone = 1089012345, SpecialityId = 10 },
                new Doctor { DocId = 11, DocFirstName = "Ethan", DocLastName = "Thomas", email = "ethan.thomas@example.com", phone = 1090123456, SpecialityId = 1 },
                new Doctor { DocId = 12, DocFirstName = "Isabella", DocLastName = "Jackson", email = "isabella.jackson@example.com", phone = 1091234567, SpecialityId = 2 },
                new Doctor { DocId = 13, DocFirstName = "Mason", DocLastName = "White", email = "mason.white@example.com", phone = 1092345678, SpecialityId = 2 },
                new Doctor { DocId = 14, DocFirstName = "Mia", DocLastName = "Harris", email = "mia.harris@example.com", phone = 1093456789, SpecialityId = 4 },
                new Doctor { DocId = 15, DocFirstName = "Alexander", DocLastName = "Martin", email = "alex.martin@example.com", phone = 1094567890, SpecialityId = 1 },
                new Doctor { DocId = 16, DocFirstName = "Charlotte", DocLastName = "Thompson", email = "charlotte.thompson@example.com", phone = 1095678901, SpecialityId = 6 },
                new Doctor { DocId = 17, DocFirstName = "Henry", DocLastName = "Garcia", email = "henry.garcia@example.com", phone = 1096789012, SpecialityId = 6},
                new Doctor { DocId = 18, DocFirstName = "Amelia", DocLastName = "Martinez", email = "amelia.martinez@example.com", phone = 1097890123, SpecialityId = 5 },
                new Doctor { DocId = 19, DocFirstName = "Benjamin", DocLastName = "Robinson", email = "benjamin.robinson@example.com", phone = 1098901234, SpecialityId = 2 },
                new Doctor { DocId = 20, DocFirstName = "Harper", DocLastName = "Clark", email = "harper.clark@example.com", phone = 1099012345, SpecialityId = 7 }
            );
            modelBuilder.Entity<Patient>().HasData(
                new Patient { PatientId = 1, PatientName = "John Doe", phone = 1234567890, IsDiagnosed = false, DocId = 1 },
                new Patient { PatientId = 2, PatientName = "Jane Smith", phone = 345678901, IsDiagnosed = true, DocId = 2 },
                new Patient { PatientId = 3, PatientName = "Robert Brown", phone = 456789012, IsDiagnosed = false, DocId = 3 },
                new Patient { PatientId = 4, PatientName = "Emily Davis", phone = 567890123, IsDiagnosed = true, DocId = 4 },
                new Patient { PatientId = 5, PatientName = "Michael Johnson", phone = 678901234, IsDiagnosed = false, DocId = 5 },
                new Patient { PatientId = 6, PatientName = "Jessica Wilson", phone = 789012345, IsDiagnosed = true, DocId = 6 },
                new Patient { PatientId = 7, PatientName = "David Martinez", phone = 890123456, IsDiagnosed = false, DocId = 7 },
                new Patient { PatientId = 8, PatientName = "Sarah Lee", phone = 901234567, IsDiagnosed = true, DocId = 8 },
                new Patient { PatientId = 9, PatientName = "Daniel Hernandez", phone = 912345678, IsDiagnosed = false, DocId = 9 },
                new Patient { PatientId = 10, PatientName = "Laura Clark", phone = 1012345678, IsDiagnosed = true, DocId = 10 },
                new Patient { PatientId = 11, PatientName = "Kevin Lewis", phone = 1123456789, IsDiagnosed = false, DocId = 11 },
                new Patient { PatientId = 12, PatientName = "Sophia Walker", phone = 1234567891, IsDiagnosed = true, DocId = 12 },
                new Patient { PatientId = 13, PatientName = "Christopher Moore", phone = 1345678901, IsDiagnosed = false, DocId = 13 },
                new Patient { PatientId = 14, PatientName = "Amanda White", phone = 1456789012, IsDiagnosed = true, DocId = 14 },
                new Patient { PatientId = 15, PatientName = "Matthew Harris", phone = 1567890123, IsDiagnosed = false, DocId = 15 },
                new Patient { PatientId = 16, PatientName = "Olivia Clark", phone = 1678901234, IsDiagnosed = true, DocId = 16 },
                new Patient { PatientId = 17, PatientName = "Joshua Lewis", phone = 1789012345, IsDiagnosed = false, DocId = 17 },
                new Patient { PatientId = 18, PatientName = "Abigail Young", phone = 1890123456, IsDiagnosed = true, DocId = 18 },
                new Patient { PatientId = 19, PatientName = "Brandon King", phone = 1901234567, IsDiagnosed = false, DocId = 19 },
                new Patient { PatientId = 20, PatientName = "Megan Hall", phone = 1234567901, IsDiagnosed = true, DocId = 20 }
            );

            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { AppointmentId = 1, Date = DateTime.Now.AddDays(1), Description = "Checkup", IsConfirmed = true, DocId = 1, PatientId = 1 },
                new Appointment { AppointmentId = 2, Date = DateTime.Now.AddDays(2), Description = "Follow-up", IsConfirmed = false, DocId = 2, PatientId = 2 },
                new Appointment { AppointmentId = 3, Date = DateTime.Now.AddDays(3), Description = "Consultation", IsConfirmed = true, DocId = 3, PatientId = 3 },
                new Appointment { AppointmentId = 4, Date = DateTime.Now.AddDays(4), Description = "Routine Check", IsConfirmed = false, DocId = 4, PatientId = 4 },
                new Appointment { AppointmentId = 5, Date = DateTime.Now.AddDays(5), Description = "Surgery", IsConfirmed = true, DocId = 5, PatientId = 5 },
                new Appointment { AppointmentId = 6, Date = DateTime.Now.AddDays(6), Description = "Vaccination", IsConfirmed = false, DocId = 6, PatientId = 6 },
                new Appointment { AppointmentId = 7, Date = DateTime.Now.AddDays(7), Description = "Dental Check", IsConfirmed = true, DocId = 7, PatientId = 7 },
                new Appointment { AppointmentId = 8, Date = DateTime.Now.AddDays(8), Description = "Eye Exam", IsConfirmed = false, DocId = 8, PatientId = 8 },
                new Appointment { AppointmentId = 9, Date = DateTime.Now.AddDays(9), Description = "Physical Therapy", IsConfirmed = true, DocId = 9, PatientId = 9 },
                new Appointment { AppointmentId = 10, Date = DateTime.Now.AddDays(10), Description = "Dermatology", IsConfirmed = false, DocId = 10, PatientId = 10 },
                new Appointment { AppointmentId = 11, Date = DateTime.Now.AddDays(11), Description = "Neurology", IsConfirmed = true, DocId = 11, PatientId = 11 },
                new Appointment { AppointmentId = 12, Date = DateTime.Now.AddDays(12), Description = "Orthopedics", IsConfirmed = false, DocId = 12, PatientId = 12 },
                new Appointment { AppointmentId = 13, Date = DateTime.Now.AddDays(13), Description = "Cardiology", IsConfirmed = true, DocId = 13, PatientId = 13 },
                new Appointment { AppointmentId = 14, Date = DateTime.Now.AddDays(14), Description = "ENT Check", IsConfirmed = false, DocId = 14, PatientId = 14 },
                new Appointment { AppointmentId = 15, Date = DateTime.Now.AddDays(15), Description = "Gastroenterology", IsConfirmed = true, DocId = 15, PatientId = 15 },
                new Appointment { AppointmentId = 16, Date = DateTime.Now.AddDays(16), Description = "Psychiatry", IsConfirmed = false, DocId = 16, PatientId = 16 },
                new Appointment { AppointmentId = 17, Date = DateTime.Now.AddDays(17), Description = "Urology", IsConfirmed = true, DocId = 17, PatientId = 17 },
                new Appointment { AppointmentId = 18, Date = DateTime.Now.AddDays(18), Description = "Gynecology", IsConfirmed = false, DocId = 18, PatientId = 18 },
                new Appointment { AppointmentId = 19, Date = DateTime.Now.AddDays(19), Description = "Pediatrics", IsConfirmed = true, DocId = 19, PatientId = 19 },
                new Appointment { AppointmentId = 20, Date = DateTime.Now.AddDays(20), Description = "Oncology", IsConfirmed = false, DocId = 20, PatientId = 20 }
            );
            modelBuilder.Entity<IdentityRole>(IdentityRole => IdentityRole.HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Manager", NormalizedName = "MANAGER" },
                new IdentityRole { Id = "3", Name = "User", NormalizedName = "USER" }
            ));
        }

    }
}
