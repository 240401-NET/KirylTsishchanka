using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Project1Syllabus;

public partial class KtProject1netContext : DbContext
{
    public KtProject1netContext()
    {
    }

    public KtProject1netContext(DbContextOptions<KtProject1netContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DbStudent> DbStudents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DbStudent>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Attendance)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("attendance");
            entity.Property(e => e.FinalExam)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("finalExam");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("firstName");
            entity.Property(e => e.IdNumber).HasColumnName("idNumber");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("lastName");
            entity.Property(e => e.LetterGrade)
                .HasMaxLength(2)
                .HasColumnName("letterGrade");
            entity.Property(e => e.Midterm1)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("midterm1");
            entity.Property(e => e.Midterm2)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("midterm2");
            entity.Property(e => e.Quiz)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("quiz");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("total");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
