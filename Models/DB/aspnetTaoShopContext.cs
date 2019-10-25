using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TaoShop.Models.DB
{
    public partial class aspnetTaoShopContext : DbContext
    {
        public aspnetTaoShopContext()
        {
        }

        public aspnetTaoShopContext(DbContextOptions<aspnetTaoShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<Categorys> Categorys { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Deliverer> Deliverer { get; set; }
        public virtual DbSet<Laptop> Laptop { get; set; }
        public virtual DbSet<OderDetail> OderDetail { get; set; }
        public virtual DbSet<Oders> Oders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aspnet-TaoShop-106545AA-58D6-464F-BF44-4733CA596E85;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Categorys>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Category__737584F6798D5786")
                    .IsUnique();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Parent).HasDefaultValueSql("('0')");

                entity.Property(e => e.Slug)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("('1')");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("Updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentContent)
                    .HasColumnName("Comment_content")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CommentTime)
                    .HasColumnName("Comment_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.FullName)
                    .HasColumnName("Full_name")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LaptopId).HasColumnName("Laptop_id");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_number")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.HasOne(d => d.Laptop)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.LaptopId)
                    .HasConstraintName("FK_Comment_Laptop");
            });

            modelBuilder.Entity<Deliverer>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Laptop>(entity =>
            {
                entity.HasIndex(e => e.NameLap)
                    .HasName("UQ__Laptop__863E9E1352594A89")
                    .IsUnique();

                entity.Property(e => e.Battery)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Bluetooth)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Camera)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpuSpeed)
                    .HasColumnName("Cpu_speed")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndPromotion)
                    .HasColumnName("End_promotion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Memory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameLap)
                    .IsRequired()
                    .HasColumnName("Name_lap")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Os)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalePrice).HasColumnName("Sale_price");

                entity.Property(e => e.Size)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartPromotion)
                    .HasColumnName("Start_promotion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("Updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Waranty)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Wlan)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.Laptop)
                    .HasForeignKey(d => d.CatId)
                    .HasConstraintName("FK_Laptop_Categorys");
            });

            modelBuilder.Entity<OderDetail>(entity =>
            {
                entity.ToTable("Oder_detail");

                entity.Property(e => e.OderId).HasColumnName("Oder_id");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("Product_id");

                entity.HasOne(d => d.Oder)
                    .WithMany(p => p.OderDetail)
                    .HasForeignKey(d => d.OderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oder_detail_Oders");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oder_detail_Laptop");
            });

            modelBuilder.Entity<Oders>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                    .HasColumnName("Created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DelivererId).HasColumnName("Deliverer_id");

                entity.Property(e => e.DeliveryAddress)
                    .IsRequired()
                    .HasColumnName("Delivery_address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("('0')");

                entity.Property(e => e.TotalPrice).HasColumnName("Total_price");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("Updated_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User_id")
                    .HasMaxLength(450);

                entity.HasOne(d => d.Deliverer)
                    .WithMany(p => p.Oders)
                    .HasForeignKey(d => d.DelivererId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oders_Deliverer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Oders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oders_AspNetUsers");
            });
        }
    }
}
