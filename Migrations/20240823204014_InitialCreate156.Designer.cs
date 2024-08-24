﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace revision1.Migrations
{
    [DbContext(typeof(Datacontext))]
    [Migration("20240823204014_InitialCreate156")]
    partial class InitialCreate156
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Products", b =>
                {
                    b.Property<int>("p_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("p_id"), 1L, 1);

                    b.Property<string>("p_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("p_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("p_total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("p_id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
