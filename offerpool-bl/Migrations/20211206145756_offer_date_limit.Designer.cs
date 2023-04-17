﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using offerpool_bl.Data;

#nullable disable

namespace offerpool_bl.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211206145756_offer_date_limit")]
    partial class offer_date_limit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("offerpool_bl.Models.Offer", b =>
                {
                    b.Property<int>("offer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("offer_id"));

                    b.Property<string>("offer_contact")
                        .HasColumnType("text");

                    b.Property<DateTime>("offer_date_limit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("offer_header")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("offer_id");

                    b.ToTable("Offer");
                });
#pragma warning restore 612, 618
        }
    }
}