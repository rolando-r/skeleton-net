﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(DbEjContext))]
    partial class DbEjContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Dominio.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("Username", "Email")
                        .IsUnique()
                        .HasDatabaseName("IX_MiIndice");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("Dominio.UsuariosRoles", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "RolId");

                    b.HasIndex("RolId");

                    b.ToTable("UsuariosRoles");
                });

            modelBuilder.Entity("Dominio.UsuariosRoles", b =>
                {
                    b.HasOne("Dominio.Rol", "Rol")
                        .WithMany("UsuariosRoles")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Usuario", "Usuario")
                        .WithMany("UsuariosRoles")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Dominio.Rol", b =>
                {
                    b.Navigation("UsuariosRoles");
                });

            modelBuilder.Entity("Dominio.Usuario", b =>
                {
                    b.Navigation("UsuariosRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
