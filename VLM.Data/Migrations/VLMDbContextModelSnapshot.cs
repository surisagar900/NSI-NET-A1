﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VLM.Data;

namespace VLM.Data.Migrations
{
    [DbContext(typeof(VLMDbContext))]
    partial class VLMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VLM.Data.Entities.Movies", b =>
                {
                    b.Property<int>("MoviesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Fine")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<int>("ReturnDays")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("MoviesId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MoviesId = 1,
                            Description = "When an unexpected enemy emerges that threatens the fate of mankind, Nick Fury, Director of S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins.",
                            Director = "Josan",
                            Fine = 400,
                            Genre = "Thriller",
                            Language = "English",
                            ReleaseYear = 2012,
                            ReturnDays = 20,
                            Title = "Avengers"
                        },
                        new
                        {
                            MoviesId = 2,
                            Description = "Tony Stark builds an artificial intelligence system named Ultron with the help of Bruce Banner. And when things go wrong, it's up to Earth's mightiest heroes to stop the villainous Ultron from enacting his terrible plan.",
                            Director = "Josan",
                            Fine = 700,
                            Genre = "Thriller",
                            Language = "English",
                            ReleaseYear = 2012,
                            ReturnDays = 25,
                            Title = "Avengers: Age Of Ultron"
                        },
                        new
                        {
                            MoviesId = 3,
                            Description = "With the powerful Thanos on the verge of raining destruction upon the universe, the Avengers and their Superhero allies risk everything in the ultimate showdown of all time.",
                            Director = "Marvels",
                            Fine = 800,
                            Genre = "Action",
                            Language = "Hindi",
                            ReleaseYear = 2018,
                            ReturnDays = 20,
                            Title = "Avengers: Infinity War"
                        });
                });

            modelBuilder.Entity("VLM.Data.Entities.Records", b =>
                {
                    b.Property<int>("RecordsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TakenDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("RecordsId");

                    b.HasIndex("MoviesId");

                    b.HasIndex("UserName");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            RecordsId = 1,
                            MoviesId = 1,
                            ReturnDate = new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TakenDate = new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "surisagar900"
                        },
                        new
                        {
                            RecordsId = 2,
                            MoviesId = 3,
                            ReturnDate = new DateTime(2020, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TakenDate = new DateTime(2020, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserName = "Surisagar900"
                        });
                });

            modelBuilder.Entity("VLM.Data.Entities.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.HasKey("UserName");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserName = "surisagar900",
                            DOB = new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "s@gmail.com",
                            FirstName = "sagar",
                            LastName = "suri",
                            Password = "Sagarsuri",
                            Phone = 9876543210L
                        });
                });

            modelBuilder.Entity("VLM.Data.Entities.Records", b =>
                {
                    b.HasOne("VLM.Data.Entities.Movies", "Movies")
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VLM.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
