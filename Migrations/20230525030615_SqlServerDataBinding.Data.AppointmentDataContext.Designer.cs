﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SqlServerDataBinding.Data;

#nullable disable

namespace SqlServerDataBinding.Migrations
{
    [DbContext(typeof(AppointmentDataContext))]
    [Migration("20230525030615_SqlServerDataBinding.Data.AppointmentDataContext")]
    partial class SqlServerDataBindingDataAppointmentDataContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SqlServerDataBinding.Data.AppointmentData", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordID"), 1L, 1);

                    b.Property<string>("CategoryColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CssClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsAllDay")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsBlock")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsReadOnly")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecurrenceException")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecurrenceID")
                        .HasColumnType("int");

                    b.Property<string>("RecurrenceRule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartTimezone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecordID");

                    b.ToTable("AppointmentDatas");

                    b.HasData(
                        new
                        {
                            RecordID = 1,
                            EndTime = new DateTime(2023, 5, 25, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Id = 1,
                            IsAllDay = false,
                            Location = "Tamilnadu",
                            StartTime = new DateTime(2023, 5, 25, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "Meeting"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
