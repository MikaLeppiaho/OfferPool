﻿// <auto-generated />
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
    [Migration("20211115201848_addContactName")]
    partial class addContactName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("offerpool_bl.Controllers.OfferData", b =>
                {
                    b.Property<int>("offer_list_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("offer_list_id"));

                    b.Property<string>("offer_contanct")
                        .HasColumnType("text");

                    b.Property<string>("offer_list_header")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("offer_list_id");

                    b.ToTable("OfferData");
                });
#pragma warning restore 612, 618
        }
    }
}
