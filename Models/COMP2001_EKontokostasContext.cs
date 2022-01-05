using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Coursework2Comp2001.Models
{
    public partial class COMP2001_EKontokostasContext : DbContext
    {
        public COMP2001_EKontokostasContext()
        {
        }

        public COMP2001_EKontokostasContext(DbContextOptions<COMP2001_EKontokostasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Programme> Programmes { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=socem1.uopnet.plymouth.ac.uk;Database=COMP2001_EKontokostas; User Id=EKontokostas; Password=BtyR432* ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Programme>(entity =>
            {
                entity.HasKey(e => e.ProgrammeCode)
                    .HasName("PK__Programm__6A601D814D1DBD56");

                entity.ToTable("Programme", "Cw2");

                entity.Property(e => e.ProgrammeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("Programme_Code");

                entity.Property(e => e.ProgrammeTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Programme_Title");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectNo)
                    .HasName("PK__Project__BC903743579E1DD8");

                entity.ToTable("Project", "Cw2");

                entity.Property(e => e.ProjectNo)
                    .ValueGeneratedNever()
                    .HasColumnName("project_No");

                entity.Property(e => e.PosterImageFile).HasColumnName("poster_image_file");

                entity.Property(e => e.ProjectDescriprion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("project_descriprion");

                entity.Property(e => e.ProjectTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("project_title");

                entity.Property(e => e.ProjectYear).HasColumnName("project_year");

                entity.Property(e => e.StudentId).HasColumnName("student_ID");

                entity.Property(e => e.ThumbnailImageFile).HasColumnName("thumbnail_image_file");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Project__poster___72910220");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Students", "Cw2");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("student_ID");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("student_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
