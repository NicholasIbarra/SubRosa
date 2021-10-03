using System;
using Microsoft.EntityFrameworkCore;
using SubRosa.Domain.Entities;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SubRosa.Infrastructure
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<ElectionVote> ElectionVote { get; set; }
        public virtual DbSet<ExecutivePower> ExecutivePower { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<GamePlayer> GamePlayer { get; set; }
        public virtual DbSet<GameStateId> GameStateId { get; set; }
        public virtual DbSet<Government> Government { get; set; }
        public virtual DbSet<GovernmentOutcome> GovernmentOutcome { get; set; }
        public virtual DbSet<Membership> Membership { get; set; }
        public virtual DbSet<MembershipRoleId> MembershipRoleId { get; set; }
        public virtual DbSet<Player> Player { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=SubRosa;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.FascistBoard)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ElectionVote>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Style).HasMaxLength(1000);
            });

            modelBuilder.Entity<ExecutivePower>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Style).HasMaxLength(1000);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GameStateId>(entity =>
            {
                entity.HasKey(e => e.GameStateId1)
                    .HasName("PK__GameStat__25922D74ECEF36B6");

                entity.Property(e => e.GameStateId1).HasColumnName("GameStateId");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Style).HasMaxLength(1000);
            });

            modelBuilder.Entity<GovernmentOutcome>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Style).HasMaxLength(1000);
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Style).HasMaxLength(1000);
            });

            modelBuilder.Entity<MembershipRoleId>(entity =>
            {
                entity.HasKey(e => e.MembershipRoleId1)
                    .HasName("PK__Membersh__AB4F8E5A2E966798");

                entity.Property(e => e.MembershipRoleId1).HasColumnName("MembershipRoleId");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Image).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Style).HasMaxLength(1000);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Image).HasMaxLength(1000);

                entity.Property(e => e.Password).HasMaxLength(1000);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
