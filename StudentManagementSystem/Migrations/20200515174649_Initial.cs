﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagementSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ClassTbls",
                columns: table => new
                {
                    ClassTblId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTbls", x => x.ClassTblId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeResumes",
                columns: table => new
                {
                    EmployeeResumeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Nationality = table.Column<string>(nullable: true),
                    EducationLevel = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    LinkedInProfile = table.Column<string>(nullable: true),
                    FacebookProfile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeResumes", x => x.EmployeeResumeId);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    ExpenseTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseTypes", x => x.ExpenseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    ReligionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.ReligionId);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.UserTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TotalMarks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subjects_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEducations",
                columns: table => new
                {
                    EmployeeEducationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeResumeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Institute = table.Column<string>(nullable: true),
                    University = table.Column<string>(nullable: true),
                    TitleOfDiploma = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    FromYear = table.Column<DateTime>(nullable: false),
                    ToYear = table.Column<DateTime>(nullable: false),
                    InstituteCity = table.Column<string>(nullable: true),
                    InstituteCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEducations", x => x.EmployeeEducationId);
                    table.ForeignKey(
                        name: "FK_EmployeeEducations_EmployeeResumes_EmployeeResumeId",
                        column: x => x.EmployeeResumeId,
                        principalTable: "EmployeeResumes",
                        principalColumn: "EmployeeResumeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTypeId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "UserTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassSubjects",
                columns: table => new
                {
                    ClassSubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassTblId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassSubjects", x => x.ClassSubjectId);
                    table.ForeignKey(
                        name: "FK_ClassSubjects_ClassTbls_ClassTblId",
                        column: x => x.ClassTblId,
                        principalTable: "ClassTbls",
                        principalColumn: "ClassTblId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    DesignationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.DesignationId);
                    table.ForeignKey(
                        name: "FK_Designations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCertifications",
                columns: table => new
                {
                    EmployeeCertificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(nullable: true),
                    CertificationAuthority = table.Column<string>(nullable: true),
                    LevelCertification = table.Column<string>(nullable: true),
                    FromYear = table.Column<DateTime>(nullable: false),
                    EmployeeResumeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCertifications", x => x.EmployeeCertificationId);
                    table.ForeignKey(
                        name: "FK_EmployeeCertifications_EmployeeResumes_EmployeeResumeId",
                        column: x => x.EmployeeResumeId,
                        principalTable: "EmployeeResumes",
                        principalColumn: "EmployeeResumeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeCertifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLanguages",
                columns: table => new
                {
                    EmployeeLanguageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(nullable: true),
                    Proficiency = table.Column<string>(nullable: true),
                    EmployeeResumeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLanguages", x => x.EmployeeLanguageId);
                    table.ForeignKey(
                        name: "FK_EmployeeLanguages_EmployeeResumes_EmployeeResumeId",
                        column: x => x.EmployeeResumeId,
                        principalTable: "EmployeeResumes",
                        principalColumn: "EmployeeResumeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLanguages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSkills",
                columns: table => new
                {
                    EmployeeSkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(nullable: true),
                    EmployeeResumeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSkills", x => x.EmployeeSkillId);
                    table.ForeignKey(
                        name: "FK_EmployeeSkills_EmployeeResumes_EmployeeResumeId",
                        column: x => x.EmployeeResumeId,
                        principalTable: "EmployeeResumes",
                        principalColumn: "EmployeeResumeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSkills_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeWorkExperiences",
                columns: table => new
                {
                    EmployeeWorkExperienceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    FromYear = table.Column<DateTime>(nullable: false),
                    ToYear = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EmployeeResumeId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeWorkExperiences", x => x.EmployeeWorkExperienceId);
                    table.ForeignKey(
                        name: "FK_EmployeeWorkExperiences_EmployeeResumes_EmployeeResumeId",
                        column: x => x.EmployeeResumeId,
                        principalTable: "EmployeeResumes",
                        principalColumn: "EmployeeResumeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeWorkExperiences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventTblId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTitle = table.Column<string>(nullable: true),
                    EventDate = table.Column<DateTime>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventTblId);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_Exams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseTypeId = table.Column<int>(nullable: false),
                    ExpensesDate = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Reason = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_Expenses_ExpenseTypes_ExpenseTypeId",
                        column: x => x.ExpenseTypeId,
                        principalTable: "ExpenseTypes",
                        principalColumn: "ExpenseTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expenses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programes",
                columns: table => new
                {
                    ProgrameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programes", x => x.ProgrameId);
                    table.ForeignKey(
                        name: "FK_Programes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionId);
                    table.ForeignKey(
                        name: "FK_Sections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    SessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_Sessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    DesignationId = table.Column<int>(nullable: false),
                    ContactNo = table.Column<string>(nullable: false),
                    BasicSalary = table.Column<double>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: false),
                    Qualification = table.Column<string>(nullable: false),
                    photo = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    HomePhone = table.Column<string>(nullable: false),
                    DoYouHaveAnyDisability = table.Column<bool>(nullable: false),
                    DisabilityDetails = table.Column<string>(nullable: true),
                    TakingAnyMedication = table.Column<bool>(nullable: false),
                    MedicationDetails = table.Column<string>(nullable: true),
                    AnyCriminalOffence = table.Column<bool>(nullable: false),
                    CriminalOffenceDetails = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    GenderId = table.Column<int>(nullable: true),
                    NationalityId = table.Column<int>(nullable: true),
                    ReligionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                    table.ForeignKey(
                        name: "FK_Staffs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "DesignationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "NationalityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religions",
                        principalColumn: "ReligionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staffs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Annuals",
                columns: table => new
                {
                    AnnualId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ProgrameId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Fees = table.Column<double>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annuals", x => x.AnnualId);
                    table.ForeignKey(
                        name: "FK_Annuals_Programes_ProgrameId",
                        column: x => x.ProgrameId,
                        principalTable: "Programes",
                        principalColumn: "ProgrameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Annuals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgrameSessions",
                columns: table => new
                {
                    ProgrameSessionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    SessionId = table.Column<int>(nullable: false),
                    ProgrameId = table.Column<int>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrameSessions", x => x.ProgrameSessionId);
                    table.ForeignKey(
                        name: "FK_ProgrameSessions_Programes_ProgrameId",
                        column: x => x.ProgrameId,
                        principalTable: "Programes",
                        principalColumn: "ProgrameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgrameSessions_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgrameSessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(nullable: false),
                    ProgrameId = table.Column<int>(nullable: false),
                    ClassTblId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    FatherName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    GenderId = table.Column<string>(nullable: false),
                    ContactNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    NationalityId = table.Column<int>(nullable: false),
                    ReligionId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    GuardianName = table.Column<string>(nullable: true),
                    GuardianOccupation = table.Column<string>(nullable: true),
                    GuardianPhone = table.Column<string>(nullable: true),
                    Cast = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    AadharNo = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    AdmissionDate = table.Column<DateTime>(nullable: false),
                    PreviousSchool = table.Column<string>(nullable: false),
                    PreviousPercentage = table.Column<float>(nullable: false),
                    GenderId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_ClassTbls_ClassTblId",
                        column: x => x.ClassTblId,
                        principalTable: "ClassTbls",
                        principalColumn: "ClassTblId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Genders_GenderId1",
                        column: x => x.GenderId1,
                        principalTable: "Genders",
                        principalColumn: "GenderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "NationalityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Programes_ProgrameId",
                        column: x => x.ProgrameId,
                        principalTable: "Programes",
                        principalColumn: "ProgrameId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religions",
                        principalColumn: "ReligionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaving",
                columns: table => new
                {
                    EmployeeLeavingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    LeavingDate = table.Column<DateTime>(nullable: false),
                    LeavingReason = table.Column<string>(nullable: true),
                    LeavingComments = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaving", x => x.EmployeeLeavingId);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaving_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaving_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalarys",
                columns: table => new
                {
                    EmployeeSalaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    SalaryMonth = table.Column<string>(nullable: true),
                    SalaryYear = table.Column<string>(nullable: true),
                    SalaryDate = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalarys", x => x.EmployeeSalaryId);
                    table.ForeignKey(
                        name: "FK_EmployeeSalarys_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSalarys_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffAttendances",
                columns: table => new
                {
                    StaffAttendanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(nullable: false),
                    AttendanceDate = table.Column<DateTime>(nullable: false),
                    ComingTime = table.Column<TimeSpan>(nullable: true),
                    ClosingTime = table.Column<TimeSpan>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffAttendances", x => x.StaffAttendanceId);
                    table.ForeignKey(
                        name: "FK_StaffAttendances_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeTables",
                columns: table => new
                {
                    TimeTableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    ClassSubjectId = table.Column<int>(nullable: false),
                    StartTime = table.Column<TimeSpan>(nullable: false),
                    EndTime = table.Column<TimeSpan>(nullable: false),
                    Day = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTables", x => x.TimeTableId);
                    table.ForeignKey(
                        name: "FK_TimeTables_ClassSubjects_ClassSubjectId",
                        column: x => x.ClassSubjectId,
                        principalTable: "ClassSubjects",
                        principalColumn: "ClassSubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeTables_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "StaffId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TimeTables_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(nullable: false),
                    ClassTblId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    AttendanceDate = table.Column<DateTime>(nullable: false),
                    AttendanceTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_Attendances_ClassTbls_ClassTblId",
                        column: x => x.ClassTblId,
                        principalTable: "ClassTbls",
                        principalColumn: "ClassTblId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "SessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExamMarks",
                columns: table => new
                {
                    ExamMarkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(nullable: false),
                    ClassSubjectId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    TotalMarks = table.Column<int>(nullable: false),
                    ObtainMarks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamMarks", x => x.ExamMarkId);
                    table.ForeignKey(
                        name: "FK_ExamMarks_ClassSubjects_ClassSubjectId",
                        column: x => x.ClassSubjectId,
                        principalTable: "ClassSubjects",
                        principalColumn: "ClassSubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExamMarks_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamMarks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamMarks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolLeavings",
                columns: table => new
                {
                    SchoolLeavingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    ClassTblId = table.Column<int>(nullable: false),
                    LeavingDate = table.Column<DateTime>(nullable: false),
                    LeavingReason = table.Column<string>(nullable: true),
                    LeavingComments = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolLeavings", x => x.SchoolLeavingId);
                    table.ForeignKey(
                        name: "FK_SchoolLeavings_ClassTbls_ClassTblId",
                        column: x => x.ClassTblId,
                        principalTable: "ClassTbls",
                        principalColumn: "ClassTblId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolLeavings_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolLeavings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentPromotes",
                columns: table => new
                {
                    StudentPromoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    ClassTblId = table.Column<int>(nullable: false),
                    ProgrameSessionId = table.Column<int>(nullable: false),
                    PromoteDate = table.Column<DateTime>(nullable: false),
                    AnnualFee = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsSubmit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPromotes", x => x.StudentPromoteId);
                    table.ForeignKey(
                        name: "FK_StudentPromotes_ClassTbls_ClassTblId",
                        column: x => x.ClassTblId,
                        principalTable: "ClassTbls",
                        principalColumn: "ClassTblId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPromotes_ProgrameSessions_ProgrameSessionId",
                        column: x => x.ProgrameSessionId,
                        principalTable: "ProgrameSessions",
                        principalColumn: "ProgrameSessionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPromotes_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "SectionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentPromotes_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubmissionFees",
                columns: table => new
                {
                    SubmissionFeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClassTblId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    ProgrameId = table.Column<int>(nullable: false),
                    SubmissionDate = table.Column<DateTime>(nullable: false),
                    FeeMonth = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmissionFees", x => x.SubmissionFeeId);
                    table.ForeignKey(
                        name: "FK_SubmissionFees_ClassTbls_ClassTblId",
                        column: x => x.ClassTblId,
                        principalTable: "ClassTbls",
                        principalColumn: "ClassTblId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubmissionFees_Programes_ProgrameId",
                        column: x => x.ProgrameId,
                        principalTable: "Programes",
                        principalColumn: "ProgrameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubmissionFees_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubmissionFees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryType" },
                values: new object[,]
                {
                    { 1, "General" },
                    { 3, "SC" },
                    { 4, "ST" },
                    { 2, "OBC" }
                });

            migrationBuilder.InsertData(
                table: "ClassTbls",
                columns: new[] { "ClassTblId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 10, true, "Eighth Standard" },
                    { 9, true, "Seventh Standard" },
                    { 8, true, "Sixth Standard" },
                    { 1, true, "LKG" },
                    { 6, true, "Fourth Standard" },
                    { 5, true, "Third Standard" },
                    { 4, true, "Second Standard" },
                    { 3, true, "First Standard" },
                    { 2, true, "UKG" },
                    { 7, true, "Fifth Standard" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "GenderId", "GenderType" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 3, "Transgender" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Nationalities",
                columns: new[] { "NationalityId", "NationalityType" },
                values: new object[,]
                {
                    { 2, "Others" },
                    { 1, "Indian" }
                });

            migrationBuilder.InsertData(
                table: "Religions",
                columns: new[] { "ReligionId", "ReligionType" },
                values: new object[,]
                {
                    { 5, "Jain" },
                    { 4, "Christian" },
                    { 3, "Sikh" },
                    { 2, "Muslim" },
                    { 1, "Hindu" },
                    { 7, "Other" },
                    { 6, "Buddhist" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "SubjectId", "ApplicationUserId", "Description", "Name", "RegDate", "TotalMarks" },
                values: new object[,]
                {
                    { 4, null, "", "Science", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 3, null, "", "Math", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 2, null, "", "English", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 1, null, "", "Hindi", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100 }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "UserTypeId", "Description", "TypeName" },
                values: new object[,]
                {
                    { 5, "Accountants can handle all the transactions details.", "Accountant" },
                    { 4, "Students can view their attendance.", "Student" },
                    { 3, "Teachers are allowed to handle Student and teacher information.", "Teacher" },
                    { 2, "Operators are allowed to handle all the modules with some restrictions.", "Operator" },
                    { 6, "Employee have low access than a teacher.", "Employee" },
                    { 1, "Admins are allowed to handle all the modules.", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "ClassSubjects",
                columns: new[] { "ClassSubjectId", "ClassTblId", "IsActive", "Name", "SubjectId" },
                values: new object[] { 1, 1, true, "Hindi-LKG", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "ContactNo", "Email", "FullName", "Password", "UserName", "UserTypeId" },
                values: new object[] { 1, "New Delhi", "8652544148", "admin@gmail.com", "Admin", "password", "admin@gmail.com", 1 });

            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "DesignationId", "IsActive", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, true, "Principal", 1 },
                    { 2, true, "Voice Principal", 1 },
                    { 3, true, "Teacher", 1 },
                    { 4, true, "Security Guard", 1 },
                    { 5, true, "Cleaner", 1 }
                });

            migrationBuilder.InsertData(
                table: "Programes",
                columns: new[] { "ProgrameId", "IsActive", "Name", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 1, true, "Arts", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, true, "Commerce", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, true, "Science", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, true, "Computer Science", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "SectionId", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "A", 1 },
                    { 2, "B", 1 },
                    { 3, "C", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "SessionId", "EndDate", "Name", "StartDate", "UserId" },
                values: new object[] { 1, new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "2020-2021", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Annuals",
                columns: new[] { "AnnualId", "Description", "Fees", "IsActive", "ProgrameId", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Annual Fee Same", 1000.0, true, 1, "For LKG To Fifth Standard", 1 },
                    { 2, "Annual Fee Same", 1500.0, true, 1, "For LKG To Fifth Standard", 1 },
                    { 3, "Annual Fee Same", 1800.0, true, 3, "For LKG To Fifth Standard", 1 },
                    { 4, "Annual Fee Same", 2000.0, true, 4, "For LKG To Fifth Standard", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProgrameSessions",
                columns: new[] { "ProgrameSessionId", "Description", "Details", "ProgrameId", "RegDate", "SessionId", "UserId" },
                values: new object[] { 1, "Annual Fee Same", "(2020-2021-Arts)LGK to 5th", 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Annuals_ProgrameId",
                table: "Annuals",
                column: "ProgrameId");

            migrationBuilder.CreateIndex(
                name: "IX_Annuals_UserId",
                table: "Annuals",
                column: "UserId");

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
                name: "IX_Attendances_ClassTblId",
                table: "Attendances",
                column: "ClassTblId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_SessionId",
                table: "Attendances",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_ClassTblId",
                table: "ClassSubjects",
                column: "ClassTblId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjects_SubjectId",
                table: "ClassSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Designations_UserId",
                table: "Designations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCertifications_EmployeeResumeId",
                table: "EmployeeCertifications",
                column: "EmployeeResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCertifications_UserId",
                table: "EmployeeCertifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducations_EmployeeResumeId",
                table: "EmployeeEducations",
                column: "EmployeeResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLanguages_EmployeeResumeId",
                table: "EmployeeLanguages",
                column: "EmployeeResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLanguages_UserId",
                table: "EmployeeLanguages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaving_StaffId",
                table: "EmployeeLeaving",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaving_UserId",
                table: "EmployeeLeaving",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalarys_StaffId",
                table: "EmployeeSalarys",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSalarys_UserId",
                table: "EmployeeSalarys",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkills_EmployeeResumeId",
                table: "EmployeeSkills",
                column: "EmployeeResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkills_UserId",
                table: "EmployeeSkills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWorkExperiences_EmployeeResumeId",
                table: "EmployeeWorkExperiences",
                column: "EmployeeResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWorkExperiences_UserId",
                table: "EmployeeWorkExperiences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_ClassSubjectId",
                table: "ExamMarks",
                column: "ClassSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_ExamId",
                table: "ExamMarks",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_StudentId",
                table: "ExamMarks",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamMarks_UserId",
                table: "ExamMarks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserId",
                table: "Exams",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_ExpenseTypeId",
                table: "Expenses",
                column: "ExpenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Programes_UserId",
                table: "Programes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrameSessions_ProgrameId",
                table: "ProgrameSessions",
                column: "ProgrameId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrameSessions_SessionId",
                table: "ProgrameSessions",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgrameSessions_UserId",
                table: "ProgrameSessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolLeavings_ClassTblId",
                table: "SchoolLeavings",
                column: "ClassTblId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolLeavings_StudentId",
                table: "SchoolLeavings",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolLeavings_UserId",
                table: "SchoolLeavings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_UserId",
                table: "Sections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffAttendances_StaffId",
                table: "StaffAttendances",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_CategoryId",
                table: "Staffs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_DesignationId",
                table: "Staffs",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_Email",
                table: "Staffs",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_GenderId",
                table: "Staffs",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_NationalityId",
                table: "Staffs",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_ReligionId",
                table: "Staffs",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_UserId",
                table: "Staffs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPromotes_ClassTblId",
                table: "StudentPromotes",
                column: "ClassTblId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPromotes_ProgrameSessionId",
                table: "StudentPromotes",
                column: "ProgrameSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPromotes_SectionId",
                table: "StudentPromotes",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPromotes_StudentId",
                table: "StudentPromotes",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CategoryId",
                table: "Students",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassTblId",
                table: "Students",
                column: "ClassTblId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderId1",
                table: "Students",
                column: "GenderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_NationalityId",
                table: "Students",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProgrameId",
                table: "Students",
                column: "ProgrameId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ReligionId",
                table: "Students",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SessionId",
                table: "Students",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_ApplicationUserId",
                table: "Subjects",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Name",
                table: "Subjects",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SubmissionFees_ClassTblId",
                table: "SubmissionFees",
                column: "ClassTblId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmissionFees_ProgrameId",
                table: "SubmissionFees",
                column: "ProgrameId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmissionFees_StudentId",
                table: "SubmissionFees",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_SubmissionFees_UserId",
                table: "SubmissionFees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeTables_ClassSubjectId",
                table: "TimeTables",
                column: "ClassSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeTables_StaffId",
                table: "TimeTables",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeTables_UserId",
                table: "TimeTables",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                column: "UserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserTypes_TypeName",
                table: "UserTypes",
                column: "TypeName",
                unique: true,
                filter: "[TypeName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annuals");

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
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "EmployeeCertifications");

            migrationBuilder.DropTable(
                name: "EmployeeEducations");

            migrationBuilder.DropTable(
                name: "EmployeeLanguages");

            migrationBuilder.DropTable(
                name: "EmployeeLeaving");

            migrationBuilder.DropTable(
                name: "EmployeeSalarys");

            migrationBuilder.DropTable(
                name: "EmployeeSkills");

            migrationBuilder.DropTable(
                name: "EmployeeWorkExperiences");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "ExamMarks");

            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "SchoolLeavings");

            migrationBuilder.DropTable(
                name: "StaffAttendances");

            migrationBuilder.DropTable(
                name: "StudentPromotes");

            migrationBuilder.DropTable(
                name: "SubmissionFees");

            migrationBuilder.DropTable(
                name: "TimeTables");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EmployeeResumes");

            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "ExpenseTypes");

            migrationBuilder.DropTable(
                name: "ProgrameSessions");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ClassSubjects");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Programes");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "ClassTbls");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
