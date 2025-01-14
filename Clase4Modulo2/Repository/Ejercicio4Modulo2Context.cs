﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Clase4Modulo2.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace Clase4Modulo2.Repository
{
    public partial class Ejercicio4Modulo2Context : DbContext
    {
        public Ejercicio4Modulo2Context()
        {
        }

        public Ejercicio4Modulo2Context(DbContextOptions<Ejercicio4Modulo2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Parametria> Parametria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
            base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parametria>(entity =>
            {
                entity.ToTable("parametria");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("key");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}