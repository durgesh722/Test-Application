﻿// <auto-generated />
using System;
using QBS_CORE_WEBAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace QBS_CORE_WEBAPI.Migrations
{
    [DbContext(typeof(QbsContext))]
    [Migration("20200117111128_QBSService")]
    partial class QBSService
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QBS_CORE_WEBAPI.Models.ApplicationUsers", b =>
                {
                    b.Property<string>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .HasMaxLength(50);

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mobile")
                        .HasMaxLength(10);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("LoginId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("QBS_CORE_WEBAPI.Models.tbl_user_m", b =>
                {
                    b.Property<string>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateOfBirth")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasMaxLength(10);

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("Mobile")
                        .HasMaxLength(10);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PinCode");

                    b.HasKey("LoginId");

                    b.ToTable("tbl_user_m");
                });
#pragma warning restore 612, 618
        }
    }
}
