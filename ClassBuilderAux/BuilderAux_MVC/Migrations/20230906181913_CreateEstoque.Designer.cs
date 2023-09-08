﻿// <auto-generated />
using BuilderAux_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BuilderAux_MVC.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20230906181913_CreateEstoque")]
    partial class CreateEstoque
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BuilderAux_MVC.Models.Itens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("MaoDeObra")
                        .HasColumnType("float");

                    b.Property<double>("Quantidade")
                        .HasColumnType("float");

                    b.Property<int>("TipoServico")
                        .HasColumnType("int");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ValorPorUnidade")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("TipoServico");

                    b.ToTable("Itens");
                });

            modelBuilder.Entity("BuilderAux_MVC.Models.NomesServicos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeServico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("BuilderAux_MVC.Models.Itens", b =>
                {
                    b.HasOne("BuilderAux_MVC.Models.NomesServicos", "TipoServicoNavigation")
                        .WithMany()
                        .HasForeignKey("TipoServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoServicoNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
