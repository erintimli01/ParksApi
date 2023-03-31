﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParksApi.Models;

#nullable disable

namespace ParksApi.Migrations
{
    [DbContext(typeof(ParksApiContext))]
    [Migration("20230331170203_AddDummyData")]
    partial class AddDummyData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParksApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            City = "Springdale",
                            Name = "Zion National Park",
                            State = "Utah"
                        },
                        new
                        {
                            ParkId = 2,
                            City = "Sacramento",
                            Name = "Yosemite National Park",
                            State = "California"
                        },
                        new
                        {
                            ParkId = 3,
                            City = "Tusayan",
                            Name = "Grand Canyon National Park",
                            State = "Arizona"
                        },
                        new
                        {
                            ParkId = 4,
                            City = "Big Bend",
                            Name = "Big Bend National Park",
                            State = "Texas"
                        },
                        new
                        {
                            ParkId = 5,
                            City = "Gardiner",
                            Name = "Yellowstone National Park",
                            State = "Montana"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
