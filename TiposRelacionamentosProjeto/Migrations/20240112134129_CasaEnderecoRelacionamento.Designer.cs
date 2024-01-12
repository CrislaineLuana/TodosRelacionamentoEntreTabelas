﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiposRelacionamentosProjeto.Data;

#nullable disable

namespace TiposRelacionamentosProjeto.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240112134129_CasaEnderecoRelacionamento")]
    partial class CasaEnderecoRelacionamento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TiposRelacionamentosProjeto.Models.CasaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Casas");
                });

            modelBuilder.Entity("TiposRelacionamentosProjeto.Models.EnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CasaId")
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CasaId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("TiposRelacionamentosProjeto.Models.EnderecoModel", b =>
                {
                    b.HasOne("TiposRelacionamentosProjeto.Models.CasaModel", "Casa")
                        .WithOne("Endereco")
                        .HasForeignKey("TiposRelacionamentosProjeto.Models.EnderecoModel", "CasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Casa");
                });

            modelBuilder.Entity("TiposRelacionamentosProjeto.Models.CasaModel", b =>
                {
                    b.Navigation("Endereco")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
