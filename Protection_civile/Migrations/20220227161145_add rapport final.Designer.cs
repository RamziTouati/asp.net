﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Protection_civile.Data;

namespace Protection_civile.Migrations
{
    [DbContext(typeof(ProtectioncivileContext))]
    [Migration("20220227161145_add rapport final")]
    partial class addrapportfinal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Protection_civile.Models.Attestation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateN")
                        .HasColumnType("datetime2");

                    b.Property<int>("DemandeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DemandeId")
                        .IsUnique();

                    b.ToTable("Attestation");
                });

            modelBuilder.Entity("Protection_civile.Models.Demande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("activite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("adresse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("categorie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nomentreprise")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numcin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numdemande")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numrecu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tel")
                        .HasColumnType("int");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Demande");
                });

            modelBuilder.Entity("Protection_civile.Models.Paiement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateN")
                        .HasColumnType("datetime2");

                    b.Property<int>("DemandeId")
                        .HasColumnType("int");

                    b.Property<string>("numreçupaiement")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DemandeId")
                        .IsUnique();

                    b.ToTable("Paiement");
                });

            modelBuilder.Entity("Protection_civile.Models.RapportFinal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateN")
                        .HasColumnType("datetime2");

                    b.Property<int>("DemandeId")
                        .HasColumnType("int");

                    b.Property<int>("numrf")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DemandeId")
                        .IsUnique();

                    b.ToTable("RapportFinal");
                });

            modelBuilder.Entity("Protection_civile.Models.RapportInitial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateN")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datev")
                        .HasColumnType("datetime2");

                    b.Property<int>("DemandeId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numri")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DemandeId");

                    b.ToTable("RapportInitial");
                });

            modelBuilder.Entity("Protection_civile.Models.Attestation", b =>
                {
                    b.HasOne("Protection_civile.Models.Demande", "demande")
                        .WithOne("Attestation")
                        .HasForeignKey("Protection_civile.Models.Attestation", "DemandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Protection_civile.Models.Paiement", b =>
                {
                    b.HasOne("Protection_civile.Models.Demande", "demande")
                        .WithOne("Paiment")
                        .HasForeignKey("Protection_civile.Models.Paiement", "DemandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Protection_civile.Models.RapportFinal", b =>
                {
                    b.HasOne("Protection_civile.Models.Demande", "demande")
                        .WithOne("RapportFinal")
                        .HasForeignKey("Protection_civile.Models.RapportFinal", "DemandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Protection_civile.Models.RapportInitial", b =>
                {
                    b.HasOne("Protection_civile.Models.Demande", "demande")
                        .WithMany("RapportInitials")
                        .HasForeignKey("DemandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
