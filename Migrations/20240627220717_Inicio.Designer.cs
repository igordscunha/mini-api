﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniApi.Data;

#nullable disable

namespace MiniApi.Migrations
{
    [DbContext(typeof(_DbContext))]
    [Migration("20240627220717_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("MiniApi.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Ataque")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defesa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("Vida")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Jogadores");
                });
#pragma warning restore 612, 618
        }
    }
}