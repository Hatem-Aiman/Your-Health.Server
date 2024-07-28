using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Your_Health.server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialities",
                columns: table => new
                {
                    SpecialityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialities", x => x.SpecialityId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    DocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    SpecialityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.DocId);
                    table.ForeignKey(
                        name: "FK_doctors_Specialities_SpecialityId",
                        column: x => x.SpecialityId,
                        principalTable: "Specialities",
                        principalColumn: "SpecialityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    IsDiagnosed = table.Column<bool>(type: "bit", nullable: false),
                    DocId = table.Column<int>(type: "int", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_patients_doctors_DocId",
                        column: x => x.DocId,
                        principalTable: "doctors",
                        principalColumn: "DocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    DocId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_appointments_doctors_DocId",
                        column: x => x.DocId,
                        principalTable: "doctors",
                        principalColumn: "DocId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_appointments_patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "SpecialityId", "SpecialityName" },
                values: new object[,]
                {
                    { 1, "Cardiology" },
                    { 2, "Dermatology" },
                    { 3, "Endocrinology" },
                    { 4, "Gastroenterology" },
                    { 5, "Hematology" },
                    { 6, "Infectious Disease" },
                    { 7, "Nephrology" },
                    { 8, "Neurology" },
                    { 9, "Oncology" },
                    { 10, "Pulmonology" }
                });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "DocId", "DocFirstName", "DocLastName", "SpecialityId", "email", "phone" },
                values: new object[,]
                {
                    { 1, "John", "Smith", 1, "john.smith@example.com", 1091095506 },
                    { 2, "Emily", "Johnson", 2, "emily.johnson@example.com", 1024657893 },
                    { 3, "Michael", "Williams", 3, "mic@gmail.com", 1025657893 },
                    { 4, "Jessica", "Brown", 4, "jessica.brown@example.com", 1098765432 },
                    { 5, "Daniel", "Davis", 5, "dan.davis@example.com", 1034567890 },
                    { 6, "Sophia", "Miller", 6, "sophia.miller@example.com", 1045678901 },
                    { 7, "James", "Wilson", 7, "james.wilson@example.com", 1056789012 },
                    { 8, "Olivia", "Moore", 8, "olivia.moore@example.com", 1067890123 },
                    { 9, "Liam", "Taylor", 9, "liam.taylor@example.com", 1078901234 },
                    { 10, "Ava", "Anderson", 10, "ava.anderson@example.com", 1089012345 },
                    { 11, "Ethan", "Thomas", 1, "ethan.thomas@example.com", 1090123456 },
                    { 12, "Isabella", "Jackson", 2, "isabella.jackson@example.com", 1091234567 },
                    { 13, "Mason", "White", 2, "mason.white@example.com", 1092345678 },
                    { 14, "Mia", "Harris", 4, "mia.harris@example.com", 1093456789 },
                    { 15, "Alexander", "Martin", 1, "alex.martin@example.com", 1094567890 },
                    { 16, "Charlotte", "Thompson", 6, "charlotte.thompson@example.com", 1095678901 },
                    { 17, "Henry", "Garcia", 6, "henry.garcia@example.com", 1096789012 },
                    { 18, "Amelia", "Martinez", 5, "amelia.martinez@example.com", 1097890123 },
                    { 19, "Benjamin", "Robinson", 2, "benjamin.robinson@example.com", 1098901234 },
                    { 20, "Harper", "Clark", 7, "harper.clark@example.com", 1099012345 }
                });

            migrationBuilder.InsertData(
                table: "patients",
                columns: new[] { "PatientId", "AppointmentId", "DocId", "IsDiagnosed", "PatientName", "phone" },
                values: new object[,]
                {
                    { 1, 0, 1, false, "John Doe", 1234567890 },
                    { 2, 0, 2, true, "Jane Smith", 345678901 },
                    { 3, 0, 3, false, "Robert Brown", 456789012 },
                    { 4, 0, 4, true, "Emily Davis", 567890123 },
                    { 5, 0, 5, false, "Michael Johnson", 678901234 },
                    { 6, 0, 6, true, "Jessica Wilson", 789012345 },
                    { 7, 0, 7, false, "David Martinez", 890123456 },
                    { 8, 0, 8, true, "Sarah Lee", 901234567 },
                    { 9, 0, 9, false, "Daniel Hernandez", 912345678 },
                    { 10, 0, 10, true, "Laura Clark", 1012345678 },
                    { 11, 0, 11, false, "Kevin Lewis", 1123456789 },
                    { 12, 0, 12, true, "Sophia Walker", 1234567891 },
                    { 13, 0, 13, false, "Christopher Moore", 1345678901 },
                    { 14, 0, 14, true, "Amanda White", 1456789012 },
                    { 15, 0, 15, false, "Matthew Harris", 1567890123 },
                    { 16, 0, 16, true, "Olivia Clark", 1678901234 },
                    { 17, 0, 17, false, "Joshua Lewis", 1789012345 },
                    { 18, 0, 18, true, "Abigail Young", 1890123456 },
                    { 19, 0, 19, false, "Brandon King", 1901234567 },
                    { 20, 0, 20, true, "Megan Hall", 1234567901 }
                });

            migrationBuilder.InsertData(
                table: "appointments",
                columns: new[] { "AppointmentId", "Date", "Description", "DocId", "IsConfirmed", "PatientId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 28, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9595), "Checkup", 1, true, 1 },
                    { 2, new DateTime(2024, 7, 29, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9659), "Follow-up", 2, false, 2 },
                    { 3, new DateTime(2024, 7, 30, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9663), "Consultation", 3, true, 3 },
                    { 4, new DateTime(2024, 7, 31, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9667), "Routine Check", 4, false, 4 },
                    { 5, new DateTime(2024, 8, 1, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9670), "Surgery", 5, true, 5 },
                    { 6, new DateTime(2024, 8, 2, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9673), "Vaccination", 6, false, 6 },
                    { 7, new DateTime(2024, 8, 3, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9676), "Dental Check", 7, true, 7 },
                    { 8, new DateTime(2024, 8, 4, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9680), "Eye Exam", 8, false, 8 },
                    { 9, new DateTime(2024, 8, 5, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9683), "Physical Therapy", 9, true, 9 },
                    { 10, new DateTime(2024, 8, 6, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9690), "Dermatology", 10, false, 10 },
                    { 11, new DateTime(2024, 8, 7, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9693), "Neurology", 11, true, 11 },
                    { 12, new DateTime(2024, 8, 8, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9696), "Orthopedics", 12, false, 12 },
                    { 13, new DateTime(2024, 8, 9, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9700), "Cardiology", 13, true, 13 },
                    { 14, new DateTime(2024, 8, 10, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9703), "ENT Check", 14, false, 14 },
                    { 15, new DateTime(2024, 8, 11, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9706), "Gastroenterology", 15, true, 15 },
                    { 16, new DateTime(2024, 8, 12, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9709), "Psychiatry", 16, false, 16 },
                    { 17, new DateTime(2024, 8, 13, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9712), "Urology", 17, true, 17 },
                    { 18, new DateTime(2024, 8, 14, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9715), "Gynecology", 18, false, 18 },
                    { 19, new DateTime(2024, 8, 15, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9718), "Pediatrics", 19, true, 19 },
                    { 20, new DateTime(2024, 8, 16, 13, 52, 9, 636, DateTimeKind.Local).AddTicks(9722), "Oncology", 20, false, 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_appointments_DocId",
                table: "appointments",
                column: "DocId");

            migrationBuilder.CreateIndex(
                name: "IX_appointments_PatientId",
                table: "appointments",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_doctors_SpecialityId",
                table: "doctors",
                column: "SpecialityId");

            migrationBuilder.CreateIndex(
                name: "IX_patients_DocId",
                table: "patients",
                column: "DocId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointments");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropTable(
                name: "Specialities");
        }
    }
}
