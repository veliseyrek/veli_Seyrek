using System;
using Cozum.Rapor.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Cozum.Rapor.Data
{
    public partial class COZUMREPORTContext : DbContext
    {
        public COZUMREPORTContext()
        {
        }

        public COZUMREPORTContext(DbContextOptions<COZUMREPORTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NsPersonel> NsPersonels { get; set; }
        public virtual DbSet<RprDirectory> RprDirectories { get; set; }
        public virtual DbSet<RprUser> RprUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=HP;Database=Cozum;User=sa;Password=1234");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<NsPersonel>(entity =>
            {
                entity.HasKey(e => e.PersonelNo);

                entity.ToTable("NS_PERSONEL");

                entity.Property(e => e.PersonelNo).HasColumnName("PERSONEL_NO");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADI");

                entity.Property(e => e.Adisoyadi)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ADISOYADI");

                entity.Property(e => e.Soyadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOYADI");

                entity.Property(e => e.Unvani)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UNVANI");
            });

            modelBuilder.Entity<RprDirectory>(entity =>
            {
                entity.HasKey(e => e.Num);

                entity.ToTable("RPR_DIRECTORY");

                entity.Property(e => e.Num)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NUM");

                entity.Property(e => e.Ctimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("CTIMESTAMP")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PersonelNo).HasColumnName("PERSONEL_NO");

                entity.Property(e => e.Sube)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUBE");

                entity.Property(e => e.Tur)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TUR");

                entity.Property(e => e.Varsayilan)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("VARSAYILAN")
                    .HasDefaultValueSql("('H')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RprUser>(entity =>
            {
                entity.ToTable("RPR_USERS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Departmant)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMANT");

                entity.Property(e => e.EMail)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("E_MAIL");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
