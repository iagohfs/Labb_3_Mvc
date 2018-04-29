﻿// <auto-generated />
using Labb_3_Mvc.Cinema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Labb_3_Mvc.Migrations
{
    [DbContext(typeof(BerraContext))]
    [Migration("20180429142649_expanding-access")]
    partial class expandingaccess
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.BookingTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BookingDate");

                    b.Property<int?>("ClientInfoId");

                    b.Property<int?>("MovieInfoId");

                    b.Property<int?>("RoomInfoId");

                    b.HasKey("Id");

                    b.HasIndex("ClientInfoId");

                    b.HasIndex("MovieInfoId");

                    b.HasIndex("RoomInfoId");

                    b.ToTable("BookingTickets");
                });

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasMaxLength(32);

                    b.Property<int?>("MovieId");

                    b.Property<int?>("RoomId");

                    b.Property<int>("TelephoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("RoomId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.Conjunction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientId");

                    b.Property<int?>("MovieId");

                    b.Property<DateTime>("MovieTime");

                    b.Property<int?>("RoomId");

                    b.Property<int?>("TicketId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("MovieId");

                    b.HasIndex("RoomId");

                    b.HasIndex("TicketId");

                    b.ToTable("Conjunction");
                });

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgeRange");

                    b.Property<string>("Genre")
                        .HasColumnName("Genre")
                        .HasMaxLength(32);

                    b.Property<string>("Imgurl")
                        .HasColumnName("ImgUrl")
                        .HasMaxLength(32);

                    b.Property<int?>("RoomId");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Seats");

                    b.Property<string>("Status")
                        .HasColumnName("Status")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.BookingTicket", b =>
                {
                    b.HasOne("Labb_3_Mvc.Cinema.Models.Client", "ClientInfo")
                        .WithMany("BookingTicket")
                        .HasForeignKey("ClientInfoId");

                    b.HasOne("Labb_3_Mvc.Cinema.Models.Movie", "MovieInfo")
                        .WithMany()
                        .HasForeignKey("MovieInfoId");

                    b.HasOne("Labb_3_Mvc.Cinema.Models.Room", "RoomInfo")
                        .WithMany()
                        .HasForeignKey("RoomInfoId");
                });

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.Client", b =>
                {
                    b.HasOne("Labb_3_Mvc.Cinema.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");

                    b.HasOne("Labb_3_Mvc.Cinema.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.Conjunction", b =>
                {
                    b.HasOne("Labb_3_Mvc.Cinema.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Labb_3_Mvc.Cinema.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");

                    b.HasOne("Labb_3_Mvc.Cinema.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("Labb_3_Mvc.Cinema.Models.BookingTicket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("Labb_3_Mvc.Cinema.Models.Movie", b =>
                {
                    b.HasOne("Labb_3_Mvc.Cinema.Models.Room")
                        .WithMany("Movies")
                        .HasForeignKey("RoomId");
                });
#pragma warning restore 612, 618
        }
    }
}
