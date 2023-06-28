﻿// <auto-generated />
using System;
using EasyCup.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyCup.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EasyCup.Domain.Championship", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime?>("CancelledChampionship")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndChampionship")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndRegistration")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FirstPlaceID")
                        .HasColumnType("int");

                    b.Property<int>("FootballSchoolUnitID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SecondPlaceID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartChampionship")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartPublicity")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartRegistration")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ThirdPlaceID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("FirstPlaceID");

                    b.HasIndex("FootballSchoolUnitID");

                    b.HasIndex("SecondPlaceID");

                    b.HasIndex("ThirdPlaceID");

                    b.ToTable("Championships");
                });

            modelBuilder.Entity("EasyCup.Domain.ChampionshipTeamPlayer", b =>
                {
                    b.Property<int>("PlayerID")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("ChampionshipID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PlayerID");

                    b.HasIndex("ChampionshipID");

                    b.HasIndex("TeamID");

                    b.ToTable("ChampionshipsTeamsPlayers");
                });

            modelBuilder.Entity("EasyCup.Domain.CupManager", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FootballSchoolUnitID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("FootballSchoolUnitID");

                    b.ToTable("CupManagers");
                });

            modelBuilder.Entity("EasyCup.Domain.FootballSchool", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("FootballSchools");
                });

            modelBuilder.Entity("EasyCup.Domain.FootballSchoolUnit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CupManagerID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FootballSchoolID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CupManagerID");

                    b.HasIndex("FootballSchoolID");

                    b.ToTable("FootballSchoolUnits");
                });

            modelBuilder.Entity("EasyCup.Domain.FutsalCourt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FootballSchoolUnitID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("FootballSchoolUnitID");

                    b.ToTable("FutsalCourts");
                });

            modelBuilder.Entity("EasyCup.Domain.Match", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ChampionshipID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamAID")
                        .HasColumnType("int");

                    b.Property<int>("TeamAResult")
                        .HasColumnType("int");

                    b.Property<int>("TeamBID")
                        .HasColumnType("int");

                    b.Property<int>("TeamBResult")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ChampionshipID");

                    b.HasIndex("TeamAID");

                    b.HasIndex("TeamBID");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("EasyCup.Domain.Player", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WhatsApp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("EasyCup.Domain.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EasyCup.Domain.Championship", b =>
                {
                    b.HasOne("EasyCup.Domain.Team", "FirstPlace")
                        .WithMany()
                        .HasForeignKey("FirstPlaceID");

                    b.HasOne("EasyCup.Domain.FootballSchoolUnit", "FootballSchoolUnit")
                        .WithMany()
                        .HasForeignKey("FootballSchoolUnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyCup.Domain.Team", "SecondPlace")
                        .WithMany()
                        .HasForeignKey("SecondPlaceID");

                    b.HasOne("EasyCup.Domain.Team", "ThirdPlace")
                        .WithMany()
                        .HasForeignKey("ThirdPlaceID");

                    b.Navigation("FirstPlace");

                    b.Navigation("FootballSchoolUnit");

                    b.Navigation("SecondPlace");

                    b.Navigation("ThirdPlace");
                });

            modelBuilder.Entity("EasyCup.Domain.ChampionshipTeamPlayer", b =>
                {
                    b.HasOne("EasyCup.Domain.Championship", "Championship")
                        .WithMany("ChampionshipTeamPlayer")
                        .HasForeignKey("ChampionshipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyCup.Domain.Player", "Player")
                        .WithMany("ChampionshipTeamPlayer")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyCup.Domain.Team", "Team")
                        .WithMany("ChampionshipTeamPlayer")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Championship");

                    b.Navigation("Player");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("EasyCup.Domain.CupManager", b =>
                {
                    b.HasOne("EasyCup.Domain.FootballSchoolUnit", "FootballSchoolUnit")
                        .WithMany()
                        .HasForeignKey("FootballSchoolUnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FootballSchoolUnit");
                });

            modelBuilder.Entity("EasyCup.Domain.FootballSchoolUnit", b =>
                {
                    b.HasOne("EasyCup.Domain.CupManager", "CupManager")
                        .WithMany()
                        .HasForeignKey("CupManagerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyCup.Domain.FootballSchool", "FootballSchool")
                        .WithMany("FootballSchoolUnits")
                        .HasForeignKey("FootballSchoolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CupManager");

                    b.Navigation("FootballSchool");
                });

            modelBuilder.Entity("EasyCup.Domain.FutsalCourt", b =>
                {
                    b.HasOne("EasyCup.Domain.FootballSchoolUnit", "FootballSchoolUnit")
                        .WithMany()
                        .HasForeignKey("FootballSchoolUnitID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FootballSchoolUnit");
                });

            modelBuilder.Entity("EasyCup.Domain.Match", b =>
                {
                    b.HasOne("EasyCup.Domain.Championship", "Championship")
                        .WithMany()
                        .HasForeignKey("ChampionshipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyCup.Domain.Team", "TeamA")
                        .WithMany()
                        .HasForeignKey("TeamAID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyCup.Domain.Team", "TeamB")
                        .WithMany()
                        .HasForeignKey("TeamBID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Championship");

                    b.Navigation("TeamA");

                    b.Navigation("TeamB");
                });

            modelBuilder.Entity("EasyCup.Domain.Championship", b =>
                {
                    b.Navigation("ChampionshipTeamPlayer");
                });

            modelBuilder.Entity("EasyCup.Domain.FootballSchool", b =>
                {
                    b.Navigation("FootballSchoolUnits");
                });

            modelBuilder.Entity("EasyCup.Domain.Player", b =>
                {
                    b.Navigation("ChampionshipTeamPlayer");
                });

            modelBuilder.Entity("EasyCup.Domain.Team", b =>
                {
                    b.Navigation("ChampionshipTeamPlayer");
                });
#pragma warning restore 612, 618
        }
    }
}
