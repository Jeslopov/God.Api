﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UruIt.God.Infraestructure.DbContexts;

namespace UruIt.God.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190623011956_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UruIt.God.Domain.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("matchid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Player1Id");

                    b.Property<int?>("Player2Id");

                    b.Property<int?>("WinnerId");

                    b.HasKey("Id");

                    b.HasIndex("Player1Id");

                    b.HasIndex("Player2Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("UruIt.God.Domain.Entities.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("roundid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MatchId");

                    b.Property<int?>("WinnerId");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("WinnerId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("UruIt.God.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("userid")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UruIt.God.Domain.Entities.Match", b =>
                {
                    b.HasOne("UruIt.God.Domain.Entities.User", "Player1")
                        .WithMany("Matches")
                        .HasForeignKey("Player1Id");

                    b.HasOne("UruIt.God.Domain.Entities.User", "Player2")
                        .WithMany()
                        .HasForeignKey("Player2Id");
                });

            modelBuilder.Entity("UruIt.God.Domain.Entities.Round", b =>
                {
                    b.HasOne("UruIt.God.Domain.Entities.Match", "Match")
                        .WithMany("Rounds")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UruIt.God.Domain.Entities.User", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
