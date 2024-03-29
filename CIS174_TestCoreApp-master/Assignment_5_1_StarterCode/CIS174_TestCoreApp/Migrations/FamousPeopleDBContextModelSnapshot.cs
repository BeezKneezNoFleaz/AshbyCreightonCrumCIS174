﻿// <auto-generated />
using System;
using CIS174_TestCoreApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIS174_TestCoreApp.Migrations
{
    [DbContext(typeof(FamousPeopleDBContext))]
    partial class FamousPeopleDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CIS174_TestCoreApp.Entities.Accoplishment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfAccomplishment");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("Accoplishments");
                });

            modelBuilder.Entity("CIS174_TestCoreApp.Entities.FamousPeople", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccoplishmentId");

                    b.Property<int>("Age");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("DOB");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("ListOfAccoplishments")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.HasIndex("AccoplishmentId");

                    b.ToTable("FamousPeoples");
                });

            modelBuilder.Entity("CIS174_TestCoreApp.Entities.FamousPeople", b =>
                {
                    b.HasOne("CIS174_TestCoreApp.Entities.Accoplishment")
                        .WithMany("FamousPeoples")
                        .HasForeignKey("AccoplishmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
