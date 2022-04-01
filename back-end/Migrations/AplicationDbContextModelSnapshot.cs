﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_end;

namespace back_end.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("back_end.Entidades.Consumo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Consumo1")
                        .HasColumnType("bigint");

                    b.Property<long>("Consumo2")
                        .HasColumnType("bigint");

                    b.Property<long>("Consumo3")
                        .HasColumnType("bigint");

                    b.Property<long>("Consumo4")
                        .HasColumnType("bigint");

                    b.Property<long>("Consumo5")
                        .HasColumnType("bigint");

                    b.Property<long>("Consumo6")
                        .HasColumnType("bigint");

                    b.Property<long>("ConsumoActual")
                        .HasColumnType("bigint");

                    b.Property<long>("SuscriptorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SuscriptorId");

                    b.ToTable("Consumo");
                });

            modelBuilder.Entity("back_end.Entidades.Lectura", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaLectura")
                        .HasColumnType("datetime2");

                    b.Property<long>("Lectura1")
                        .HasColumnType("bigint");

                    b.Property<long>("Lectura2")
                        .HasColumnType("bigint");

                    b.Property<long>("Lectura3")
                        .HasColumnType("bigint");

                    b.Property<long>("Lectura4")
                        .HasColumnType("bigint");

                    b.Property<long>("Lectura5")
                        .HasColumnType("bigint");

                    b.Property<long>("Lectura6")
                        .HasColumnType("bigint");

                    b.Property<long>("LecturaActual")
                        .HasColumnType("bigint");

                    b.Property<long>("LecturaAnterior")
                        .HasColumnType("bigint");

                    b.Property<long>("LecturaTemporal")
                        .HasColumnType("bigint");

                    b.Property<long>("OperarioId")
                        .HasColumnType("bigint");

                    b.Property<long>("SuscriptorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OperarioId");

                    b.HasIndex("SuscriptorId");

                    b.ToTable("Lectura");
                });

            modelBuilder.Entity("back_end.Entidades.Suscriptor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("Suscriptor");
                });

            modelBuilder.Entity("back_end.Entidades.Tarifa", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CostoReferenciaCargoFijoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("CostoReferenciaCargoFijoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("CostoReferenciaConsumoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("CostoReferenciaConsumoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("IncrementoAseo")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("IncrementoCargoFijoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("IncrementoCargoFijoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("IncrementoConsumoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("IncrementoConsumoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("InteresMora")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("OtroSubsidio")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("OtroValor")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("PorcentajeContribucionAseo")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("PorcentajeContribucionCargofijoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("PorcentajeContribucionCargofijoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("PorcentajeContribucionConsumoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("PorcentajeContribucionConsumoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("PorcentajeFinanaciacion")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("SubsidioAseo")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("SubsidioBasicoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("SubsidioBasicoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("SubsidioCargoFijoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("SubsidioCargoFijoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<long>("UsoId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ValorBarridoAseo")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorBasicoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorBasicoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorCargoFijoAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorCargoFijoAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorComplementarioAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorComplementarioAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorDisposicionAseo")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorRecaudoAseo")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorRecoleccionAseo")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorSuntuarioAcueducto")
                        .HasColumnType("decimal(10,3)");

                    b.Property<decimal>("ValorSuntuarioAlcantarillado")
                        .HasColumnType("decimal(10,3)");

                    b.HasKey("Id");

                    b.HasIndex("UsoId");

                    b.ToTable("Tarifa");
                });

            modelBuilder.Entity("back_end.Entidades.Uso", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estrato")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Uso");
                });

            modelBuilder.Entity("back_end.Entidades.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("back_end.Entidades.Consumo", b =>
                {
                    b.HasOne("back_end.Entidades.Suscriptor", "Suscriptor")
                        .WithMany()
                        .HasForeignKey("SuscriptorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Suscriptor");
                });

            modelBuilder.Entity("back_end.Entidades.Lectura", b =>
                {
                    b.HasOne("back_end.Entidades.Usuario", "Operario")
                        .WithMany()
                        .HasForeignKey("OperarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("back_end.Entidades.Suscriptor", "Suscriptor")
                        .WithMany()
                        .HasForeignKey("SuscriptorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Operario");

                    b.Navigation("Suscriptor");
                });

            modelBuilder.Entity("back_end.Entidades.Suscriptor", b =>
                {
                    b.HasOne("back_end.Entidades.Uso", "Uso")
                        .WithMany()
                        .HasForeignKey("UsoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uso");
                });

            modelBuilder.Entity("back_end.Entidades.Tarifa", b =>
                {
                    b.HasOne("back_end.Entidades.Uso", "Uso")
                        .WithMany()
                        .HasForeignKey("UsoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uso");
                });
#pragma warning restore 612, 618
        }
    }
}
