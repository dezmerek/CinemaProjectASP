﻿// <auto-generated />
using System;
using CinemaProjectASP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaProjectASP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220125160348_Zamowienia")]
    partial class Zamowienia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaProjectASP.Models.Aktor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biografia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImieNazwisko")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RokUrodzenia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Aktorzy");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Aktor_Film", b =>
                {
                    b.Property<int>("AktorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("AktorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("Aktorzy_Filmy");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<DateTime>("DoKiedy")
                        .HasColumnType("datetime2");

                    b.Property<int>("FilmKategoria")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OdKiedy")
                        .HasColumnType("datetime2");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RezyserId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RezyserId");

                    b.HasIndex("SalaId");

                    b.ToTable("Filmy");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Rezyser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biografia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImieNazwisko")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RokUrodzenia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rezyserzy");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Zamowienie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zamowienia");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.ZamowieniePrzedmiot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Ilosc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZamowienieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("ZamowienieId");

                    b.ToTable("zamowienionePrzedmioty");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Aktor_Film", b =>
                {
                    b.HasOne("CinemaProjectASP.Models.Aktor", "Aktor")
                        .WithMany("Aktorzy_Filmy")
                        .HasForeignKey("AktorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaProjectASP.Models.Film", "Film")
                        .WithMany("Aktorzy_Filmy")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aktor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Film", b =>
                {
                    b.HasOne("CinemaProjectASP.Models.Rezyser", "Rezyser")
                        .WithMany("Filmy")
                        .HasForeignKey("RezyserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaProjectASP.Models.Sala", "Sala")
                        .WithMany("Filmy")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rezyser");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.ZamowieniePrzedmiot", b =>
                {
                    b.HasOne("CinemaProjectASP.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CinemaProjectASP.Models.Zamowienie", "Zamowienie")
                        .WithMany("ZamowienionePrzedmioty")
                        .HasForeignKey("ZamowienieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Zamowienie");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Aktor", b =>
                {
                    b.Navigation("Aktorzy_Filmy");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Film", b =>
                {
                    b.Navigation("Aktorzy_Filmy");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Rezyser", b =>
                {
                    b.Navigation("Filmy");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Sala", b =>
                {
                    b.Navigation("Filmy");
                });

            modelBuilder.Entity("CinemaProjectASP.Models.Zamowienie", b =>
                {
                    b.Navigation("ZamowienionePrzedmioty");
                });
#pragma warning restore 612, 618
        }
    }
}
