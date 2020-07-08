using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebGame.Models.WebGame
{

    public class IdentityAppContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public IdentityAppContext(DbContextOptions<IdentityAppContext> options) : base(options)
        {

        }
    }

    public partial class webgameContext : DbContext
    {
        public webgameContext()
        { }

        public webgameContext(DbContextOptions<webgameContext> options) : base(options)
        { }

        public virtual DbSet<Aspnetroleclaims> Aspnetroleclaims
        {
            get;
            set;
        }
        public virtual DbSet<Aspnetroles> Aspnetroles
        {
            get;
            set;
        }
        public virtual DbSet<Aspnetuserclaims> Aspnetuserclaims
        {
            get;
            set;
        }
        public virtual DbSet<Aspnetuserlogins> Aspnetuserlogins
        {
            get;
            set;
        }
        public virtual DbSet<Aspnetuserroles> Aspnetuserroles
        {
            get;
            set;
        }
        public virtual DbSet<Aspnetusers> Aspnetusers
        {
            get;
            set;
        }
        public virtual DbSet<Aspnetusertokens> Aspnetusertokens
        {
            get;
            set;
        }
        public virtual DbSet<AttDef> AttDef
        {
            get;
            set;
        }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory
        {
            get;
            set;
        }
        public virtual DbSet<Player> Player
        {
            get;
            set;
        }
        public virtual DbSet<Playeraccount> Playeraccount
        {
            get;
            set;
        }
        public virtual DbSet<Tower> Tower
        {
            get;
            set;
        }
        public virtual DbSet<World> World
        {
            get;
            set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server = localhost; Database = webgame_DB; user = root; password = WebGame;", x => x.ServerVersion("8.0.20-mysql"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Efmigrationshistory>(entity => entity.Property(m => m.MigrationId).HasMaxLength(85));
            modelBuilder.Entity<Efmigrationshistory>(entity => entity.Property(m => m.ProductVersion).HasMaxLength(85));
            modelBuilder.Entity<Aspnetusers>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            modelBuilder.Entity<Aspnetusers>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(85));
            modelBuilder.Entity<Aspnetusers>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(85));
            modelBuilder.Entity<Aspnetroles>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            modelBuilder.Entity<Aspnetroles>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(85));
            modelBuilder.Entity<Aspnetuserlogins>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            modelBuilder.Entity<Aspnetuserlogins>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(85));
            modelBuilder.Entity<Aspnetuserlogins>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            modelBuilder.Entity<Aspnetuserlogins>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            modelBuilder.Entity<Aspnetuserroles>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));
            modelBuilder.Entity<Aspnetusertokens>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            modelBuilder.Entity<Aspnetusertokens>(entity => entity.Property(m => m.Name).HasMaxLength(85));
            modelBuilder.Entity<Aspnetuserclaims>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            modelBuilder.Entity<Aspnetuserclaims>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            modelBuilder.Entity<Aspnetroleclaims>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            modelBuilder.Entity<Aspnetroleclaims>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));

            modelBuilder.Entity<Aspnetroleclaims>(entity =>
           {
               entity.ToTable("aspnetroleclaims");

               entity.HasIndex(e => e.RoleId)
                   .HasName("IX_AspNetRoleClaims_RoleId");

               entity.Property(e => e.ClaimType)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.ClaimValue)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.HasOne(d => d.Role)
                   .WithMany(p => p.Aspnetroleclaims)
                   .HasForeignKey(d => d.RoleId)
                   .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
           });

            modelBuilder.Entity<Aspnetroles>(entity =>
           {
               entity.ToTable("aspnetroles");

               entity.HasIndex(e => e.NormalizedName)
                   .HasName("RoleNameIndex")
                   .IsUnique();

               entity.Property(e => e.ConcurrencyStamp)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.Name)
                   .HasColumnType("varchar(256)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.NormalizedName)
                   .HasColumnType("varchar(256)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");
           });

            modelBuilder.Entity<Aspnetuserclaims>(entity =>
           {
               entity.ToTable("aspnetuserclaims");

               entity.HasIndex(e => e.UserId)
                   .HasName("IX_AspNetUserClaims_UserId");

               entity.Property(e => e.ClaimType)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.ClaimValue)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.HasOne(d => d.User)
                   .WithMany(p => p.Aspnetuserclaims)
                   .HasForeignKey(d => d.UserId)
                   .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
           });

            modelBuilder.Entity<Aspnetuserlogins>(entity =>
           {
               entity.HasKey(e => new
               {
                   e.LoginProvider,
                   e.ProviderKey
               })
                   .HasName("PRIMARY");

               entity.ToTable("aspnetuserlogins");

               entity.HasIndex(e => e.UserId)
                   .HasName("IX_AspNetUserLogins_UserId");

               entity.Property(e => e.LoginProvider)
                   .HasColumnType("varchar(100)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.ProviderKey)
                   .HasColumnType("varchar(100)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.ProviderDisplayName)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.HasOne(d => d.User)
                   .WithMany(p => p.Aspnetuserlogins)
                   .HasForeignKey(d => d.UserId)
                   .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
           });

            modelBuilder.Entity<Aspnetuserroles>(entity =>
           {
               entity.HasKey(e => new
               {
                   e.UserId,
                   e.RoleId
               })
                   .HasName("PRIMARY");

               entity.ToTable("aspnetuserroles");

               entity.HasIndex(e => e.RoleId)
                   .HasName("IX_AspNetUserRoles_RoleId");

               entity.HasOne(d => d.Role)
                   .WithMany(p => p.Aspnetuserroles)
                   .HasForeignKey(d => d.RoleId)
                   .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

               entity.HasOne(d => d.User)
                   .WithMany(p => p.Aspnetuserroles)
                   .HasForeignKey(d => d.UserId)
                   .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
           });

            modelBuilder.Entity<Aspnetusers>(entity =>
           {
               entity.ToTable("aspnetusers");

               entity.HasIndex(e => e.NormalizedEmail)
                   .HasName("EmailIndex");

               entity.HasIndex(e => e.NormalizedUserName)
                   .HasName("UserNameIndex")
                   .IsUnique();

               entity.Property(e => e.ConcurrencyStamp)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.Email)
                   .HasColumnType("varchar(256)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.FirstName)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.LastName)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.NormalizedEmail)
                   .HasColumnType("varchar(256)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.NormalizedUserName)
                   .HasColumnType("varchar(256)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.PasswordHash)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.PhoneNumber)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.SecurityStamp)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.UserName)
                   .HasColumnType("varchar(256)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");
           });

            modelBuilder.Entity<Aspnetusertokens>(entity =>
           {
               entity.HasKey(e => new
               {
                   e.UserId,
                   e.LoginProvider,
                   e.Name
               })
                   .HasName("PRIMARY");

               entity.ToTable("aspnetusertokens");

               entity.Property(e => e.LoginProvider)
                   .HasColumnType("varchar(100)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.Name)
                   .HasColumnType("varchar(100)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.Value)
                   .HasColumnType("longtext")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.HasOne(d => d.User)
                   .WithMany(p => p.Aspnetusertokens)
                   .HasForeignKey(d => d.UserId)
                   .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
           });

            modelBuilder.Entity<AttDef>(entity =>
           {
               entity.ToTable("att_def");
           });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
           {
               entity.HasKey(e => e.MigrationId)
                   .HasName("PRIMARY");

               entity.ToTable("__efmigrationshistory");

               entity.Property(e => e.MigrationId)
                   .HasColumnType("varchar(20)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");

               entity.Property(e => e.ProductVersion)
                   .IsRequired()
                   .HasColumnType("varchar(32)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");
           });

            modelBuilder.Entity<Player>(entity =>
           {
               entity.ToTable("player");
           });

            modelBuilder.Entity<Playeraccount>(entity =>
           {
               entity.ToTable("playeraccount");

               entity.Property(e => e.AccountName)
                   .IsRequired()
                   .HasColumnType("varchar(256)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");
           });

            modelBuilder.Entity<Tower>(entity =>
           {
               entity.ToTable("tower");

               entity.Property(e => e.TowerName)
                   .IsRequired()
                   .HasColumnType("char(10)")
                   .HasCharSet("utf8mb4")
                   .HasCollation("utf8mb4_0900_ai_ci");
           });

            modelBuilder.Entity<World>(entity =>
           {
               entity.ToTable("world");

               entity.HasIndex(e => e.WorldId)
                   .HasName("WorldId");

               entity.Property(e => e.GameFinished).HasDefaultValueSql("'0'");

               entity.Property(e => e.GameStarted).HasDefaultValueSql("'0'");
           });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}