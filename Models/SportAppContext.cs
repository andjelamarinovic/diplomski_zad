using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SportApp.Models
{
    public partial class SportAppContext : DbContext
    {
        public SportAppContext()
        {
        }

        public SportAppContext(DbContextOptions<SportAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Norma> Norma { get; set; }
        public virtual DbSet<OcjeneSporta> OcjeneSporta { get; set; }
        public virtual DbSet<Razred> Razred { get; set; }
        public virtual DbSet<Spol> Spol { get; set; }
        public virtual DbSet<Sportovi> Sportovi { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Testiranje> Testiranje { get; set; }
        public virtual DbSet<VrstaTesta> VrstaTesta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\;Database=SportApp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Norma>(entity =>
            {
                entity.HasOne(d => d.Razred)
                    .WithMany(p => p.Norma)
                    .HasForeignKey(d => d.RazredId)
                    .HasConstraintName("FK_Norme_Razred_RazredId");

                entity.HasOne(d => d.Spol)
                    .WithMany(p => p.Norma)
                    .HasForeignKey(d => d.SpolId)
                    .HasConstraintName("FK_Norme_Spol_SpolId");

                entity.HasOne(d => d.VrstaTesta)
                    .WithMany(p => p.Norma)
                    .HasForeignKey(d => d.VrstaTestaId)
                    .HasConstraintName("FK_Norme_VrstaTesta_VrstaTestaId");

                entity.Property(s => s.Ocjena1).HasColumnType("decimal(18,2)");
                entity.Property(s => s.Ocjena2).HasColumnType("decimal(18,2)");
                entity.Property(s => s.Ocjena3).HasColumnType("decimal(18,2)");
                entity.Property(s => s.Ocjena4).HasColumnType("decimal(18,2)");
                entity.Property(s => s.Ocjena5).HasColumnType("decimal(18,2)");
            });


            modelBuilder.Entity<OcjeneSporta>(entity =>
            {
                entity.HasKey(e => e.OcjenaSportaId);

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.OcjeneSporta)
                    .HasForeignKey(d => d.SportId);

                entity.HasOne(d => d.Testiranje)
                    .WithMany(p => p.OcjeneSporta)
                    .HasForeignKey(d => d.TestiranjeId);
            });

            modelBuilder.Entity<Razred>(entity =>
            {
                entity.Property(e => e.Opis).IsRequired();
            });

            modelBuilder.Entity<Spol>(entity =>
            {
                entity.Property(e => e.NazivSpola).IsRequired();
            });

            modelBuilder.Entity<Sportovi>(entity =>
            {
                entity.HasKey(e => e.SportId);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.GodinaMajka).HasColumnType("date");

                entity.Property(e => e.GodinaOtac).HasColumnType("date");

                entity.Property(e => e.StudentDatum).HasColumnType("date");

                entity.HasOne(d => d.Spol)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.SpolId);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.Property(e => e.Ocjena).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TestRezultat).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Norma)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.NormaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Test_Norma");

                entity.HasOne(d => d.Testiranje)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.TestiranjeId);

                entity.HasOne(d => d.VrstaTesta)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.VrstaTestaId);
            });

            modelBuilder.Entity<Testiranje>(entity =>
            {
                entity.Property(e => e.DatumTest).HasColumnType("date");

                entity.HasOne(d => d.Razred)
                    .WithMany(p => p.Testiranje)
                    .HasForeignKey(d => d.RazredId);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Testiranje)
                    .HasForeignKey(d => d.StudentId);
            });
        }
    }
}
