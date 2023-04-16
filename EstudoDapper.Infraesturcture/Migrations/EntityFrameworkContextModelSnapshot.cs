﻿// <auto-generated />
using System;
using EstudoDapper.Infraesturcture.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstudoDapper.Infraesturcture.Data.Migrations
{
    [DbContext(typeof(EntityFrameworkContext))]
    partial class EntityFrameworkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EstudoDapper.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<decimal>("Renda")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.Conjuge", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodCliente")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Conjuge");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.Imovel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Area")
                        .HasColumnType("decimal(8,2)");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Imovels");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.PessoaFisica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("PessoaFisicas");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.PessoaJuridica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Ramo")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("PessoaJuridicas");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.Conjuge", b =>
                {
                    b.HasOne("EstudoDapper.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Conjuge")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.Imovel", b =>
                {
                    b.HasOne("EstudoDapper.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Imovel")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.PessoaFisica", b =>
                {
                    b.HasOne("EstudoDapper.Domain.Entities.Cliente", "Cliente")
                        .WithMany("PessoaFisica")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.PessoaJuridica", b =>
                {
                    b.HasOne("EstudoDapper.Domain.Entities.Cliente", "Cliente")
                        .WithMany("PessoaJuridica")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("EstudoDapper.Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Conjuge");

                    b.Navigation("Imovel");

                    b.Navigation("PessoaFisica");

                    b.Navigation("PessoaJuridica");
                });
#pragma warning restore 612, 618
        }
    }
}
