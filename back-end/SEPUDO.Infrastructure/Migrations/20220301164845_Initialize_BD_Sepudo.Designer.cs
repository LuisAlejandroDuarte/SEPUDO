﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEPUDO.Infrastructure.Persistence;

#nullable disable

namespace SEPUDO.Infrastructure.Migrations
{
    [DbContext(typeof(SepudoDbContext))]
    [Migration("20220301164845_Initialize_BD_Sepudo")]
    partial class Initialize_BD_Sepudo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("back_end.Entidades.Suscriptor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<bool>("Alcantarillado")
                        .HasColumnType("bit");

                    b.Property<bool>("Aseo")
                        .HasColumnType("bit");

                    b.Property<int>("Atraso")
                        .HasColumnType("int");

                    b.Property<bool>("Bloqueo")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoVerificacion")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ManzanaDane")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManzanaEstratifica")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManzanaIgac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Sistema")
                        .HasColumnType("bigint");

                    b.Property<long>("UsoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UsoId");

                    b.ToTable("Suscriptores");
                });

            modelBuilder.Entity("back_end.Entidades.Uso", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estrato")
                        .HasColumnType("int");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Usos");
                });

            modelBuilder.Entity("back_end.Entidades.Suscriptor", b =>
                {
                    b.HasOne("back_end.Entidades.Uso", "Uso")
                        .WithMany("Suscriptores")
                        .HasForeignKey("UsoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uso");
                });

            modelBuilder.Entity("back_end.Entidades.Uso", b =>
                {
                    b.Navigation("Suscriptores");
                });
#pragma warning restore 612, 618
        }
    }
}
