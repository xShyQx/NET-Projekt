﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230629070402_ChangedInitialLectures")]
    partial class ChangedInitialLectures
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Halls", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sala W1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sala W2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sala W3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sala W4"
                        });
                });

            modelBuilder.Entity("DB.Models.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndHour")
                        .HasColumnType("time");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<string>("LecturerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<TimeSpan>("StartHour")
                        .HasColumnType("time");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("LecturerId");

                    b.ToTable("Lectures", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndHour = new TimeSpan(0, 9, 0, 0, 0),
                            HallId = 1,
                            LecturerId = "3",
                            StartHour = new TimeSpan(0, 8, 30, 0, 0),
                            Topic = "Teoria liczb i kryptografia"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndHour = new TimeSpan(0, 12, 0, 0, 0),
                            HallId = 3,
                            LecturerId = "3",
                            StartHour = new TimeSpan(0, 10, 0, 0, 0),
                            Topic = "Geometria fraktalna"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndHour = new TimeSpan(0, 10, 30, 0, 0),
                            HallId = 2,
                            LecturerId = "3",
                            StartHour = new TimeSpan(0, 9, 30, 0, 0),
                            Topic = "Teoria grafów i jej zastosowania"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndHour = new TimeSpan(0, 11, 0, 0, 0),
                            HallId = 4,
                            LecturerId = "3",
                            StartHour = new TimeSpan(0, 8, 30, 0, 0),
                            Topic = "Statystyka i analiza danych"
                        });
                });

            modelBuilder.Entity("DB.Models.LectureParticipant", b =>
                {
                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LectureId", "ParticipantId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("LecturesParticipants", (string)null);

                    b.HasData(
                        new
                        {
                            LectureId = 2,
                            ParticipantId = "2"
                        },
                        new
                        {
                            LectureId = 3,
                            ParticipantId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Wykładowca",
                            NormalizedName = "WYKŁADOWCA"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "3",
                            RoleId = "3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DB.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("User");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1d4784be-b310-4534-a52e-bc3a42ff7125",
                            Email = "admin@test.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TEST.PL",
                            NormalizedUserName = "ADMIN@TEST.PL",
                            PasswordHash = "AQAAAAIAAYagAAAAECWV6P8FDYB+PBB/MNgKkcQNunftcb4eRUELI3KfAwT9/mIRcB2+uUrxXmOObZJWUQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6fde2506-f3c9-402a-8101-2b774112b211",
                            TwoFactorEnabled = false,
                            UserName = "admin@test.pl",
                            FirstName = "Admin",
                            LastName = "Admin"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "be30e0ed-68c4-49a2-aae4-391854230f28",
                            Email = "student@test.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT@TEST.PL",
                            NormalizedUserName = "STUDENT@TEST.PL",
                            PasswordHash = "AQAAAAIAAYagAAAAEO0YSsGR4Lso8M25vLMTNqY5iMgZtHDW+Tnq+dYpdDZ8cJDfu9CUtJEfPpzXys0bDg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1c54ecec-caa2-4317-bdea-74663a7dfc0d",
                            TwoFactorEnabled = false,
                            UserName = "student@test.pl",
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "68133679-a40a-45c6-82a2-05d4e442f711",
                            Email = "lecturer@test.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "LECTURER@TEST.PL",
                            NormalizedUserName = "LECTURER@TEST.PL",
                            PasswordHash = "AQAAAAIAAYagAAAAENeeMeeXjCGT4HWDLV+fzNccREuuCKqwZE3r8oD9WsrOca6Q6wPKlr5TiChHlMeF1g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "899d4df2-2da4-4414-828b-39096a3db1ef",
                            TwoFactorEnabled = false,
                            UserName = "lecturer@test.pl",
                            FirstName = "Adam",
                            LastName = "Mickiewicz"
                        });
                });

            modelBuilder.Entity("DB.Models.Lecture", b =>
                {
                    b.HasOne("DB.Models.Hall", "Hall")
                        .WithMany("Lectures")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Models.User", "Lecturer")
                        .WithMany("AssignedLectures")
                        .HasForeignKey("LecturerId");

                    b.Navigation("Hall");

                    b.Navigation("Lecturer");
                });

            modelBuilder.Entity("DB.Models.LectureParticipant", b =>
                {
                    b.HasOne("DB.Models.Lecture", "Lecture")
                        .WithMany("LectureParticipants")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Models.User", "Participant")
                        .WithMany("LectureParticipants")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DB.Models.Hall", b =>
                {
                    b.Navigation("Lectures");
                });

            modelBuilder.Entity("DB.Models.Lecture", b =>
                {
                    b.Navigation("LectureParticipants");
                });

            modelBuilder.Entity("DB.Models.User", b =>
                {
                    b.Navigation("AssignedLectures");

                    b.Navigation("LectureParticipants");
                });
#pragma warning restore 612, 618
        }
    }
}
